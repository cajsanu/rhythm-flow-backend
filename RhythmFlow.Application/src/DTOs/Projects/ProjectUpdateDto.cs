using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectUpdateDto : IBaseUpdateDto<Project>
    {
        required public string Name { get; set; }
        required public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<Guid> UsersId { get; set; } = [];

        public IBaseUpdateDto<Project> ToDto(Project entity)
        {
            return new ProjectUpdateDto()
            {
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
            };
        }

        // Exlamation mark is used to tell the compiler that the value is not null
        public Project ToEntity(Guid guid)
        {
            return new Project(Name, Description, StartDate, EndDate, Status, WorkspaceId, guid);
        }
    }
}