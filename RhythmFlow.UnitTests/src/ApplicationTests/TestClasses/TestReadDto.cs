using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestReadDto : IBaseReadDto<TestEntity>
    {
        public Guid Id { get; set; }
        public IBaseReadDto<TestEntity> ToDto(TestEntity entity)
        {
            return new TestReadDto { Id = entity.Id };
        }
    }
}