using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.Entities
{
    // Create entity for UserWorkspace join table because it has additional properties (Role) besides the foreign keys
    public class UserWorkspace
    {
        public Guid UserId { get; set; }
        public Guid WorkspaceId { get; set; }
        public RoleEnum Role { get; set; }

        public UserWorkspace(Guid userId, Guid workspaceId, RoleEnum role)
        {
            UserId = userId;
            WorkspaceId = workspaceId;
            Role = role;
        }
    }
}