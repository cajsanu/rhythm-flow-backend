using Microsoft.EntityFrameworkCore;
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
            var projectsInWorkspace = await _context.Projects
                .Where(p => p.WorkspaceId == workspaceId)
                .Include(p => p.Users).ToListAsync();
            return await Task.FromResult(projectsInWorkspace);
        }

        public override async Task<Project?> GetByIdAsync(Guid id)
        {
            var project = await _context.Projects
                .Include(p => p.Users)
                .FirstOrDefaultAsync(p => p.Id == id);
            return project;
        }
    }
}