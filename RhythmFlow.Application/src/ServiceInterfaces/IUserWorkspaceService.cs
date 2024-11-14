using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IUserWorkspaceService
    {
        // Method to get all user workspaces by user id
        Task<IEnumerable<UserWorkspace>> GetUserWorkspaceByUserIdAsync(Guid userId);
    }
}