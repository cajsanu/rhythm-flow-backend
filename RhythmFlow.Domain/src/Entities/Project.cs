using System.ComponentModel.DataAnnotations.Schema;
using RhythmFlow.Domain.src.Helpers;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Workspace")]
        public Guid WorkspaceId { get; set; }

        // Make a collection of users that are assigned to the project
        public ICollection<User> Users { get; set; } = [];

        public Project(string name, string description, DateOnly startDate, DateOnly endDate, Status status, Guid workspaceId) : base()
        {
            if (DomainHelpers.IsNotValidStringValue(name) || DomainHelpers.IsNotValidStringValue(description)) throw new InvalidDataException("Name and description must not be null or empty");
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            WorkspaceId = workspaceId;
        }

        public Project(string name, string description, DateOnly startDate, DateOnly endDate, Status status, Guid workspaceId, Guid Id) : base(Id)
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