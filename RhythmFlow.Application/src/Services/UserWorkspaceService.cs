using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo repository) : IUserWorkspaceService
    {
        public async Task<Role> GetUserRoleInWorkspaceAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = await repository.GetUserWorkspaceByUserIdAndWorkspaceIdAsync(userId, workspaceId)
                ?? throw new InvalidOperationException($"User with ID {userId} is not a member of workspace with ID {workspaceId}.");
            return userWorkspace.Role;
        }
    }
}