using Moq;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests.ServiceTests
{
    public class BaseServiceTests
    {
        private readonly Mock<IBaseRepo<TestEntity>> _mockRepo;
        private readonly Mock<IDtoFactory<TestEntity, TestReadDto, TestCreateDto, TestUpdateDto>> _mockFactory;
        private readonly IBaseService<TestEntity, TestReadDto, TestCreateDto, TestUpdateDto> _service;

        public BaseServiceTests()
        {
            _mockRepo = new Mock<IBaseRepo<TestEntity>>();
            _mockFactory = new Mock<IDtoFactory<TestEntity, TestReadDto, TestCreateDto, TestUpdateDto>>();

            // Setup factory to convert TestEntity to TestReadDto
            _mockFactory.Setup(factory => factory.CreateReadDto(It.IsAny<TestEntity>()))
                .Returns((TestEntity entity) => new TestReadDto { Id = entity.Id });

            _service = new BaseService<TestEntity, TestReadDto, TestCreateDto, TestUpdateDto>(_mockRepo.Object, _mockFactory.Object);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnEntities()
        {
            // Arrange
            var entities = new List<TestEntity> { new (), new () };
            _mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(entities);

            // Act
            var result = await _service.GetAllAsync();

            // Assert
            Assert.Equal(entities.Count, result.Count());
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnEntity()
        {
            // Arrange
            var entity = new TestEntity();
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);

            // Act
            var result = await _service.GetByIdAsync(entity.Id);

            // Assert
            Assert.Equal(entity.Id, result?.Id);
        }

        [Fact]
        public async Task AddAsync_ShouldReturnNewEntity()
        {
            // Arrange
            var entity = new TestEntity();
            _mockRepo.Setup(repo => repo.AddAsync(It.IsAny<TestEntity>())).ReturnsAsync(entity);

            // Act
            var result = await _service.AddAsync(new TestCreateDto());

            // Assert
            Assert.Equal(entity.Id, result.Id);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnUpdatedEntity()
        {
            // Arrange
            var entity = new TestEntity { Id = Guid.NewGuid() };
            var entityDto = new TestUpdateDto { Id = entity.Id };
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            _mockRepo.Setup(repo => repo.UpdateAsync(It.IsAny<TestEntity>())).ReturnsAsync(entity);

            // Act
            var result = await _service.UpdateAsync(entity.Id, entityDto);

            // Assert
            Assert.Equal(entity.Id, result?.Id);
        }

        [Fact]
        public async Task DeleteAsync_ShouldCallDeleteOnRepo()
        {
            // Arrange
            var entity = new TestEntity();
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            _mockRepo.Setup(repo => repo.DeleteAsync(It.IsAny<Guid>())).Returns(Task.CompletedTask);

            // Act
            await _service.DeleteAsync(entity.Id);

            // Assert
            _mockRepo.Verify(repo => repo.DeleteAsync(entity.Id), Times.Once);
        }
    }
}