using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Authorization.Handlers
{
    public class UserIsUserHandler(IUserService userService, IHttpContextAccessor httpContextAccessor) : AuthorizationHandler<UserIsUserRequirement>
    {
        private readonly IUserService _userService = userService;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            UserIsUserRequirement requirement)
        {
            // context.Succeed(requirement);

            // Extract target user ID from route data
            var routeData = _httpContextAccessor.HttpContext?.GetRouteData();
            if (routeData == null || !routeData.Values.TryGetValue("id", out var targetUserIdValue)
                || !Guid.TryParse(targetUserIdValue?.ToString(), out var targetUserId))
            {
                context.Fail();
                return;
            }

            // Get user ID from the claims
            if (!Guid.TryParse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var userId))
            {
                context.Fail();
                return;
            }

            // validate for user Existence
            var user = await _userService.GetByIdAsync(userId);
            if (user == null)
            {
                context.Fail();
                return;
            }

            // Validate if the user is the same as target user
            if (targetUserId == userId)
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
    }
}