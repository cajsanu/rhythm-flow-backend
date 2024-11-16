using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class ManagerInProjectHandler(IProjectService projectService) : AuthorizationHandler<ManagerInProjectRequirement>
    {
        private readonly IProjectService _projectService = projectService;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            ManagerInProjectRequirement requirement)
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

            // Validate if the user is the manager of the project
            var project = await _projectService.GetByIdAsync(projectId);

            if (project != null && project.ManagerId == userId)
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