using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IProjectService : IBaseService<Project, ProjectReadDto>, IAssignmentService<Project, ProjectReadDto>
    {
    }
}