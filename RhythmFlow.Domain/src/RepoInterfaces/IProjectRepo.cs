using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IProjectRepo : IBaseRepo<Project>
    {
        Task<IEnumerable<Project>> GetAllProjectsInWorkspaceAsync(Guid workspaceId);
    }
}