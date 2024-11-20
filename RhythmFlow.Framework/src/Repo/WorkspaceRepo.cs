using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class WorkspaceRepo(AppDbContext _context) : BaseRepo<Workspace>(_context), IWorkspaceRepo
    {
    }
}