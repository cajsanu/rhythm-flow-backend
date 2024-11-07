using RhythmFlow.Domain.src.Helpers;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        public Guid WorkspaceId { get; set; }

        // Make a collection of users that are assigned to the project
        public ICollection<User> Users { get; set; } = new List<User>();

        public Project(string name, string description, DateTime startDate, DateTime endDate, StatusEnum status, Guid workspaceId)
        {
            if (DomainHelpers.IsNotValidStringValue(name) || DomainHelpers.IsNotValidStringValue(description)) throw new InvalidDataException("Name and description must not be null or empty");

            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            WorkspaceId = workspaceId;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, StartDate: {StartDate}, EndDate: {EndDate}, Status: {Status}, WorkspaceId: {WorkspaceId}";
        }

    }
}