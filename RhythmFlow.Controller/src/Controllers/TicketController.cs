using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Authorize(Policy = "WorkspaceDeveloperPolicy")]
    [Authorize(Policy = "UserInProjectPolicy")]
    [ApiController]
    [Route("api/v1/workspaces/{workspaceId}/projects/{projectId}/[controller]s")]
    public class TicketController(ITicketService service) : BaseController<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(service)
    {
        private readonly ITicketService _service = service;
        public async override Task<ActionResult<IEnumerable<TicketReadDto>>> GetAll()
        {
            var projectId = Guid.Parse(HttpContext.GetRouteValue("projectId")?.ToString());
            var tickets = await _service.GetAllTicketsInProjectAsync(projectId);
            return Ok(tickets);
        }

        public override async Task<ActionResult<TicketReadDto>> GetById(Guid id)
        {
            return await base.GetById(id);
        }

        public override async Task<ActionResult<TicketReadDto>> Add([FromBody] TicketCreateDto createDto, Guid workspaceId)
        {
            return await base.Add(createDto, workspaceId);
        }

        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        public override async Task<ActionResult> Update(Guid id, [FromBody] TicketUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }

        [HttpPost("assignUser/{userId}")]
        public async Task<ActionResult> AssignUserToTicket(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("removeUser/{userId}")]
        public async Task<ActionResult> RemoveUserFromTicket(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}