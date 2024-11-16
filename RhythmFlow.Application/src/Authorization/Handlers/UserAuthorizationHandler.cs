using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class UserInProjectHandler(IProjectService projectService) : AuthorizationHandler<UserInProjectRequirement>
    {
        private readonly IProjectService _projectService = projectService;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            UserInProjectRequirement requirement)
        {
            // Get project ID from the request resource
            var projectId = context.Resource as Guid? ?? Guid.Empty;
            if (projectId == Guid.Empty)
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