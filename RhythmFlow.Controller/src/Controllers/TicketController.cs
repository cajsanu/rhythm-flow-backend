using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceDeveloperPolicy")]
    [Authorize(Policy = "UserInProjectPolicy")]
    public class TicketController(ITicketService service) : BaseController<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(service)
    {
        public override async Task<ActionResult<TicketReadDto>> Add([FromBody] TicketCreateDto createDto, Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        public override async Task<ActionResult> Delete(Guid id, Guid workspaceId)
        {
            return await base.Delete(id, workspaceId);
        }

        public override async Task<ActionResult> Update(Guid id, [FromBody] TicketUpdateDto updateDto, Guid workspaceId)
        {
            return await base.Update(id, updateDto, workspaceId);
        }

        [HttpPost("assignUser/{userId}")]
        public async Task<ActionResult> AssignUserToTicket(Guid userId, Guid workspaceId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromTicket(Guid userId, Guid workspaceId)
        {
            throw new NotImplementedException();
        }
    }
}