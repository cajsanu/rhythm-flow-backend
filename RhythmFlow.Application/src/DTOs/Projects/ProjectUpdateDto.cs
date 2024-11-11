using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectUpdateDto : IBaseUpdateDto<Project>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<Guid> UsersId { get; set; } = [];

        public IBaseUpdateDto<Project> ToDto(Project entity)
        {
            return new ProjectUpdateDto()
            {
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
                UsersId = entity.Users.Select(u => u.Id).ToList()

            };
        }
        public Project ToEntity()
        {
            return new Project(Name, Description, StartDate, EndDate, Status, WorkspaceId);
        }
    }
}