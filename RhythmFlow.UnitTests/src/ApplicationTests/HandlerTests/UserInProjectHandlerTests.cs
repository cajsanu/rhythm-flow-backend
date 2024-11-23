using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Moq;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.Authorization.Handlers;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.HandlerTests
{
    public class UserInProjectHandlerTests
    {
        private readonly IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _projectDtoFactoryForArranging;

        private readonly Mock<IProjectService> _mockProjectService;
        private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
        private readonly UserInProjectHandler _handler;

        public UserInProjectHandlerTests()
        {
            _projectDtoFactoryForArranging = new ProjectDtoFactory();

            _mockProjectService = new Mock<IProjectService>();
            _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            _handler = new UserInProjectHandler(_mockProjectService.Object, _mockHttpContextAccessor.Object);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIsInProject_ShouldSucceed()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var project = new Project("Test Project", "Description", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now).AddDays(30), Status.InProgress, Guid.NewGuid())
            {
                Users = [new User("Test", "User", "test@example.com", "hashedPassword") { Id = userId }]
            };

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new UserInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            var projectDto = _projectDtoFactoryForArranging.CreateReadDto(project);
            _mockProjectService.Setup(service => service.GetByIdAsync(projectId)).Returns(Task.FromResult(projectDto));

            var routeData = new RouteData();
            routeData.Values["projectId"] = projectId.ToString();
            var httpContext = new DefaultHttpContext();
            httpContext.Features.Set<IRoutingFeature>(new RoutingFeature { RouteData = routeData });
            _mockHttpContextAccessor.Setup(accessor => accessor.HttpContext).Returns(httpContext);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.True(context.HasSucceeded);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIsNotInProject_ShouldFail()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var projectId = Guid.NewGuid();
            var project = new Project("Test Project", "Description", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now).AddDays(30), Status.InProgress, Guid.NewGuid())
            {
                Users = [new User("Test", "User", "test@example.com", "hashedPassword") { Id = Guid.NewGuid() }]
            };

            var user = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new UserInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            var projectDto = _projectDtoFactoryForArranging.CreateReadDto(project);
            _mockProjectService.Setup(service => service.GetByIdAsync(projectId)).Returns(Task.FromResult(projectDto));

            var routeData = new RouteData();
            routeData.Values["projectId"] = projectId.ToString();
            var httpContext = new DefaultHttpContext();
            httpContext.Features.Set<IRoutingFeature>(new RoutingFeature { RouteData = routeData });
            _mockHttpContextAccessor.Setup(accessor => accessor.HttpContext).Returns(httpContext);

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
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            ]));

            var requirement = new UserInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, null);

            var routeData = new RouteData();
            routeData.Values["projectId"] = null;
            var httpContext = new DefaultHttpContext();
            httpContext.Features.Set<IRoutingFeature>(new RoutingFeature { RouteData = routeData });
            _mockHttpContextAccessor.Setup(accessor => accessor.HttpContext).Returns(httpContext);

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

            var requirement = new UserInProjectRequirement();
            var context = new AuthorizationHandlerContext([requirement], user, projectId);

            var routeData = new RouteData();
            routeData.Values["projectId"] = projectId.ToString();
            var httpContext = new DefaultHttpContext();
            httpContext.Features.Set<IRoutingFeature>(new RoutingFeature { RouteData = routeData });
            _mockHttpContextAccessor.Setup(accessor => accessor.HttpContext).Returns(httpContext);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.False(context.HasSucceeded);
        }
    }
}