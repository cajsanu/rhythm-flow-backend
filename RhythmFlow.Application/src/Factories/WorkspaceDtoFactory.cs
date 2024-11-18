using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class WorkspaceDtoFactory : IDtoFactory<Workspace, WorkspaceReadDto>
    {
        public WorkspaceReadDto CreateDto(Workspace entity)
        {
            return new WorkspaceReadDto
            {
                Id = entity.Id,
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }
    }
}