using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IWorkspaceService : IBaseService<Workspace>
    {
        // Can we somehow extract the logic for adding/removing users
        // to/from a workspace/project/ticket to a separate service?

        // Methdo to get all workspaces owned by a user'
        Task <IEnumerable<Workspace>> GetAllWorkspaceOwnedByUser(Guid userId);

        // Method to get all workspaces joined by a user
        Task <IEnumerable<Workspace>> GetAllWorkspaceJoinedByUser(Guid userId);
    }
}