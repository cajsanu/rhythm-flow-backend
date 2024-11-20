using Moq;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.Tests.src.ServiceTests
{
    public class AssignmentServiceTest
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IBaseRepo<Project>> _mockProjectRepo;
        private readonly AssignmentService<Project, ProjectReadDto> _assignmentService;

        public AssignmentServiceTest()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            _mockProjectRepo = new Mock<IBaseRepo<Project>>();
            _assignmentService = new AssignmentService<Project, ProjectReadDto>(_mockUserRepo.Object, _mockProjectRepo.Object);
        }

        [Fact]
        public async Task AssignUserToEntityAsync_ShouldAssignUserToProject()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new User("FirstName", "LastName", "Email@email.com", "Password") { Id = userId };
            var project = new Project("Test Project", "Description", DateTime.Now, DateTime.Now.AddDays(1), Status.InProgress, Guid.NewGuid())
            {
                Id = projectId,
                Users = []
            };

            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockProjectRepo.Setup(repo => repo.UpdateAsync(It.IsAny<Project>())).ReturnsAsync(project);

            // Act
            var result = await _assignmentService.AssignUserToEntityAsync(userId, projectId);

            // Assert
            Assert.Contains(user, project.Users);
            Assert.Equal(projectId, result.Id);
        }

        [Fact]
        public async Task RemoveUserFromEntityAsync_ShouldRemoveUserFromProject()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new User("FirstName", "LastName", "Email@email.com", "Password") { Id = userId };
            var project = new Project("Test Project", "Description", DateTime.Now, DateTime.Now.AddDays(1), Status.InProgress, Guid.NewGuid())
            {
                Id = projectId,
                Users = [user]
            };

            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockProjectRepo.Setup(repo => repo.UpdateAsync(It.IsAny<Project>())).ReturnsAsync(project);

            // Act
            var result = await _assignmentService.RemoveUserFromEntityAsync(userId, projectId);

            // Assert
            Assert.DoesNotContain(user, project.Users);
            Assert.Equal(projectId, result.Id);
        }

        [Fact]
        public async Task AssignUserToEntityAsync_ShouldThrowException_WhenUserNotFound()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var project = new Project("Test Project", "Description", DateTime.Now, DateTime.Now.AddDays(1), Status.InProgress, Guid.NewGuid())
            {
                Id = projectId,
            };

            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync((User?)null);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _assignmentService.AssignUserToEntityAsync(userId, projectId));
        }

        [Fact]
        public async Task RemoveUserFromEntityAsync_ShouldThrowException_WhenEntityNotFound()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new User("FirstName", "LastName", "Email@email.com", "Password") { Id = userId };

            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync((Project?)null);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _assignmentService.RemoveUserFromEntityAsync(userId, projectId));
        }
    }

    public class ProjectReadDto : IBaseReadDto<Project>
    {
        public Guid Id { get; set; }
        public static IBaseReadDto<Project> ToDto(Project entity)
        {
            return new ProjectReadDto { Id = entity.Id };
        }
    }
}