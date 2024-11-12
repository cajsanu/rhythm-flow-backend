using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    public class WorkspaceController(IWorkspaceService service) : BaseController<Workspace, WorkspaceReadDto>(service)
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