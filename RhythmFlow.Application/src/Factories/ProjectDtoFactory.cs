using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class ProjectDtoFactory : IDtoFactory<Project, ProjectReadDto>
    {
        public ProjectReadDto CreateDto(Project entity)
        {
            return new ProjectReadDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Status = entity.Status,
            };
        }
    }
}