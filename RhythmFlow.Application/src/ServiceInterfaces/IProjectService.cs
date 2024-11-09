using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IProjectService : IBaseService<Project>, IAssignmentService<Project>
    {
    }
}