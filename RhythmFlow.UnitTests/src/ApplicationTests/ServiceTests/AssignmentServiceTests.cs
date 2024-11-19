using Moq;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    public class AssignmentServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IBaseRepo<TestEntity>> _mockEntityRepo;
        private readonly Mock<IDtoFactory<TestEntity, TestReadDto, TestCreateReadDto, TestUpdateDto>> _mockDtoFactory;
        private readonly AssignmentService<TestEntity, TestReadDto, TestCreateReadDto, TestUpdateDto> _service;

        public AssignmentServiceTests()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            _mockEntityRepo = new Mock<IBaseRepo<TestEntity>>();
            _mockDtoFactory = new Mock<IDtoFactory<TestEntity, TestReadDto, TestCreateReadDto, TestUpdateDto>>();

            _service = new AssignmentService<TestEntity, TestReadDto, TestCreateReadDto, TestUpdateDto>(
                _mockUserRepo.Object,
                _mockEntityRepo.Object,
                _mockDtoFactory.Object
            );
        }

        [Fact]
        public async Task AssignUserToEntity_ShouldAssignUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var entityId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var entity = new TestEntity { Id = entityId, Users = new List<BaseEntity>() };
            var dto = new TestReadDto { Id = entity.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockEntityRepo.Setup(repo => repo.GetByIdAsync(entityId)).ReturnsAsync(entity);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(entity)).Returns(dto);

            // Act
            var result = await _service.AssignUserToEntityAsync(userId, entityId);

            // Assert
            Assert.Equal(entityId, result.Id);
            Assert.Contains(user, entity.Users);
        }

        [Fact]
        public async Task RemoveUserFromEntity_ShouldRemoveUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var entityId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var entity = new TestEntity { Id = entityId, Users = new List<BaseEntity> { user } };
            var dto = new TestReadDto { Id = entity.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockEntityRepo.Setup(repo => repo.GetByIdAsync(entityId)).ReturnsAsync(entity);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(entity)).Returns(dto);

            // Act
            var result = await _service.RemoveUserFromEntityAsync(userId, entityId);

            // Assert
            Assert.Equal(entity.Id, result.Id);
            Assert.DoesNotContain(user, entity.Users);
        }
    }
}