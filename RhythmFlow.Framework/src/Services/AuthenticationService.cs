using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Services
{
    // After some thinking, I have come to the conclusion that there are two options for the Authorization part here.
    // The first option is to use the JWT token as the authorization token,
    // adding a tuple of workspaceId and Role to the claims for every workspce the user is in.
    // The second option is to not include roles in the claims of the JWT token,
    // and instead have separate logic for checking (querying the database on every request) if a user is authorized to perform an action.
    // The first option is more efficient, but whenver a new role is added to a user, the token must be refreshed.
    public class AuthenticationService(IUserRepo userRepo, IPasswordService passwordService, IConfiguration configuration) : IAuthenticationService
    {
        private readonly IUserRepo _userRepo = userRepo;
        private readonly IPasswordService _passwordService = passwordService;
        private readonly IConfiguration _configuration = configuration;

        public async Task<string?> AuthenticateUserAsync(Email userEmail, string password)
        {
            var user = await _userRepo.GetUserByEmailAsync(userEmail);
            if (user == null || !_passwordService.VerifyPassword(password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            return GenerateJwtToken(user);
        }

        private string GenerateJwtToken(User user)
        {
            // Create key for the token
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);
            if (key.Length < 32)
            {
                throw new InvalidOperationException("JWT secret must be at least 32 characters long");
            }

            // Add claims for the token
            var claims = new List<Claim>
            {
                new (ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:TokenLifetime"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}