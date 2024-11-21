using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceDeveloperPolicy")]
    public class ProjectController(IProjectService service) : BaseController<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(service)
    {
        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult<ProjectReadDto>> Add([FromBody] ProjectCreateDto createDto, Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] ProjectUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        [HttpPost("assignUser/{userId}")]
        public async Task<ActionResult> AssignUserToProject(Guid userId)
        {
            throw new NotImplementedException();
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromProject(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}