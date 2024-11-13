using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService(ITicketRepo repository) : BaseService<Ticket, TicketReadDto>(repository), ITicketService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}