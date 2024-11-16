using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization
{
    public class WorkspaceRoleHandler(IUserWorkspaceService userWorkspaceService) : AuthorizationHandler<RoleInWorkspaceRequirement>
    {
        private readonly IUserWorkspaceService _userWorkspaceService = userWorkspaceService;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            RoleInWorkspaceRequirement requirement)
        {
            // Extract the workspaceId from the request body (Resource)
            if (context.Resource is not ProjectCreateDto createProjectDto)
            {
                context.Fail();
                return;
            }

            Guid workspaceId = createProjectDto.WorkspaceId;

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                throw new InvalidOperationException("User ID claim is missing or invalid");
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