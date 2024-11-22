using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo repository, UserWorkspaceDtoFactory userWorkspaceDtoFactory) : IUserWorkspaceService
    {
        public Task<UserWorkspaceReadDto> AssignUserRoleInWorkspaceAsync(UserWorkspaceUpdateDto userWorkspaceUpdateDto)
        {
            // We need to make sure that you cannot assign owner role. 
            // validation needs to be done here 
            
            var userRoleUpdate = repository.AssignRoleToUserInWorkspace(userWorkspaceUpdateDto.UserId, userWorkspaceUpdateDto.WorkspaceId, userWorkspaceUpdateDto.Role).Result;
            if (userRoleUpdate == null)
            {
                throw new InvalidOperationException($"User with ID {userWorkspaceUpdateDto.UserId} is not a member of workspace with ID {userWorkspaceUpdateDto.WorkspaceId}.");
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