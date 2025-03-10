using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(Summary = "Get all the tickets")]
        public async override Task<ActionResult<IEnumerable<TicketReadDto>>> GetAll()
        {
            var projectId = Guid.Parse(HttpContext.GetRouteValue("projectId")?.ToString() ?? "");
            var tickets = await _service.GetAllTicketsInProjectAsync(projectId);
            return Ok(tickets);
        }

        [SwaggerOperation(Summary = "Get data on a specific ticket")]
        public override async Task<ActionResult<TicketReadDto>> GetById(Guid id)
        {
            return await base.GetById(id);
        }

        [SwaggerOperation(Summary = "Create a Ticket")]
        public override async Task<ActionResult<TicketReadDto>> Add([FromBody] TicketCreateDto createDto)
        {
            // Make sure the projectId in the route and in the body are the same
            // so that the ticket is added to the correct project
            var projectId = Guid.Parse(HttpContext.GetRouteValue("projectId")?.ToString() ?? "");

            if (projectId != createDto.ProjectId)
                return BadRequest("ProjectId in the route and in the new ticket should be the same");

            return await base.Add(createDto);
        }

        [SwaggerOperation(Summary = "Delete a Ticket")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [SwaggerOperation(Summary = "Update a Ticket")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] TicketUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }

        [HttpGet("{ticketId}/users")]
        [SwaggerOperation(Summary = "Get all Users involved with a Ticket")]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetAllUsersInTicket(Guid ticketId)
        {
            var users = await _service.GetAllUsersInTicketAsync(ticketId);
            return Ok(users);
        }

        [HttpPost("{ticketId}/users/{userId}")]
        [SwaggerOperation(Summary = "Add a User to a Ticket")]
        public async Task<ActionResult<TicketReadDto>> AssignUserToTicket(Guid userId, Guid ticketId)
        {
            var ticketReadDto = await _service.AssignUserToTicketAsync(userId, ticketId);
            return Ok(ticketReadDto);
        }

        [HttpDelete("{ticketId}/users/{userId}")]
        [SwaggerOperation(Summary = "Remove a User From a Ticket")]
        public async Task<ActionResult<TicketReadDto>> RemoveUserFromTicket(Guid userId, Guid ticketId)
        {
            var ticketReadDto = await _service.RemoveUserFromTicketAsync(userId, ticketId);
            return Ok(ticketReadDto);
        }
    }
}