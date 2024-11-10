using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceReadDto 
    {
        public Guid UserId { get; set; }
        public Guid WorkspaceId { get; set; }
        public RoleEnum Role { get; set; }

        public UserWorkspaceReadDto ToDto(UserWorkspace entity)
        {
            return new UserWorkspaceReadDto()
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId,
                Role = entity.Role
            };
        }
    }
}


