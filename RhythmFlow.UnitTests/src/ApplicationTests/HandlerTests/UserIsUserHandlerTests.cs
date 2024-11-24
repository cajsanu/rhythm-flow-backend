using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Moq;
using RhythmFlow.Application.src.Authorization;
using RhythmFlow.Application.src.Authorization.Handlers;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.ApplicationTests.HandlerTests
{
    public class UserIsUserHandlerTests
    {
        private readonly UserDtoFactory _userDtoFactoryForArranging;
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
        private readonly UserIsUserHandler _handler;
        public UserIsUserHandlerTests()
        {
            _userDtoFactoryForArranging = new UserDtoFactory();

            _mockUserService = new Mock<IUserService>();
            _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            _handler = new UserIsUserHandler(_mockUserService.Object, _mockHttpContextAccessor.Object);
        }

        [Fact]
        public async Task HandleRequirementAsync_UserIsIUser_ShouldSucceed()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = new User("Test", "User", "test@example.com", "hashedPassword") { Id = userId };
            Assert.Equal(userId, user.Id);
            var targetUser = new ClaimsPrincipal(new ClaimsIdentity(
            [
                new (ClaimTypes.NameIdentifier, userId.ToString())
            ]));
            var requirement = new UserIsUserRequirement();
            var context = new AuthorizationHandlerContext([requirement], targetUser, userId);

            var userDto = _userDtoFactoryForArranging.CreateReadDto(user);
            _mockUserService.Setup(service => service.GetByIdAsync(userId)).Returns(Task.FromResult(userDto));

            var routeData = new RouteData();
            routeData.Values["id"] = userId.ToString();
            var httpContext = new DefaultHttpContext();
            httpContext.Features.Set<IRoutingFeature>(new RoutingFeature { RouteData = routeData });
            _mockHttpContextAccessor.Setup(accessor => accessor.HttpContext).Returns(httpContext);

            // Act
            await _handler.HandleAsync(context);

            // Assert
            Assert.True(context.HasSucceeded);
        }
    }
}