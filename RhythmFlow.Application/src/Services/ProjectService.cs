using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService(IProjectRepo repository) : BaseService<Project, ProjectReadDto>(repository), IProjectService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
