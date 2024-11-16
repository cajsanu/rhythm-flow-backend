using Microsoft.AspNetCore.Authorization;

namespace RhythmFlow.Application.src.Authorization
{
    public class RoleInWorkspaceRequirement(string requiredRole) : IAuthorizationRequirement
    {
        public string RequiredRole { get; } = requiredRole;
    }
}