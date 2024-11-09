using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IProjectService : IBaseService<Project>
    {
        // Can we somehow extract the logic for adding/removing users
        // to/from a workspace/project/ticket to a separate service?
    }
}