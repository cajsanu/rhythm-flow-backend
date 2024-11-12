using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IWorkspaceService : IBaseService<Workspace, WorkspaceReadDto>, IAssignmentService<Workspace>
    {
        // Methdo to get all workspaces owned by a user'
        Task<IEnumerable<Workspace>> GetAllWorkspaceOwnedByUser(Guid userId);

        // Method to get all workspaces joined by a user
        Task<IEnumerable<Workspace>> GetAllWorkspaceJoinedByUser(Guid userId);
    }
}