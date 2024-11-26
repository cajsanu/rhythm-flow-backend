using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class TicketRepo(AppDbContext context) : BaseRepo<Ticket>(context), ITicketRepo
    {
        private readonly AppDbContext _context = context;
        private readonly DbSet<Ticket> _dbSet = context.Set<Ticket>();

        public async Task<IEnumerable<Ticket>> GetAllTicketsInProjectAsync(Guid projectId)
        {
            var ticketsInProject = await _context.Tickets
                .Where(t => t.ProjectId == projectId)
                .Include(t => t.Users).ToListAsync();
            return await Task.FromResult(ticketsInProject);
        }

        public async override Task<Ticket?> UpdateAsync(Ticket entity)
        {
            // swap entity property with foundEntity Property
            var foundEntity = await _dbSet.FindAsync(entity.Id) ?? throw new ArgumentException($"Ticket with ID {entity.Id} not found. ");
            foundEntity.Title = entity.Title;
            foundEntity.Description = entity.Description;
            foundEntity.Priority = entity.Priority;
            foundEntity.Type = entity.Type;
            foundEntity.Deadline = entity.Deadline;
            foundEntity.Status = entity.Status;
            foundEntity.Users = entity.Users;

            // then save the changes
            await _context.SaveChangesAsync();
            return await _dbSet.FindAsync(entity.Id);
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