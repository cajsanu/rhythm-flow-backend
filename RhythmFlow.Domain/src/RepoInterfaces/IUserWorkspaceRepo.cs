using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IUserWorkspaceRepo
    {
        Task<UserWorkspace> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId);
        Task<IEnumerable<Workspace>> GetAllUserWorkspacesByUserIdAsync(Guid userId);
        Task<IEnumerable<Workspace>> GetWorkspacesOwnedByUserAsync(Guid workspaceId);
        
    }
}