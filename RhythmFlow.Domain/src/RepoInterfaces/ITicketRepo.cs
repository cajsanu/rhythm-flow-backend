using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface ITicketRepo : IBaseRepo<Ticket>
    {
        Task<IEnumerable<Ticket>> GetAllTicketsInProjectAsync(Guid projectId);
    }
}