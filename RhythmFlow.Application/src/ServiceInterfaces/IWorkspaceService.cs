using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IWorkspaceService : IBaseService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>
    {
        // Methdo to get all workspaces owned by a user'
        Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceOwnedByUserAsync(Guid userId);

        // Method to get all workspaces joined by a user
        Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceJoinedByUserAsync(Guid userId);

        // Method to get all users in a workspace
        Task<IEnumerable<UserReadDto>> GetAllUsersInWorkspaceAsync(Guid workspaceId);
    }
}