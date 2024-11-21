using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.ServiceInterfaces;


namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class WorkspaceRoleHandler(IUserWorkspaceService userWorkspaceService, IHttpContextAccessor httpContextAccessor) : AuthorizationHandler<RoleInWorkspaceRequirement>
    {
        private readonly IUserWorkspaceService _userWorkspaceService = userWorkspaceService;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            RoleInWorkspaceRequirement requirement)
        {

            Console.WriteLine("Workspace Role Handler");
            // Extract workspace ID from route data
            var routeData = _httpContextAccessor.HttpContext?.GetRouteData();
            Console.WriteLine("Route Data: " + routeData);
            if (routeData == null || !routeData.Values.TryGetValue("workspaceId", out var workspaceIdValue)
                || !Guid.TryParse(workspaceIdValue?.ToString(), out var workspaceId))
            {
                context.Fail();
                return;
            }

            Console.WriteLine("Workspace ID: " + workspaceId);

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