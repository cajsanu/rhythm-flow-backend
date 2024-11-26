using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class TicketRepo(AppDbContext context) : BaseRepo<Ticket>(context), ITicketRepo
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Ticket>> GetAllTicketsInProjectAsync(Guid projectId)
        {
            var ticketsInProject = await _context.Tickets
                .Where(t => t.ProjectId == projectId)
                .Include(t => t.Users).ToListAsync();
            return await Task.FromResult(ticketsInProject);
        }

        public override async Task<Ticket?> GetByIdAsync(Guid id)
        {
            var ticket = await _context.Tickets
                .Include(t => t.Users)
                .FirstOrDefaultAsync(t => t.Id == id);
            return ticket;
        }
    }
}