using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Services
{
    public class WorkspaceService : IWorkspaceService
    {
        public Task<WorkspaceReadDto> AddAsync(Workspace entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceJoinedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceOwnedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkspaceReadDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Workspace> UpdateAsync(Guid id, Workspace entity)
        {
            throw new NotImplementedException();
        }
    }
}