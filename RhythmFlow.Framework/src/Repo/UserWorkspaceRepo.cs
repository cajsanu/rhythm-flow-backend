using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserWorkspaceRepo : IUserWorkspaceRepo
    {
        public Task<UserWorkspace?> GetUserWorkspaceByUserIdAndWorkspaceIdAsync(Guid userId, Guid workspaceId)
        {
            throw new NotImplementedException();
        }
    }
}