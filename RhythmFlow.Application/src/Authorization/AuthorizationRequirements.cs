using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Authorization
{
    public class RoleInWorkspaceRequirement(Role[] validRoles) : IAuthorizationRequirement
    {
        public Role[] ValidRoles { get; } = validRoles;
    }

    public class UserInProjectRequirement : IAuthorizationRequirement
    { }
}