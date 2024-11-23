using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserWorkspaceRepo(AppDbContext context) : IUserWorkspaceRepo
    {
        private readonly AppDbContext _context = context;
        private readonly DbSet<UserWorkspace> _userWorkspaces = context.Set<UserWorkspace>();

        public async Task<UserWorkspace?> AssignRoleToUserInWorkspace(Guid userId, Guid workspaceId, Role role)
        {
            UserWorkspace userWorkspace = new UserWorkspace(userId, workspaceId, role);
            var added = await _userWorkspaces.AddAsync(userWorkspace);
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public Task<IEnumerable<Workspace>> GetAllUserWorkspacesByUserIdAsync(Guid userId)
        {
            var workspaces = _context.GetWorkspacesJoinedByUserId(userId);
            return Task.FromResult(workspaces);
        }

        public Task<UserWorkspace?> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId)
        {
            var userWorkspace = _context.GetUserWorkspaceByUserIdAndWorkspaceId(userId, workspaceId);
            return Task.FromResult(userWorkspace);
        }

        public Task<IEnumerable<Workspace>> GetWorkspacesOwnedByUserAsync(Guid workspaceId)
        {
            var workspaces = _context.GetWorkspacesOwnedByUser(workspaceId);
            return Task.FromResult(workspaces);
        }
    }
}