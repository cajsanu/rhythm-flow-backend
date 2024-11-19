

using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

public interface IProjectDtoFactoryBase : IDtoFactory<Project, ProjectReadDto, ProjectCreateReadDto,ProjectUpdateDto>
{
}
