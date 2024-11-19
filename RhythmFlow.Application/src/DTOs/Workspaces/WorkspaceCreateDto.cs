using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceCreateReadDto : IBaseCreateReadDto<Workspace>
    {
        [Required]
        required public string Name { get; set; }
        [Required]
        [NoEmptyGuid]
        public Guid OwnerId { get; set; }

        public IBaseCreateReadDto<Workspace> ToDto(Workspace entity)
        {
            return new WorkspaceCreateReadDto()
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