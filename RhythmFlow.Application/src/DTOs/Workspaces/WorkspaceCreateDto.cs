using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Workspaces
{
    public class WorkspaceCreateDto : IBaseCreateDto<Workspace>
    {
        [Required]
        required public string Name { get; set; }
        [Required]
        [NoEmptyGuid]
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