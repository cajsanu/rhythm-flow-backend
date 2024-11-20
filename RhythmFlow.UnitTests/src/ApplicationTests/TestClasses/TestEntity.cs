using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestEntity : BaseEntity
    {
        public List<BaseEntity> Users { get; set; } = new List<BaseEntity>();
    }
}