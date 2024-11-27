using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo userWorkspaceRepo, IUserWorkspaceDtoFactory userWorkspaceDtoFactory) : IUserWorkspaceService
    {
        private readonly IUserWorkspaceRepo _userWorkspaceRepo = userWorkspaceRepo;
        public async Task<UserWorkspaceReadDto> AssignUserRoleInWorkspaceAsync(UserWorkspaceCreateDto userWorkspaceCreateDto)
        {
            var userRoleUpdate = await _userWorkspaceRepo.AssignRoleToUserInWorkspaceAsync(userWorkspaceCreateDto.UserId, userWorkspaceCreateDto.WorkspaceId, userWorkspaceCreateDto.Role)
                ?? throw new InvalidOperationException($"User with ID {userWorkspaceCreateDto.UserId} is not a member of workspace with ID {userWorkspaceCreateDto.WorkspaceId}.");
            UserWorkspaceReadDto userWorkspace = userWorkspaceDtoFactory.CreateReadDto(userRoleUpdate);
            return await Task.FromResult(userWorkspace);
        }

        public async Task<Role> GetUserRoleInWorkspaceAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = await _userWorkspaceRepo.GetUserWorkspaceByUserIdAndWorkspaceIdAsync(userId, workspaceId)
                ?? throw new InvalidOperationException($"User with ID {userId} is not a member of workspace with ID {workspaceId}.");
            return userWorkspace.Role;
        }
    }
}