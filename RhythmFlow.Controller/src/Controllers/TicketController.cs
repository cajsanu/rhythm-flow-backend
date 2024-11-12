using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    public class TicketController(ITicketService service) : BaseController<Ticket, TicketReadDto>(service)
    {
        // Get Project by id should include all Tickets in the Project
        // so no need to have a separate method for this.
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