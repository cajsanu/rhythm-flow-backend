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
    // For development purposes, the JWT token secrets are stored in the appsettings.Development.json file.
    // Run the application with the ASPNETCORE_ENVIRONMENT environment variable set to Development to use the development settings.
    public class AuthenticationService(IUserRepo userRepo, IPasswordService passwordService, IConfiguration configuration) : IAuthenticationService
    {
        private readonly IUserRepo _userRepo = userRepo;
        private readonly IPasswordService _passwordService = passwordService;
        private readonly IConfiguration _configuration = configuration;

        public async Task<string?> AuthenticateUserAsync(string userEmail, string password)
        {
            Email email = new Email(userEmail);
            var user = await _userRepo.GetUserByEmailAsync(email);
            if (user == null || !_passwordService.VerifyPassword(password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid email or password");
            }

            return await GenerateJwtToken(user);
        }

        private async Task<string> GenerateJwtToken(User user)
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