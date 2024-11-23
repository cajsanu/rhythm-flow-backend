using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectCreateDto : IBaseCreateDto<Project>
    {
        [Required]
        required public string Name { get; set; }
        required public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        [FutureDate]
        public DateOnly EndDate { get; set; }
        public Status Status { get; set; }
        [NoEmptyGuid]
        public Guid WorkspaceId { get; set; }

        [NoEmptyGuid(ValidateCollection = true)]
        public ICollection<Guid> UsersId { get; set; } = [];

        public Project ToEntity()
        {
            return new Project(Name, Description, StartDate, EndDate, Status, WorkspaceId);
        }
    }
}