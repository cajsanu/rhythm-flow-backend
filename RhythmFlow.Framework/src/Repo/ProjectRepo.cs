using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class ProjectRepo(AppDbContext context) : BaseRepo<Project>(context), IProjectRepo
    {
        private readonly AppDbContext _context = context;
        private readonly DbSet<Project> _dbSet = context.Set<Project>();

        public async Task<IEnumerable<Project>> GetAllProjectsInWorkspaceAsync(Guid workspaceId)
        {
            var projectsInWorkspace = await _context.Projects
                .Where(p => p.WorkspaceId == workspaceId)
                .Include(p => p.Users).ToListAsync();
            return await Task.FromResult(projectsInWorkspace);
        }

        public async override Task<Project?> UpdateAsync(Project entity)
        {
            // swap entity property with foundEntity Property
            var foundEntity = await _dbSet.FindAsync(entity.Id) ?? throw new ArgumentException($"Project with ID {entity.Id} not found. ");
            foundEntity.Name = entity.Name;
            foundEntity.Description = entity.Description;
            foundEntity.StartDate = entity.StartDate;
            foundEntity.EndDate = entity.EndDate;
            foundEntity.Status = entity.Status;
            foundEntity.Users = entity.Users;

            // then save the changes
            await _context.SaveChangesAsync();
            return await _dbSet.FindAsync(entity.Id);
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