using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService : IProjectService
    {
        public Task<ProjectReadDto> AddAsync(Project entity)
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

        public Task<IEnumerable<ProjectReadDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectReadDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Project> UpdateAsync(Guid id, Project entity)
        {
            throw new NotImplementedException();
        }
    }
}