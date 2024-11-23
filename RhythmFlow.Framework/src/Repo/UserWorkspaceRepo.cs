using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserWorkspaceRepo(AppDbContext context) : IUserWorkspaceRepo
    {
        private readonly AppDbContext _context = context;

        public Task<UserWorkspace?> AssignRoleToUserInWorkspace(Guid userId, Guid workspaceId, Role role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workspace>> GetAllUserWorkspacesByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserWorkspace?> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = _context.GetUserWorkspaceByUserIdAndWorkspaceId(userId, workspaceId);
            return Task.FromResult(userWorkspace);
        }

        public Task<IEnumerable<Workspace>> GetWorkspacesOwnedByUserAsync(Guid workspaceId)
        {
            throw new NotImplementedException();
        }
    }
}