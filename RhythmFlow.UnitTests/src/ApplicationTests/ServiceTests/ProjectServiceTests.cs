using Moq;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
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
        private readonly Mock<IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>> _mockProjectDtoFactory;
        private readonly Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>> _mockUserDtoFactory;
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _serviceAssignment;
        private readonly Mock<IProjectRepo> _mockProjectRepo;
        private readonly ProjectService _service;

        public ProjectServiceTests()
        {
            _mockProjectDtoFactory = new Mock<IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>>();
            _mockUserDtoFactory = new Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>>();
            _mockProjectRepo = new Mock<IProjectRepo>();
            _mockUserRepo = new Mock<IUserRepo>();
            _serviceAssignment = new AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(
                _mockUserRepo.Object,
                _mockProjectRepo.Object,
                _mockProjectDtoFactory.Object

            );
            _service = new ProjectService(_mockProjectRepo.Object, _mockUserRepo.Object, _serviceAssignment, _mockProjectDtoFactory.Object, _mockUserDtoFactory.Object);
        }

        [Fact]
        public async Task AssignUserToEntityAsync_ShouldAssignUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var project = new TestProject("Skyio", "Bla Bla", DateOnly.FromDateTime(new DateTime(2026, 12, 12)), DateOnly.FromDateTime(new DateTime(2026, 12, 12)), Status.InProgress, Guid.NewGuid()) { Id = projectId };
            var dto = new TestProjectReadDto { Id = project.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockProjectDtoFactory.Setup(factory => factory.CreateReadDto(project)).Returns(dto);

            // Act
            var result = await _service.AssignUserToProjectAsync(userId, projectId);

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
            var project = new TestProject("Skyio", "Bla Bla", DateOnly.FromDateTime(new DateTime(2026, 12, 12)), DateOnly.FromDateTime(new DateTime(2026, 12, 12)), Status.InProgress, Guid.NewGuid()) { Id = projectId, Users = new List<User>() { user } };
            var dto = new TestProjectReadDto { Id = project.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockProjectDtoFactory.Setup(factory => factory.CreateReadDto(project)).Returns(dto);

            // Act
            var result = await _service.RemoveUserFromProjectAsync(userId, projectId);

            // Assert
            Assert.Equal(project.Id, result.Id);
            Assert.DoesNotContain(user, project.Users);
        }

        [Fact]
        public async Task AddAsync_ShouldAddProject_WhenValidInput()
        {
            // Arrange
            var projectCreateDto = new TestProjectCreateDto
            {
                Name = "New Project",
                Description = "Project Description",
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
                Status = Status.InProgress,
                UserIds = [Guid.NewGuid()]
            };
            var newProject = new TestProject(projectCreateDto.Name, projectCreateDto.Description, projectCreateDto.StartDate, projectCreateDto.EndDate, projectCreateDto.Status, Guid.NewGuid());
            var dto = new TestProjectReadDto { Id = newProject.Id };

            _mockUserRepo.Setup(repo => repo.GetByIdsAsync(projectCreateDto.UserIds)).ReturnsAsync([new ("Test", "User", "test@example.com", "hashedPassword")]);
            _mockProjectRepo.Setup(repo => repo.AddAsync(It.IsAny<Project>())).ReturnsAsync(newProject);
            _mockProjectDtoFactory.Setup(factory => factory.CreateReadDto(newProject)).Returns(dto);

            // Act
            var result = await _service.AddAsync(projectCreateDto);

            // Assert
            Assert.Equal(newProject.Id, result.Id);
        }

        [Fact]
        public async Task GetAllProjectsInWorkspaceAsync_ShouldReturnProjects_WhenProjectsExist()
        {
            // Arrange
            var workspaceId = Guid.NewGuid();
            var projects = new List<Project>
            {
                new TestProject("Project 1", "Description 1", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, workspaceId),
                new TestProject("Project 2", "Description 2", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, workspaceId)
            };
            var dtos = projects.Select(p => new TestProjectReadDto { Id = p.Id }).ToList();

            _mockProjectRepo.Setup(repo => repo.GetAllProjectsInWorkspaceAsync(workspaceId)).ReturnsAsync(projects);
            _mockProjectDtoFactory.Setup(factory => factory.CreateReadDto(It.IsAny<Project>())).Returns((Project p) => new TestProjectReadDto { Id = p.Id });

            // Act
            var result = await _service.GetAllProjectsInWorkspaceAsync(workspaceId);

            // Assert
            Assert.Equal(dtos.Count, result.Count());
        }

        [Fact]
        public async Task GetAllUsersInProjectAsync_ShouldReturnUsers_WhenUsersExist()
        {
            // Arrange
            var projectId = Guid.NewGuid();
            var users = new List<User>
            {
                new ("Test", "User1", "user1@example.com", "hashedPassword") { Id = Guid.NewGuid() },
                new ("Test", "User2", "user2@example.com", "hashedPassword") { Id = Guid.NewGuid() }
            };
            var project = new TestProject("Project", "Description", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, Guid.NewGuid()) { Id = projectId, Users = users };
            var dtos = users.Select(u => new TestUserReadDto { Id = u.Id }).ToList();

            _mockProjectRepo.Setup(repo => repo.GetByIdAsync(projectId)).ReturnsAsync(project);
            _mockUserDtoFactory.Setup(factory => factory.CreateReadDto(It.IsAny<User>())).Returns((User u) => new TestUserReadDto { Id = u.Id });

            // Act
            var result = await _service.GetAllUsersInProjectAsync(projectId);

            // Assert
            Assert.Equal(dtos.Count, result.Count());
        }
    }
}
