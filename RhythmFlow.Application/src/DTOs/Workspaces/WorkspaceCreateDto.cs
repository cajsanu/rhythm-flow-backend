using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.DTOs.Workspaces
{
    public class WorkspaceCreateDto : IBaseCreateDto<Workspace>
    {
        [Required]
        public string? Name { get; set; }
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

        // Exlamation mark to tell the compiler that the value is not null
        public Workspace ToEntity()
        {
            return new Workspace(Name!, OwnerId);
        }

    }
}