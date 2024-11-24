using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceOwnerPolicy")]
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class UserWorkspaceController(IUserWorkspaceService service)
    {
        [HttpPost]
        public async Task<ActionResult<UserWorkspaceReadDto>> AddUserToWorkspace([FromBody] UserWorkspaceCreateDto addUserToWorkspaceDto)
        {
            return await service.AssignUserRoleInWorkspaceAsync(addUserToWorkspaceDto);
        }
    }
}