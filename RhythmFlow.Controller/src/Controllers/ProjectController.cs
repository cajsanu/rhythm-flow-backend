using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    // [Authorize(Policy = "UserInProjectPolicy")]
    public class ProjectController(IProjectService service) : BaseController<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(service)
    {
        [Authorize]
        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult<ProjectReadDto>> Add([FromBody] ProjectCreateDto createDto)
        {
            return await base.Add(createDto);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [HttpPost("assignUser/{userId}")]
        // [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public async Task<ActionResult> AssignUserToProject(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        // [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public async Task<ActionResult> RemoveUserFromProject(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}