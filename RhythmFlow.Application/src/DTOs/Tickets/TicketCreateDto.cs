using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Tickets
{
    public class TicketCreateDto : IBaseCreateDto<Ticket>, IValidatableObject
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }
        public Guid ProjectId { get; set; }
        public TicketTypeEnum Type { get; set; }
        // I haven't added the Users collection here because it's not needed for creating a ticket but it's needed when updating the ticket

        public IBaseCreateDto<Ticket> ToDto(Ticket entity)
        {
            return new TicketCreateDto()
            {
                Title = entity.Title,
                Description = entity.Description,
                Priority = entity.Priority,
                Deadline = entity.Deadline,
                Status = entity.Status,
                ProjectId = entity.ProjectId,
                Type = entity.Type

            };
        }
        public Ticket ToEntity()
        {
            return new Ticket(Title, Description, Priority, Deadline, Status, ProjectId, Type);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
             if (ProjectId == Guid.Empty)
            {
                yield return new ValidationResult("ProjectId cannot be empty.", [nameof(ProjectId)]);
            }

            if (Deadline < DateTime.Now)
            {
                yield return new ValidationResult("Deadline must be a future date.", [nameof(Deadline)]);
            }
        }
    }
}