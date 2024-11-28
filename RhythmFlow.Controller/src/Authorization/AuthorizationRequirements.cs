using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Controller.src.Authorization
{
    public class RoleInWorkspaceRequirement(Role[] validRoles) : IAuthorizationRequirement
    {
        public Role[] ValidRoles { get; } = validRoles;
    }

    public class UserInProjectRequirement : IAuthorizationRequirement
    { }

    public class UserIsUserRequirement : IAuthorizationRequirement
    { }
}