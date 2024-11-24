using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceDeveloperPolicy")]
    public class ProjectController(IProjectService service) : BaseController<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(service)
    {
        private readonly IProjectService _service = service;

        public override async Task<ActionResult<IEnumerable<ProjectReadDto>>> GetAll()
        {
            var workspaceId = Guid.Parse(HttpContext.GetRouteValue("workspaceId")?.ToString());
            var projects = await _service.GetAllProjectsInWorkspaceAsync(workspaceId);
            return Ok(projects);
        }

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