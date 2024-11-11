using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceCreateDto : IValidatableObject
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid WorkspaceId { get; set; }
        [Required]
        public RoleEnum Role { get; set; }

        public UserWorkspaceCreateDto ToDto(UserWorkspace entity)
        {
            return new UserWorkspaceCreateDto()
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId,
                Role = entity.Role
            };
        }

        public UserWorkspace ToEntity(UserWorkspaceCreateDto dto)
        {
            return new UserWorkspace(dto.UserId, dto.WorkspaceId, dto.Role);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (UserId == Guid.Empty)
            {
                yield return new ValidationResult("UserId cannot be an empty GUID.", [nameof(UserId)]);
            }

            if (WorkspaceId == Guid.Empty)
            {
                yield return new ValidationResult("WorkspaceId cannot be an empty GUID.", [nameof(WorkspaceId)]);
            }

            if (!Enum.IsDefined(typeof(RoleEnum), Role))
            {
                yield return new ValidationResult("Role is not a valid value.", [nameof(Role)]);
            }
        }
    }
}
