using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceOwnerPolicy")]
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class UserWorkspaceController(IUserWorkspaceService service) : ControllerBase
    {
        [HttpPost("{workspaceId}")]
        public async Task<ActionResult<UserWorkspaceReadDto>> AddUserToWorkspace(Guid workspaceId, [FromBody] UserWorkspaceCreateDto addUserToWorkspaceDto)
        {
            // We need to make sure that you cannot assign owner role to the user.
            // Only the worspace creator can be the owner.
            // Validation needs to be done here.
            if (addUserToWorkspaceDto.Role == Role.WorkspaceOwner)
            {
                return BadRequest("You cannot assign owner role to the user.");
            }

            if (workspaceId != addUserToWorkspaceDto.WorkspaceId)
            {
                return BadRequest("Workspace in URL must match workspace in request body. This is temporary solution");
            }

            return await service.AssignUserRoleInWorkspaceAsync(addUserToWorkspaceDto);
        }
    }
}