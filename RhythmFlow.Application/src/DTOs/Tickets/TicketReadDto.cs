using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Tickets
{
    public class TicketReadDto : IBaseReadDto<Ticket>
    {
        // Addded the Id property to the TicketReadDto because the BaseController needs it
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime Deadline { get; set; }
        public Status Status { get; set; }
        public Guid ProjectId { get; set; }
        public TicketType Type { get; set; }
    }
}