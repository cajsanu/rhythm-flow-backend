using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceCreateDto : IBaseCreateDto<Workspace>
    {
        public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public IBaseCreateDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceCreateDto()
            {
                Name = entity.Name,
            };
        }

        public Workspace ToEntity()
        {
            return new Workspace(Name, OwnerId);
        }
    }
}