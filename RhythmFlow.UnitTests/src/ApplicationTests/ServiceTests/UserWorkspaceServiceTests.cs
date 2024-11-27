using Moq;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.ServiceTests
{
    public class UserWorkspaceServiceTests
    {
        private readonly Mock<IUserWorkspaceRepo> _mockUserWorkspaceRepo;
        private readonly Mock<IUserWorkspaceDtoFactory> _mockUserWorkspaceDtoFactory;
        private readonly UserWorkspaceService _service;

        public UserWorkspaceServiceTests()
        {
            _mockUserWorkspaceRepo = new Mock<IUserWorkspaceRepo>();
            _mockUserWorkspaceDtoFactory = new Mock<IUserWorkspaceDtoFactory>();
            _service = new UserWorkspaceService(_mockUserWorkspaceRepo.Object, _mockUserWorkspaceDtoFactory.Object);
        }

        [Fact]
        public async Task AssignUserRoleInWorkspaceAsync_ShouldAssignRole_WhenValidInput()
        {
            // Arrange
            var userWorkspaceCreateDto = new UserWorkspaceCreateDto
            {
                UserId = Guid.NewGuid(),
                WorkspaceId = Guid.NewGuid(),
                Role = Role.ProjectManager
            };
            var userWorkspace = new UserWorkspace(userWorkspaceCreateDto.UserId, userWorkspaceCreateDto.WorkspaceId, userWorkspaceCreateDto.Role);
            var userWorkspaceReadDto = new UserWorkspaceReadDto
            {
                UserId = userWorkspace.UserId,
                WorkspaceId = userWorkspace.WorkspaceId,
                Role = userWorkspace.Role
            };

            _mockUserWorkspaceRepo.Setup(repo => repo.AssignRoleToUserInWorkspaceAsync(userWorkspaceCreateDto.UserId, userWorkspaceCreateDto.WorkspaceId, userWorkspaceCreateDto.Role))
                .ReturnsAsync(userWorkspace);
            _mockUserWorkspaceDtoFactory.Setup(factory => factory.CreateReadDto(userWorkspace)).Returns(userWorkspaceReadDto);

            // Act
            var result = await _service.AssignUserRoleInWorkspaceAsync(userWorkspaceCreateDto);

            // Assert
            Assert.Equal(userWorkspaceReadDto.UserId, result.UserId);
            Assert.Equal(userWorkspaceReadDto.WorkspaceId, result.WorkspaceId);
            Assert.Equal(userWorkspaceReadDto.Role, result.Role);
        }

        [Fact]
        public async Task AssignUserRoleInWorkspaceAsync_ShouldThrowException_WhenUserNotInWorkspace()
        {
            // Arrange
            var userWorkspaceCreateDto = new UserWorkspaceCreateDto
            {
                UserId = Guid.NewGuid(),
                WorkspaceId = Guid.NewGuid(),
                Role = Role.Developer
            };

            _mockUserWorkspaceRepo.Setup(repo => repo.AssignRoleToUserInWorkspaceAsync(userWorkspaceCreateDto.UserId, userWorkspaceCreateDto.WorkspaceId, userWorkspaceCreateDto.Role))
                .ReturnsAsync((UserWorkspace)null);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _service.AssignUserRoleInWorkspaceAsync(userWorkspaceCreateDto));
        }

        [Fact]
        public async Task GetUserRoleInWorkspaceAsync_ShouldReturnRole_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var workspaceId = Guid.NewGuid();
            var userWorkspace = new UserWorkspace(userId, workspaceId, Role.ProjectManager);

            _mockUserWorkspaceRepo.Setup(repo => repo.GetUserWorkspaceByUserIdAndWorkspaceIdAsync(userId, workspaceId))
                .ReturnsAsync(userWorkspace);

            // Act
            var result = await _service.GetUserRoleInWorkspaceAsync(userId, workspaceId);

            // Assert
            Assert.Equal(Role.ProjectManager, result);
        }

        [Fact]
        public async Task GetUserRoleInWorkspaceAsync_ShouldThrowException_WhenUserNotInWorkspace()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var workspaceId = Guid.NewGuid();

            _mockUserWorkspaceRepo.Setup(repo => repo.GetUserWorkspaceByUserIdAndWorkspaceIdAsync(userId, workspaceId))
                .ReturnsAsync((UserWorkspace)null);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _service.GetUserRoleInWorkspaceAsync(userId, workspaceId));
        }
    }
}