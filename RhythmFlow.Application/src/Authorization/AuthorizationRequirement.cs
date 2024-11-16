using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Authorization
{
    public class RoleInWorkspaceRequirement(Guid workspaceId, Role requiredRole) : IAuthorizationRequirement
    {
        public Guid WorkspaceId { get; } = workspaceId;
        public Role RequiredRole { get; } = requiredRole;
    }
}