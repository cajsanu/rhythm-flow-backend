using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserWorkspaceRepo(AppDbContext context) : IUserWorkspaceRepo
    {
        private readonly AppDbContext _context = context;
        public Task<UserWorkspace?> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = _context.GetUserWorkspaceByUserIdAndWorkspaceId(userId, workspaceId);
            return Task.FromResult(userWorkspace);
        }
    }
}