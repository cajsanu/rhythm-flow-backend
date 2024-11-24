using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IProjectRepo : IBaseRepo<Project>
    {
        public Task<IEnumerable<Project>> GetAllProjectsInWorkspaceAsync(Guid workspaceId);
    }
}