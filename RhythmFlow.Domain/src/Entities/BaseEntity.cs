

namespace RhythmFlow.Domain.src.Entities
{
    public class BaseEntity
    {
        // Make the Id immutable
        public Guid Id { get; init; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

    }
}