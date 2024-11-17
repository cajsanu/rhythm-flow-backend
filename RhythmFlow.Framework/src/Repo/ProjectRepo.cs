using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class ProjectRepo(AppDbContext _context) : BaseRepo<Project>(_context), IProjectRepo
    {
    }
}