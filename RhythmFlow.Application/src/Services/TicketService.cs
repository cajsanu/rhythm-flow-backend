using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService : BaseService<Ticket, TicketReadDto>, ITicketService
    {
        // T
        private readonly AssignmentService<Ticket, TicketReadDto> _assignmentService;

        public TicketService(
            ITicketRepo ticketRepository,
            AssignmentService<Ticket, TicketReadDto> assignmentService,
            TicketDtoFactory ticketDtoFactory)
            : base(ticketRepository, ticketDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        public Task<TicketReadDto> AssignUserToEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        public Task<TicketReadDto> RemoveUserFromEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
        }
    }
}