using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class UserWorkspaceService(IUserWorkspaceRepo repository) : IUserWorkspaceService
    {
        public Task<IEnumerable<UserWorkspace>> GetUserWorkspaceByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}