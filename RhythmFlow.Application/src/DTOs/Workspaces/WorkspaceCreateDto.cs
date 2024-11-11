using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceCreateDto : IBaseCreateDto<Workspace>, IValidatableObject
    {
        [Required]

        public string Name { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        public IBaseCreateDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceCreateDto()
            {
                Name = entity.Name,
            };
        }

        public Workspace ToEntity()
        {
            return new Workspace(Name, OwnerId);
        }

        // For testing
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
             if (OwnerId == Guid.Empty)
            {
                yield return new ValidationResult("OwnerId cannot be an empty GUID.", [nameof(OwnerId)]);
            }
        }
    }
}