using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceCreateDto 
    {
        [Required]
        [NoEmptyGuid]
        public Guid UserId { get; set; }
        [Required]
         [NoEmptyGuid]
        public Guid WorkspaceId { get; set; }
        [Required]
        [EnumDataType(typeof(Role))]
        public Role Role { get; set; }

        public UserWorkspaceCreateDto ToDto(UserWorkspace entity)
        {
            return new UserWorkspaceCreateDto()
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId,
                Role = entity.Role
            };
        }

        public UserWorkspace ToEntity()
        {
            return new UserWorkspace(UserId, WorkspaceId, Role);
        }


       
    }
}
