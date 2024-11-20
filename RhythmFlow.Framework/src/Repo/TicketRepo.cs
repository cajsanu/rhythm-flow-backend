using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class TicketRepo(AppDbContext _context) : BaseRepo<Ticket>(_context), ITicketRepo
    {
    }
}