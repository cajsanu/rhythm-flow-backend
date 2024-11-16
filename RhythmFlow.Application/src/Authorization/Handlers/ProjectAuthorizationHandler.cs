using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.DTOs.Projects;
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
            // Get project ID from the request body (Resource)
            var projectId = context.Resource as Guid? ?? Guid.Empty;
            if (projectId == Guid.Empty)
            {
                context.Fail();
                throw new InvalidOperationException("Project ID is missing or invalid");
            }

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                throw new InvalidOperationException("User ID claim is missing or invalid");
            }

            var project = await _projectService.GetByIdAsync(projectId);

            if (project.ManagerId == userId)
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