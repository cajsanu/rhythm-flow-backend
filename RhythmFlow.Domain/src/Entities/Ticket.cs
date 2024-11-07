using RhythmFlow.Domain.src.Helpers;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.Entities
{
    public class Ticket : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }
        public Guid ProjectId { get; set; }
        public TicketTypeEnum Type { get; set; }

        public Ticket(string title, string description, PriorityEnum priority, DateTime deadline, StatusEnum status, Guid projectId, TicketTypeEnum type)
        {
            if (DomainHelpers.IsNotValidStringValue(title) || DomainHelpers.IsNotValidStringValue(description)) throw new InvalidDataException("Title and description must not be null or empty");

            Title = title;
            Description = description;
            Priority = priority;
            Deadline = deadline;
            Status = status;
            ProjectId = projectId;
            Type = type;
        }

    }
}