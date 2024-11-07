

namespace RhythmFlow.Domain.src.Entities
{
    public class BaseEntity
    {
        // Make the ID immutable
        public Guid Id { get; init; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

    }
}