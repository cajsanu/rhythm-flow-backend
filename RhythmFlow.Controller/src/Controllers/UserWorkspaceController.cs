using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Controller.src.Controllers
{
    public class UserWorkspaceController(IUserWorkspaceService service)
    {
        [HttpGet("userworkspaces/{userId}")]
        public async Task<ActionResult> AddUserToWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}