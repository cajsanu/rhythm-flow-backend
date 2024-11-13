using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceUpdateDto 
    {
        public Guid UserId { get; set; }
        public Guid WorkspaceId { get; set; }
        public Role Role { get; set; }

        public UserWorkspaceUpdateDto ToDto(UserWorkspace entity)
        {
            return new UserWorkspaceUpdateDto()
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId,
                Role = entity.Role
            };
        }
        public UserWorkspace ToEntity(UserWorkspaceUpdateDto dto)
        {
            return new UserWorkspace(dto.UserId, dto.WorkspaceId, dto.Role);
        }
    }
}
