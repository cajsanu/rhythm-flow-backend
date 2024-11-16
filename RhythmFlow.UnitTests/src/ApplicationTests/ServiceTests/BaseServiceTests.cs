using Moq;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    // Minimal concrete implementation for testing purposes
    public class TestBaseReadDto : IBaseReadDto<BaseEntity>
    {
        public Guid Id { get; set; }
        public IBaseReadDto<BaseEntity> ToDto(BaseEntity entity)
        {
            return new TestBaseReadDto { Id = entity.Id };
        }
    }

    public class BaseServiceTests
    {
        private readonly Mock<IBaseRepo<BaseEntity>> _mockRepo;
        private readonly Mock<IDtoFactory<BaseEntity, TestBaseReadDto>> _mockFactory;
        private readonly IBaseService<BaseEntity, TestBaseReadDto> _service;

        public BaseServiceTests()
        {
            _mockRepo = new Mock<IBaseRepo<BaseEntity>>();
            _mockFactory = new Mock<IDtoFactory<BaseEntity, TestBaseReadDto>>();

            // Setup factory to convert BaseEntity to TestBaseReadDto
            _mockFactory.Setup(factory => factory.CreateDto(It.IsAny<BaseEntity>()))
                .Returns((BaseEntity entity) => new TestBaseReadDto { Id = entity.Id });

            _service = new BaseService<BaseEntity, TestBaseReadDto>(_mockRepo.Object, _mockFactory.Object);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnEntities()
        {
            // Arrange
            var entities = new List<BaseEntity> { new (), new () };
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
            var entity = new BaseEntity();
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);

            // Act
            var result = await _service.GetByIdAsync(entity.Id);

            // Assert
            Assert.Equal(entity.Id, result.Id);
        }

        [Fact]
        public async Task AddAsync_ShouldReturnNewEntity()
        {
            // Arrange
            var entity = new BaseEntity();
            _mockRepo.Setup(repo => repo.AddAsync(It.IsAny<BaseEntity>())).ReturnsAsync(entity);

            // Act
            var result = await _service.AddAsync(entity);

            // Assert
            Assert.Equal(entity.Id, result.Id);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnUpdatedEntity()
        {
            // Arrange
            var entity = new BaseEntity { Id = Guid.NewGuid() };
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            _mockRepo.Setup(repo => repo.UpdateAsync(It.IsAny<BaseEntity>())).ReturnsAsync(entity);

            // Act
            var result = await _service.UpdateAsync(entity.Id, entity);

            // Assert
            Assert.Equal(entity.Id, result.Id);
        }

        [Fact]
        public async Task DeleteAsync_ShouldCallDeleteOnRepo()
        {
            // Arrange
            var entity = new BaseEntity();
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            _mockRepo.Setup(repo => repo.DeleteAsync(It.IsAny<Guid>())).Returns(Task.CompletedTask);

            // Act
            await _service.DeleteAsync(entity.Id);

            // Assert
            _mockRepo.Verify(repo => repo.DeleteAsync(entity.Id), Times.Once);
        }
    }
}