using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IWorkspaceRepo : IBaseRepo<Workspace>
    {
        // Add methods for getting all workspaces owned by a user and all workspaces joined by a user
        // GetAllWorkspaceOwnedByUser()
        // GetAllWorkspaceJoinedByUser()
    }
}