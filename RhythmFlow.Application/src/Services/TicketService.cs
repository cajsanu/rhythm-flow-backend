using RhythmFlow.Application.src.DTOs.Tickets;
<<<<<<< HEAD
using RhythmFlow.Application.src.Factories;
=======
>>>>>>> main
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
<<<<<<< HEAD
    public class TicketService : BaseService<Ticket, TicketReadDto>, ITicketService
    {
        private readonly AssignmentService<Ticket, TicketReadDto> _assignmentService;

        public TicketService(
            ITicketRepo ticketRepository,
            AssignmentService<Ticket, TicketReadDto> assignmentService,
            TicketDtoFactory ticketDtoFactory)
            : base(ticketRepository, ticketDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarAnalyzer", "S927", Justification = "This is a special implementation")]
        public Task<TicketReadDto> AssignUserToEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarAnalyzer", "S927", Justification = "This is a special implementation")]
        public Task<TicketReadDto> RemoveUserFromEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
=======
    public class TicketService(ITicketRepo repository) : BaseService<Ticket, TicketReadDto>(repository), ITicketService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
>>>>>>> main
        }
    }
}