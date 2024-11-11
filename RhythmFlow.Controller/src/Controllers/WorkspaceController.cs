using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    public class WorkspaceController(IBaseService<Workspace> service) : BaseController<Workspace>(service)
    {
        [HttpPost("addUser/{userId}")]
        public async Task<ActionResult> AddUserToWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}