using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class WorkspaceDtoFactory : IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>
    {
        public WorkspaceCreateDto CreateCreateDto(Workspace entity)
        {
            return new WorkspaceCreateDto
            {
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }

        public WorkspaceReadDto CreateReadDto(Workspace entity)
        {
            return new WorkspaceReadDto
            {
                Id = entity.Id,
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }

        public WorkspaceUpdateDto CreateUpdateDto(Workspace entity)
        {
            return new WorkspaceUpdateDto
            {
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }
    }
}