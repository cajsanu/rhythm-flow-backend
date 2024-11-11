using Moq;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.Tests.src
{
    public class BaseServiceTests
    {
        private readonly Mock<IBaseRepo<BaseEntity>> _mockRepo;
        private readonly BaseService<BaseEntity> _service;

        public BaseServiceTests()
        {
            _mockRepo = new Mock<IBaseRepo<BaseEntity>>();
            _service = new BaseService<BaseEntity>(_mockRepo.Object);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnEntities()
        {
            // Arrange
            var entities = new List<BaseEntity> { new(), new() };
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
            Assert.Equal(entity, result);
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
            Assert.Equal(entity, result);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnUpdatedEntity()
        {
            // Arrange
            var entity = new BaseEntity();
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(entity);
            _mockRepo.Setup(repo => repo.UpdateAsync(It.IsAny<BaseEntity>())).ReturnsAsync(entity);

            // Act
            var result = await _service.UpdateAsync(entity);

            // Assert
            Assert.Equal(entity, result);
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