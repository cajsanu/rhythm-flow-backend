using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceUpdateDto : IBaseUpdateDto<Workspace>
    {
        required public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public IBaseUpdateDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceUpdateDto()
            {
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }

        public Workspace ToEntity(Guid guid)
        {
            return new Workspace(Name, OwnerId, guid);
        }
    }
}