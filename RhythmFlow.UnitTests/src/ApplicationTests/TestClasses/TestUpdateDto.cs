using RhythmFlow.Application.src.DTOs.Shared;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestUpdateDto : IBaseUpdateDto<TestEntity>
    {
        public Guid Id { get; set; }

        public static IBaseUpdateDto<TestEntity> ToDto(TestEntity entity)
        {
            throw new NotImplementedException();
        }

        public TestEntity ToEntity(Guid guid)
        {
            return new TestEntity { Id = guid };
        }
    }
}