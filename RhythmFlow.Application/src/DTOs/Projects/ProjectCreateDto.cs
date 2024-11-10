using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectCreateDto : IBaseCreateDto<Project>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<UserReadDto> Users { get; set; } = [];

        public IBaseCreateDto<Project> ToDto(Project entity)
        {
            return new ProjectCreateDto()
            {
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
                Users = entity.Users.Select(u => new UserReadDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email.Value
                    // Add other properties as needed
                }).ToList()

            };
        }
        public Project ToEntity()
        {
            return new Project(Name, Description, StartDate, EndDate, Status, WorkspaceId);
        }
    }
}