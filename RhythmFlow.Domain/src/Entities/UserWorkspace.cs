using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.Entities
{
    // Create entity for UserWorkspace join table because it has additional properties (Role) besides the foreign keys
    public class UserWorkspace(Guid userId, Guid workspaceId, Role role)
    {
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; } = userId;
        [ForeignKey("Workspace")]
        [Required]
        public Guid WorkspaceId { get; set; } = workspaceId;
        public Role Role { get; set; } = role;
    }
}