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
        public Status Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public Guid ManagerId { get; set; }

        // Make a collection of users that are assigned to the project
        public ICollection<User> Users { get; set; } = [];

        public Project(string name, string description, DateTime startDate, DateTime endDate, Status status, Guid workspaceId, Guid managerId)
        {
            if (DomainHelpers.IsNotValidStringValue(name) || DomainHelpers.IsNotValidStringValue(description)) throw new InvalidDataException("Name and description must not be null or empty");

            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            WorkspaceId = workspaceId;
            ManagerId = managerId;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, StartDate: {StartDate}, EndDate: {EndDate}, Status: {Status}, WorkspaceId: {WorkspaceId}";
        }
    }
}