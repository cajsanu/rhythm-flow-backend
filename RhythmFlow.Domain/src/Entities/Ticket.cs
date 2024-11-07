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

        // Make a collection of users that are assigned to the ticket
        public ICollection<User> Users { get; set; } = new List<User>();

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

        public override string ToString()
        {
            return $"Title: {Title}, Description: {Description}, Priority: {Priority}, Deadline: {Deadline}, Status: {Status}, ProjectId: {ProjectId}, Type: {Type}";

        }
    }
}