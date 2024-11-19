using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.UserWorkspaces
{
    public class UserWorkspaceReadDto
    {
        public Guid UserId { get; set; }
        public Guid WorkspaceId { get; set; }
        public Role Role { get; set; }
    }
}
