using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface ITicketRepo : IBaseRepo<Ticket>
    {
        // Add methods for assigning a ticket to a user and removing a ticket from a user
        // AssignTicketToUser()
        // RemoveTicketFromUser()
        public Task<IEnumerable<Ticket>> GetAllTicketsInProjectAsync(Guid projectId);
    }
}