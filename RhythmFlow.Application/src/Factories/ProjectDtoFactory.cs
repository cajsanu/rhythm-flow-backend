using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;


namespace RhythmFlow.Application.src.Factories
{
    public class ProjectDtoFactory : IDtoFactory<Project, ProjectReadDto, ProjectCreateReadDto, ProjectUpdateDto>
    {
        public ProjectCreateReadDto CreateCreateReadDto(Project entity)
        {
            return new ProjectCreateReadDto
            {
                Name = entity.Name,
                Description = entity.Description,
                Status = entity.Status,
            };
        }

        public ProjectReadDto CreateReadDto(Project entity)
        {
            return new ProjectReadDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Status = entity.Status,
            };
        }

        public ProjectUpdateDto CreateUpdateDto(Project entity)
        {
            return new ProjectUpdateDto
            {
                Name = entity.Name,
                Description = entity.Description,
                Status = entity.Status,
            };
        }
    }
}