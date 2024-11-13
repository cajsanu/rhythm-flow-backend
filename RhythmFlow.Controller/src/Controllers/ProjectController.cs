using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    public class ProjectController(IProjectService service) : BaseController<Project, ProjectReadDto>(service)
    {
        // Get workspace by id should include all projects in the workspace
        // so no need to have a separate method for this.
        [HttpPost("assignUser/{userId}")]
        public async Task<ActionResult> AssignUserToProject(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromProject(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}