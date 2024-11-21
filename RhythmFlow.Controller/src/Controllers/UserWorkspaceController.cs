using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceOwnerPolicy")]
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class UserWorkspaceController(IUserWorkspaceService service)
    {
        [HttpGet("{userId}")]
        public async Task<ActionResult> AddUserToWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}