namespace RhythmFlow.Domain.src.Entities
{
    public class BaseEntity
    {
        // Make the Id immutable
        public Guid Id { get; init; }

        public BaseEntity(Guid? guid = null)
        {
            if (guid != null)
            {
                Id = (Guid)guid;
            }
            else
            {
                Id = Guid.NewGuid();
            }
        }
    }
}