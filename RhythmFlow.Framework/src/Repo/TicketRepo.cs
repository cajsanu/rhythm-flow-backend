using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class TicketRepo(AppDbContext context) : BaseRepo<Ticket>(context), ITicketRepo
    {
        private readonly AppDbContext _context = context;

        public Task<IEnumerable<Ticket>> GetAllTicketsInProjectAsync(Guid projectId)
        {
            var ticketsInProject = _context.Tickets.Where(t => t.ProjectId == projectId);
            return Task.FromResult(ticketsInProject);
        }
    }
}