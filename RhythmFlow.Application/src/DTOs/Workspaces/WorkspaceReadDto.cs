using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceReadDto : IBaseReadDto<Workspace>
    {
        required public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public IBaseReadDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceReadDto()
            {
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }
    }
}