using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.ValidationAttributes;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Tickets
{
    public class TicketCreateDto : IBaseCreateDto<Ticket>
    {
        [Required]
        required public string Title { get; set; }
        required public string Description { get; set; }
        public Priority Priority { get; set; }
        [FutureDate]
        public DateOnly Deadline { get; set; }
        public Status Status { get; set; }
        [NoEmptyGuid]
        public Guid ProjectId { get; set; }
        public TicketType Type { get; set; }

        [NoEmptyGuid(ValidateCollection = true)]
        public ICollection<Guid> UserIds { get; set; } = [];

        public Ticket ToEntity()
        {
            return new Ticket(Title, Description, Priority, Deadline, Status, ProjectId, Type);
        }
    }
}