using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
            Console.WriteLine("WS REQUIERMENT " + string.Join(", ", requirement.ValidRoles));
            Console.WriteLine("USER " + context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            // Ensure context.Resource is an HttpContext
            if (context.Resource is not HttpContext httpContext)
            {
                context.Fail();
                return;
            }

            // Extract workspaceId from the query string
            var workspaceIdQuery = httpContext.Request.Query["workspaceId"];
            if (!Guid.TryParse(workspaceIdQuery, out var workspaceId))
            {
                context.Fail();
                return;
            }

            Console.WriteLine("RESOURCE GUID " + workspaceId);

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                return;
            }

            var userRole = await _userWorkspaceService.GetUserRoleInWorkspaceAsync(userId, workspaceId);
            if (requirement.ValidRoles.Contains(userRole))
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