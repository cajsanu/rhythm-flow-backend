using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo repository) : IUserWorkspaceService
    {
        public async Task<IEnumerable<UserWorkspace>> GetUserWorkspaceByUserIdAsync(Guid userId)
        {
            var workspaces = await repository.GetUserWorkspaceByUserIdAsync(userId);
            if (workspaces == null || !workspaces.Any())
            {
                throw new InvalidOperationException($"No workspaces found for user with ID {userId}.");
            }

            return workspaces;
        }
    }
}