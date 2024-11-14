using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Moq;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Services;

namespace RhythmFlow.UnitTests.src.FrameworkTests
{
    public class AuthenticationServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IPasswordService> _mockPasswordService;
        private readonly Mock<IConfiguration> _mockConfiguration;
        private readonly AuthenticationService _authenticationService;

        public AuthenticationServiceTests()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            _mockPasswordService = new Mock<IPasswordService>();
            _mockConfiguration = new Mock<IConfiguration>();

            _mockConfiguration.Setup(config => config["Jwt:Secret"]).Returns("supersecretkey1234567890somuchlonger");
            _mockConfiguration.Setup(config => config["Jwt:TokenLifetime"]).Returns("60");
            _mockConfiguration.Setup(config => config["Jwt:Issuer"]).Returns("testIssuer");
            _mockConfiguration.Setup(config => config["Jwt:Audience"]).Returns("testAudience");

            _authenticationService = new AuthenticationService(_mockUserRepo.Object, _mockPasswordService.Object, _mockConfiguration.Object);
        }

        [Fact]
        public async Task AuthenticateUserAsync_WithValidCredentials_ShouldReturnJwtToken()
        {
            // Arrange
            var email = new Email("test@example.com");
            var password = "password";
            var user = new User("Test", "User", email.Value, "hashedPassword");

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(email)).ReturnsAsync(user);
            _mockPasswordService.Setup(service => service.VerifyPassword(password, user.PasswordHash)).Returns(true);

            // Act
            var token = await _authenticationService.AuthenticateUserAsync(email, password);

            // Assert
            Assert.NotNull(token);
            Assert.False(string.IsNullOrWhiteSpace(token));
        }

        [Theory]
        [InlineData("invalid@example.com", "validPassword")]
        [InlineData("valid@example.com", "invalidPassword")]
        public async Task AuthenticateUserAsync_WithInvalidCredentials_ShouldThrowUnauthorizedAccessException(string emailStr, string password)
        {
            // Arrange
            var email = new Email(emailStr);
            User? user = emailStr == "invalid@example.com" ? null : new User("Test", "User", email.Value, "hashedPassword");

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(email)).ReturnsAsync(user);
            _mockPasswordService.Setup(service => service.VerifyPassword(password, It.IsAny<string>())).Returns(false);

            // Act & Assert
            await Assert.ThrowsAsync<UnauthorizedAccessException>(() => _authenticationService.AuthenticateUserAsync(email, password));
        }

        [Fact]
        public void GenerateJwtToken_ValidUser_ReturnsToken()
        {
            // Arrange
            var email = new Email("test@example.com");
            var user = new User("Test", "User", email.Value, "hashedPassword");

            // Act
            var token = _authenticationService.GetType()
                                    .GetMethod("GenerateJwtToken", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                    ?.Invoke(_authenticationService, [user]) as string;

            // Assert
            Assert.NotNull(token);
            Assert.False(string.IsNullOrWhiteSpace(token));
        }
    }
}