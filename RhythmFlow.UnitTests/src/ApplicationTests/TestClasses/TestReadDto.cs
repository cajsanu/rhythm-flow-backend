using RhythmFlow.Application.src.DTOs.Shared;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestReadDto : IBaseReadDto<TestEntity>
    {
        public Guid Id { get; set; }
        public static IBaseReadDto<TestEntity> ToDto(TestEntity entity)
        {
            return new TestReadDto { Id = entity.Id };
        }
    }
}