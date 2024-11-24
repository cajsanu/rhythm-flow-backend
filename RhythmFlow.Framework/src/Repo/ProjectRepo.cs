using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class ProjectRepo(AppDbContext context) : BaseRepo<Project>(context), IProjectRepo
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Project>> GetAllProjectsInWorkspaceAsync(Guid workspaceId)
        {
            var projectsInWorkspace = _context.Projects.Where(p => p.WorkspaceId == workspaceId);
            return await Task.FromResult(projectsInWorkspace);
        }
    }
}