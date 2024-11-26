using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class ProjectDtoFactory : IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>
    {
        public ProjectReadDto CreateReadDto(Project entity)
        {
            return new ProjectReadDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,

                // Need to add this because the UserInProjectHandler requires it
                Users = entity.Users.Select(u => new UserReadDto
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email.Value
                }).ToList()
            };
        }
    }
}