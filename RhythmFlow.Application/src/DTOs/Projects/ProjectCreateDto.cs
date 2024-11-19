using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectCreateReadDto : IBaseCreateReadDto<Project>
    {
        [Required]
        required public string Name { get; set; }
        required public string Description { get; set; }
        public DateTime StartDate { get; set; }
        [FutureDate]
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        [NoEmptyGuid]
        public Guid WorkspaceId { get; set; }
        [NoEmptyGuid(ValidateCollection = true)]
        public ICollection<Guid> UsersId { get; set; } = [];

        public IBaseCreateReadDto<Project> ToDto(Project entity)
        {
            return new ProjectCreateReadDto()
            {
                Name = entity.Name,
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