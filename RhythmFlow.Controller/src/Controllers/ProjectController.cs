using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Users;
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
            var workspaceId = Guid.Parse(HttpContext.GetRouteValue("workspaceId")?.ToString() ?? "");
            var projects = await _service.GetAllProjectsInWorkspaceAsync(workspaceId);
            return Ok(projects);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        public override async Task<ActionResult<ProjectReadDto>> Add([FromBody] ProjectCreateDto createDto)
        {
            // Make sure the workspaceId in the route and in the body are the same
            // so that the project is added to the correct workspace
            var workspaceId = Guid.Parse(HttpContext.GetRouteValue("workspaceId")?.ToString() ?? "");

            if (workspaceId != createDto.WorkspaceId)
                return BadRequest("WorkspaceId in the route and in the new project should match");

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
                return Unauthorized();

            createDto.UserIds.Add(Guid.Parse(userId));

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
        [HttpGet("{projectId}/users")]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetAllUsersInProject(Guid projectId)
        {
            var users = await _service.GetAllUsersInProjectAsync(projectId);
            return Ok(users);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        [HttpPost("{projectId}/users/{userId}")]
        public async Task<ActionResult<ProjectReadDto>> AssignUserToProject(Guid userId, Guid projectId)
        {
            // need to check if user is in workspace here or in the service layer
            var projectReadDto = await _service.AssignUserToProjectAsync(userId, projectId);
            return Ok(projectReadDto);
        }

        [Authorize(Policy = "WorkspaceProjectManagerPolicy")]
        [HttpDelete("{projectId}/users/{userId}")]
        public async Task<ActionResult<ProjectReadDto>> RemoveUserFromProject(Guid userId, Guid projectId)
        {
            var projectReadDto = await _service.RemoveUserFromProjectAsync(userId, projectId);
            return Ok(projectReadDto);
        }
    }
}