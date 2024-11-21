using Moq;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    public class ProjectServiceTests
    {
        private readonly Mock<IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>> _mockDtoFactory;
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _serviceAssignment;
        private readonly Mock<IProjectRepo> _mockProjectRepo;
        private readonly ProjectService _service;

        public ProjectServiceTests()
        {
            _mockDtoFactory = new Mock<IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>>();
            _mockProjectRepo = new Mock<IProjectRepo>();
            _mockUserRepo = new Mock<IUserRepo>();
            _serviceAssignment = new AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(
                _mockUserRepo.Object,
                _mockProjectRepo.Object,
                _mockDtoFactory.Object

            );
            _service = new ProjectService(_mockProjectRepo.Object, _serviceAssignment, new ProjectDtoFactory());
        }

        [Fact]
        public async Task AssignUserToEntityAsync_ShouldAssignUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var project = new TestProject("Skyio", "Bla Bla", new DateTime(2026, 12, 12), new DateTime(2026, 12, 12), Status.InProgress, Guid.NewGuid()) { Id = projectId };
            var dto = new TestProjectReadDto { Id = project.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(project)).Returns(dto);
            // Act
            var result = await _service.AssignUserToEntityAsync(userId, projectId);

            // Assert
            Assert.Equal(projectId, result.Id);
            Assert.Contains(user, project.Users);
        }

        [Fact]
        public async Task RemoveUserFromEntityAsync_ShouldRemoveUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var project = new TestProject("Skyio", "Bla Bla", new DateTime(2026, 12, 12), new DateTime(2026, 12, 12), Status.InProgress, Guid.NewGuid()) { Id = projectId, Users = new List<User>() { user } };
            var dto = new TestProjectReadDto { Id = project.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(project)).Returns(dto);

            // Act
            var result = await _service.RemoveUserFromEntityAsync(userId, projectId);

            // Assert
            Assert.Equal(project.Id, result.Id);
            Assert.DoesNotContain(user, project.Users);


        }
    }
}
