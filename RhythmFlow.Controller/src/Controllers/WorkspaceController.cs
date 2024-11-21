using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class WorkspaceController(IWorkspaceService service) : BaseController<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(service)
    {
        public override async Task<ActionResult<WorkspaceReadDto>> Add([FromBody] WorkspaceCreateDto createDto, Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] WorkspaceUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpPost("addUser/{userId}")]
        public async Task<ActionResult> AddUserToWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromWorkspace(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}