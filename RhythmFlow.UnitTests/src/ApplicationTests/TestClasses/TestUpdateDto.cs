using RhythmFlow.Application.src.DTOs.Shared;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestUpdateDto : IBaseUpdateDto<TestEntity>
    {
        public Guid Id { get; set; }
        
        public static IBaseUpdateDto<TestEntity> ToDto(TestEntity entity)
        {
            return new TestUpdateDto { Id = entity.Id };
        }

        public TestEntity ToEntity()
        {
            return new TestEntity { Id = Id };
        }

        
    }
}