using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceReadDto : BaseReadDto<Workspace>
    {
        public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public BaseReadDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceReadDto()
            {
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }

    }
}