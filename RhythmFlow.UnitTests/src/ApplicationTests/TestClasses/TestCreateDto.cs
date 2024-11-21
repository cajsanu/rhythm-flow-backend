using RhythmFlow.Application.src.DTOs.Shared;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestCreateDto : IBaseCreateDto<TestEntity>
    {
        public Guid Id { get; set; }
        public IBaseCreateDto<TestEntity> ToDto(TestEntity entity)
        {
            return new TestCreateDto { Id = entity.Id };
        }

        public TestEntity ToEntity()
        {
            return new TestEntity { Id = Id };
        }
    }
}