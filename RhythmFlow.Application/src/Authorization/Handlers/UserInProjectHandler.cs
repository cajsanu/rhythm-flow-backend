using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class UserInProjectHandler(IProjectService projectService, IHttpContextAccessor httpContextAccessor) : AuthorizationHandler<UserInProjectRequirement>
    {
        private readonly IProjectService _projectService = projectService;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            UserInProjectRequirement requirement)
        {
            // Extract workspace ID from route data
            var routeData = _httpContextAccessor.HttpContext?.GetRouteData();
            if (routeData == null || !routeData.Values.TryGetValue("projectId", out var projectIdValue)
                || !Guid.TryParse(projectIdValue?.ToString(), out var projectId))
            {
                context.Fail();
                return;
            }

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                return;
            }

            // Validate if the user is in the project
            var project = await _projectService.GetByIdAsync(projectId);
            if (project == null)
            {
                context.Fail();
                return;
            }

            var userInProject = project.Users.Any(u => u.Id == userId);
            if (userInProject)
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