using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IWorkspaceRepo : IBaseRepo<Workspace>
    {
        // For workspace we could include projects when getting by id from the repo
        // so we can get all the projects in a workspace and not need a separate method for it

        // Add methods for assigning a user to a workspace and removing a user from a workspace
        // AssignUserToWorkspace()
        // RemoveUserFromWorkspace()

        // Add methods for getting all workspaces owned by a user and all workspaces joined by a user
        // GetAllWorkspaceOwnedByUser()
        // GetAllWorkspaceJoinedByUser()
    }
}