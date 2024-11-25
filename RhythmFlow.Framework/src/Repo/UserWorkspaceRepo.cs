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
            var existingUserWorkspace = await _userWorkspaces
                .FirstOrDefaultAsync(uw => uw.UserId == userId && uw.WorkspaceId == workspaceId);

            if (existingUserWorkspace != null)
            {
                // Update the role if the record exists
                existingUserWorkspace.Role = role;
                await _context.SaveChangesAsync();
                return existingUserWorkspace;

            }
            else
            {
                // Add a new record if it doesn't exist
                var userWorkspace = new UserWorkspace(userId, workspaceId, role);
                await _userWorkspaces.AddAsync(userWorkspace);
                await _context.SaveChangesAsync();
                return userWorkspace;
            }
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

        public Task<IEnumerable<User>> GetAllUsersInWorkspaceAsync(Guid workspaceId)
        {
            var users = _context.GetUsersInWorkspace(workspaceId);
            return Task.FromResult(users);
        }

        public Task<IEnumerable<Workspace>> GetWorkspacesOwnedByUserAsync(Guid workspaceId)
        {
            var workspaces = _context.GetWorkspacesOwnedByUser(workspaceId);
            return Task.FromResult(workspaces);
        }
    }
}