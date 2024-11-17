using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Moq;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.Authorization.Handlers;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.HandlerTests
{
    public class WorkspaceRoleHandlerTests
    {
        private readonly Mock<IUserWorkspaceService> _mockUserWorkspaceService;
        private readonly WorkspaceRoleHandler _handler;

        public WorkspaceRoleHandlerTests()
        {
            _mockUserWorkspaceService = new Mock<IUserWorkspaceService>();
            _handler = new WorkspaceRoleHandler(_mockUserWorkspaceService.Object);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserHasRequiredRole_ShouldSucceed()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var workspaceId = Guid.NewGuid();
            var requiredRole = "ProjectManager";

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new RoleInWorkspaceRequirement(requiredRole);
            var context = new AuthorizationHandlerContext([requirement], user, workspaceId);

            _mockUserWorkspaceService.Setup(service => service.GetUserRoleInWorkspaceAsync(userId, workspaceId))
                .ReturnsAsync(Role.ProjectManager);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.True(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserDoesNotHaveRequiredRole_ShouldFail()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var workspaceId = Guid.NewGuid();
            var requiredRole = "ProjectManager";

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new RoleInWorkspaceRequirement(requiredRole);
            var context = new AuthorizationHandlerContext([requirement], user, workspaceId);

            _mockUserWorkspaceService.Setup(service => service.GetUserRoleInWorkspaceAsync(userId, workspaceId))
                .ReturnsAsync(Role.Developer);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIdNotFoundInClaims_ShouldFail()
        {
            // Arrange
            var workspaceId = Guid.NewGuid();
            var requiredRole = "Developer";

            var user = new ClaimsPrincipal(new ClaimsIdentity());

            var requirement = new RoleInWorkspaceRequirement(requiredRole);
            var context = new AuthorizationHandlerContext([requirement], user, workspaceId);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_WorkspaceIdNotProvided_ShouldFail()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var requiredRole = "Developer";

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new RoleInWorkspaceRequirement(requiredRole);
            var context = new AuthorizationHandlerContext([requirement], user, null);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }
    }
}