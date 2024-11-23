using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo repository, IWorkspaceRepo workspaceRepo, IUserWorkspaceDtoFactory userWorkspaceDtoFactory) : IUserWorkspaceService
    {
        public Task<UserWorkspaceReadDto> AssignUserRoleInWorkspaceAsync(UserWorkspaceCreateDto userWorkspaceCreateDto)
        {
            // We need to make sure that you cannot assign owner role to the user other than the owner the workspace.
            // validation needs to be done here.
            var workspace = workspaceRepo.GetByIdAsync(userWorkspaceCreateDto.WorkspaceId).Result;
            if (userWorkspaceCreateDto.Role == Role.WorkspaceOwner || workspace.OwnerId != userWorkspaceCreateDto.UserId)
            {
                throw new InvalidOperationException("Cannot assign owner role to a user.");
            }

            var userRoleUpdate = repository.AssignRoleToUserInWorkspace(userWorkspaceCreateDto.UserId, userWorkspaceCreateDto.WorkspaceId, userWorkspaceCreateDto.Role).Result;
            if (userRoleUpdate == null)
            {
                throw new InvalidOperationException($"User with ID {userWorkspaceCreateDto.UserId} is not a member of workspace with ID {userWorkspaceCreateDto.WorkspaceId}.");
            }

            UserWorkspaceReadDto userWorkspace = userWorkspaceDtoFactory.CreateReadDto(userRoleUpdate);
            return Task.FromResult(userWorkspace);
        }

        public async Task<Role> GetUserRoleInWorkspaceAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = await repository.GetUserWorkspaceByUserIdAndWorkspaceIdAsync(userId, workspaceId)
                ?? throw new InvalidOperationException($"User with ID {userId} is not a member of workspace with ID {workspaceId}.");
            return userWorkspace.Role;
        }
    }
}