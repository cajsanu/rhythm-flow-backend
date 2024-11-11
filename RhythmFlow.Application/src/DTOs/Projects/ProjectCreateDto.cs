using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectCreateDto : IBaseCreateDto<Project>, IValidatableObject
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<Guid> UsersId { get; set; } = [];

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
                UsersId = entity.Users.Select(u => u.Id).ToList()

            };
        }
        public Project ToEntity()
        {
            return new Project(Name, Description, StartDate, EndDate, Status, WorkspaceId);
        }


        // For testing purposes. the test should fail if the validation fails
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult(
                    "StartDate should be earlier than EndDate.",
                    [nameof(StartDate), nameof(EndDate)]);
            }

            if (WorkspaceId == Guid.Empty)
            {
                yield return new ValidationResult(
                    "WorkspaceId cannot be empty.",
                    [nameof(WorkspaceId)]);
            }

            foreach (var userId in UsersId)
            {
                if (userId == Guid.Empty)
                {
                    yield return new ValidationResult(
                        "User ID cannot be empty.",
                        [nameof(UsersId)]);
                }
            }
        }
    }
}