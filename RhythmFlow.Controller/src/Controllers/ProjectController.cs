using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
    public class ProjectController(IProjectService service) : BaseController<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(service)
    {
        public override async Task<ActionResult<ProjectReadDto>> Add([FromBody] ProjectCreateDto createDto, [FromQuery] Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        public override async Task<ActionResult> Delete(Guid id, [FromQuery] Guid workspaceId)
        {
            return await base.Delete(id, workspaceId);
        }

        public override async Task<ActionResult> Update(Guid id, [FromBody] ProjectUpdateDto updateDto, [FromQuery] Guid workspaceId)
        {
            return await base.Update(id, updateDto, workspaceId);
        }

        [HttpPost("assignUser/{userId}")]
        public async Task<ActionResult> AssignUserToProject(Guid userId, [FromQuery] Guid workspaceId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromProject(Guid userId, [FromQuery] Guid workspaceId)
        {
            throw new NotImplementedException();
        }
    }
}