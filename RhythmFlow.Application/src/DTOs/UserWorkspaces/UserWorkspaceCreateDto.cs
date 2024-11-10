using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceCreateDto 
    {
        public Guid UserId { get; set; }
        public Guid WorkspaceId { get; set; }
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
    }
}
