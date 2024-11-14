using System.IdentityModel.Tokens.Jwt;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

// Basically, there is no role connected to the user directly, but a user has a role connected to a workspace through the UserWorkspace join table.
// When a user logs in, the authentication service will check if the user exists and if the password is correct. Then a JWT token will be generated and returned.
// The JWT token will be used to authenticate the user in the future requests. However, the role of the user is not checked in the authentication process.
// The role of the user should be checked in the authorization process when the user tries perform an action on a entity in the workspace.
// This also means, for tickets and projects, we first have to check if the user has a role in the workspace before we can check if the user has the right role to perform the action.

namespace RhythmFlow.Framework.src.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepo _userRepo;
        private readonly IPasswordService _passwordService;

        public AuthenticationService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
            _passwordService = passwordService;
        }

        public async Task<string?> AuthenticateUserAsync(Email userEmail, string password)
        {
            var user = await _userRepo.GetUserByEmailAsync(userEmail);
            if (user = null || !_passwordService.VerifyPassword(password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            return GenerateJwtToken(user);
        }

        private static string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            return "JWT token";
        }
    }
}