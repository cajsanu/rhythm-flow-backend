using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IWorkspaceService : IBaseService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>
    {
        // Methdo to get all workspaces owned by a user'
        Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceOwnedByUser(Guid userId);

        // Method to get all workspaces joined by a user
        Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceJoinedByUser(Guid userId);
    }
}