using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Moq;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.Authorization.Handlers;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.HandlerTests
{
    public class ManagerInProjectHandlerTests
    {
        private readonly Mock<IProjectService> _mockProjectService;
        private readonly ManagerInProjectHandler _handler;

        public ManagerInProjectHandlerTests()
        {
            _mockProjectService = new Mock<IProjectService>();
            _handler = new ManagerInProjectHandler(_mockProjectService.Object);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIsManagerOfProject_ShouldSucceed()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var project = new Project("Test Project", "Description", DateTime.Now, DateTime.Now.AddDays(30), Status.InProgress, Guid.NewGuid(), userId);

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new ManagerInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            _mockProjectService.Setup(service => service.GetByIdAsync(projectId)).Returns(Task.FromResult((ProjectReadDto)new ProjectReadDto().ToDto(project)));

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.True(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIsNotManager_ShouldFail()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var project = new Project("Test Project", "Description", DateTime.Now, DateTime.Now.AddDays(30), Status.InProgress, Guid.NewGuid(), Guid.NewGuid());

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new ManagerInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            _mockProjectService.Setup(service => service.GetByIdAsync(projectId)).Returns(Task.FromResult((ProjectReadDto)new ProjectReadDto().ToDto(project)));

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_ProjectIdNotProvided_ShouldFail()
        {
            // Arrange
            var userId = Guid.NewGuid();

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new ManagerInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, null);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIdNotFoundInClaims_ShouldFail()
        {
            // Arrange
            var projectId = Guid.NewGuid();

            var user = new ClaimsPrincipal(new ClaimsIdentity());

            var requirement = new ManagerInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }
    }
}