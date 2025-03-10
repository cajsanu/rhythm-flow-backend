using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface ITicketService : IBaseService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>
    {
        Task<IEnumerable<TicketReadDto>> GetAllTicketsInProjectAsync(Guid projectId);
        Task<IEnumerable<UserReadDto>> GetAllUsersInTicketAsync(Guid ticketId);
        Task<TicketReadDto> AssignUserToTicketAsync(Guid userId, Guid ticketId);
        Task<TicketReadDto> RemoveUserFromTicketAsync(Guid userId, Guid ticketId);
    }
}