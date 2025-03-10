using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IUserWorkspaceRepo
    {
        Task<UserWorkspace> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId);
        Task<IEnumerable<User>> GetAllUsersInWorkspaceAsync(Guid workspaceId);
        Task<IEnumerable<Workspace>> GetAllUserWorkspacesByUserIdAsync(Guid userId);
        Task<IEnumerable<Workspace>> GetWorkspacesOwnedByUserAsync(Guid workspaceId);
        Task<UserWorkspace?> AssignRoleToUserInWorkspaceAsync(Guid userId, Guid workspaceId, Role role);
    }
}