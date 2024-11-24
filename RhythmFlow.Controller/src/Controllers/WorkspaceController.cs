using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class WorkspaceController(IWorkspaceService service, IUserWorkspaceService userWorkspaceService) : BaseController<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(service)
    {
        private readonly IUserWorkspaceService _userWorkspaceService = userWorkspaceService;

        public override async Task<ActionResult<WorkspaceReadDto>> Add([FromBody] WorkspaceCreateDto createDto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return Unauthorized();

            var result = await base.Add(createDto);

            if (result.Value == null)
                return result;

            var createdWorkspace = result.Value;

            // If creation succeeded, assign the user who created the workspace as the owner of the workspace
            _ = _userWorkspaceService.AssignUserRoleInWorkspaceAsync(new UserWorkspaceCreateDto
            {
                UserId = Guid.Parse(userId),
                WorkspaceId = createdWorkspace.Id,
                Role = Role.WorkspaceOwner
            });

            return CreatedAtAction(nameof(GetById), new { id = createdWorkspace.Id }, createdWorkspace);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpDelete("{workspaceId}")]
        public override async Task<ActionResult> Delete(Guid workspaceId)
        {
            Console.WriteLine("Delete called with id: " + workspaceId);
            return await base.Delete(workspaceId);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpPut("{workspaceId}")]
        public override async Task<ActionResult> Update(Guid workspaceId, [FromBody] WorkspaceUpdateDto updateDto)
        {
            return await base.Update(workspaceId, updateDto);
        }
    }
}