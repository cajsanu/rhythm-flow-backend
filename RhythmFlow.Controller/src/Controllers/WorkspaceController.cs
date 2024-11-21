using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceOwnerPolicy")]
    public class WorkspaceController(IWorkspaceService service) : BaseController<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(service)
    {
        public override async Task<ActionResult<WorkspaceReadDto>> Add([FromBody] WorkspaceCreateDto createDto, [FromQuery] Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        public override async Task<ActionResult> Delete(Guid id, [FromQuery] Guid workspaceId)
        {
            return await base.Delete(id, workspaceId);
        }

        public override async Task<ActionResult> Update(Guid id, [FromBody] WorkspaceUpdateDto updateDto, [FromQuery] Guid workspaceId)
        {
            return await base.Update(id, updateDto, workspaceId);
        }

        [HttpPost("addUser/{userId}")]
        public async Task<ActionResult> AddUserToWorkspace(Guid userId, [FromQuery] Guid workspaceId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromWorkspace(Guid userId, [FromQuery] Guid workspaceId)
        {
            throw new NotImplementedException();
        }
    }
}