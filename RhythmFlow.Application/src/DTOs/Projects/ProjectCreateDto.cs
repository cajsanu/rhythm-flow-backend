using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectCreateDto : IBaseCreateDto<Project>
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
       // [FutureDate]
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        [NoEmptyGuid]
        public Guid WorkspaceId { get; set; }
        [NoEmptyGuid(ValidateCollection = true)]
        public ICollection<Guid> UsersId { get; set; } = [];

        public IBaseCreateDto<Project> ToDto(Project entity)
        {
            return new ProjectCreateDto()
            {
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
                UsersId = entity.Users.Select(u => u.Id).ToList()

            };
        }
        // Exlamation mark is used to tell the compiler that the value is not null
        public Project ToEntity()
        {
            return new Project(Name!, Description!, StartDate, EndDate, Status, WorkspaceId);
        }


        // For testing purposes. the test should fail if the validation fails
       
    }
}