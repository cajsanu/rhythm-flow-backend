using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class WorkspaceService(IWorkspaceRepo repository) : BaseService<Workspace, WorkspaceReadDto>(repository), IWorkspaceService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
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

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}