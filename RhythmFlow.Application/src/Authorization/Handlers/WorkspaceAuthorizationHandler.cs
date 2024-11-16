using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class WorkspaceRoleHandler(IUserWorkspaceService userWorkspaceService) : AuthorizationHandler<RoleInWorkspaceRequirement>
    {
        private readonly IUserWorkspaceService _userWorkspaceService = userWorkspaceService;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            RoleInWorkspaceRequirement requirement)
        {
            // Extract the workspaceId from the request resource
            var workspaceId = context.Resource as Guid? ?? Guid.Empty;

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                return;
            }

            var userRole = await _userWorkspaceService.GetUserRoleInWorkspaceAsync(userId, workspaceId);
            if (userRole.ToString() == requirement.RequiredRole)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
    }
}