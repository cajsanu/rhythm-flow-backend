using System.ComponentModel.DataAnnotations.Schema;
using RhythmFlow.Domain.src.Helpers;

namespace RhythmFlow.Domain.src.Entities
{
    public class Workspace : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("User")]
        public Guid OwnerId { get; set; }

        public Workspace(string name, Guid ownerId) : base()
        {
            if (DomainHelpers.IsNotValidStringValue(name)) throw new InvalidDataException("Name and description must not be null or empty");

            Name = name;
            OwnerId = ownerId;
        }

        public Workspace(string name, Guid ownerId, Guid Id) : base(Id)
        {
            if (DomainHelpers.IsNotValidStringValue(name)) throw new InvalidDataException("Name and description must not be null or empty");

            Name = name;
            OwnerId = ownerId;
        }

        public override string ToString()
        {
            return $"Name: {Name}, OwnerId: {OwnerId}";
        }
    }
}