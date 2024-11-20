using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IUserWorkspaceService
    {
        // Method to get the user's role in a workspace
        Task<Role> GetUserRoleInWorkspaceAsync(Guid userId, Guid workspaceId);
    }
}