using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IUserWorkspaceRepo
    {
        Task<IEnumerable<UserWorkspace>> GetUserWorkspaceByUserIdAsync(Guid userId);
    }
}