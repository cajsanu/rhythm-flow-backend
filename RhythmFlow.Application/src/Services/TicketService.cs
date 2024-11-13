using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService : ITicketService
    {
        public Task<TicketReadDto> AddAsync(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketReadDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TicketReadDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdateAsync(Guid id, Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}