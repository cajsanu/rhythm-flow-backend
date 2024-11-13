using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceReadDto : IBaseReadDto<Workspace>
    {
        // Addded the Id property to the UserReadDto because the BaseController needs it
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid OwnerId { get; set; }

        public IBaseReadDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceReadDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                OwnerId = entity.OwnerId
            };
        }
    }
}