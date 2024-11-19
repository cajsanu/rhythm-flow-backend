using RhythmFlow.Application.src.DTOs.Shared;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestCreateReadDto : IBaseCreateReadDto<TestEntity>
    {
        public Guid Id { get; set; }
        public IBaseCreateReadDto<TestEntity> ToDto(TestEntity entity)
        {
            return new TestCreateReadDto { Id = entity.Id };
        }

        public TestEntity ToEntity()
        {
            return new TestEntity { Id = Id };
        }

        
    }
}