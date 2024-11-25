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

            // here createDto takes owner of the request and change the ownerId of the Workspace accordingly
            // createDto.OwnerId = Guid.Parse(userId);
            // or we can do a small check here to check if the same user create workspace with their own id
            if (Guid.Parse(userId) != createDto.OwnerId)
            {
                throw new UnauthorizedAccessException("Workspace must be created by same user");
            }

            // maybe we should also have a check for duplicates since one user can create many projects with the same name atm
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

        // Since all workspaces and all users are public information this should be ok to be exposed to the public
        [HttpGet("ownedby/userId")]
        public async Task<ActionResult<IEnumerable<WorkspaceCreateDto>>> GetWorkspacesOwnedByUser(Guid userId)
        {
            return Ok(await service.GetAllWorkspaceOwnedByUser(userId));
        }

        [HttpGet("joinedby/userId")]
        public async Task<ActionResult<IEnumerable<WorkspaceCreateDto>>> GetWorkspacesJoinedByUser(Guid userId)
        {
            return Ok(await service.GetAllWorkspaceJoinedByUser(userId));
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpDelete("{id}")] // id here is workspace id
        public override async Task<ActionResult> Delete(Guid id)
        {
            Console.WriteLine("Delete called with id: " + id);
            return await base.Delete(id);
        }

        [Authorize(Policy = "WorkspaceOwnerPolicy")]
        [HttpPut("{id}")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] WorkspaceUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }
    }
}