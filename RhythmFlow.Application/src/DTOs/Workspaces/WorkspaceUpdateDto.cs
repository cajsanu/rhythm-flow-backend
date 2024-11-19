using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceUpdateDto : IBaseUpdateDto<Workspace>
    {
        required public Guid Id { get; init; }
        required public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public IBaseUpdateDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceUpdateDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }

        public Workspace ToEntity()
        {
            return new Workspace(Name, OwnerId, Id);
        }
    }
}