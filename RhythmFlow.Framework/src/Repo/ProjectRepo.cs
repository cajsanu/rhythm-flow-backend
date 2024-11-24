using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class ProjectRepo(AppDbContext context) : BaseRepo<Project>(context), IProjectRepo
    {
        private readonly AppDbContext _context = context;

        // public override Task<IEnumerable<Project>> GetAllAsync()
        // {
        //     var projectsInWorkspace = _context.Projects.Where(p => p.WorkspaceId == workspaceId);
        //     return Task.FromResult(projectsInWorkspace);
        // }
    }
}