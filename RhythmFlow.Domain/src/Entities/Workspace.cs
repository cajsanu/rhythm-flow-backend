using RhythmFlow.Domain.src.Helpers;

namespace RhythmFlow.Domain.src.Entities
{
    public class Workspace : BaseEntity
    {
        public string Name { get; set; }
        public Guid OwnerId { get; set; }

        public ICollection<User> Users { get; set; } = [];

        public Workspace(string name, Guid ownerId)
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