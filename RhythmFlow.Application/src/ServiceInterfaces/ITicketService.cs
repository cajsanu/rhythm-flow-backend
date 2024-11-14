using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface ITicketService : IBaseService<Ticket, TicketReadDto>
    {
    }
}