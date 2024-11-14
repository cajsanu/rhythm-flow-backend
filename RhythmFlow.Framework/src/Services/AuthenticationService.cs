using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

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

        private string GenerateJwtToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}