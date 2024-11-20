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
            var email = "test@example.com";
            var password = "password";
            var user = new User("Test", "User", email, "hashedPassword");

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(It.IsAny<Email>())).ReturnsAsync(user);
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
            var email = emailStr;
            User? user = emailStr == "invalid@example.com" ? null : new User("Test", "User", email, "hashedPassword");
            Email emailObj = new Email(email);

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(emailObj)).ReturnsAsync(user);
            _mockPasswordService.Setup(service => service.VerifyPassword(password, It.IsAny<string>())).Returns(false);

            // Act & Assert
            await Assert.ThrowsAsync<UnauthorizedAccessException>(() => _authenticationService.AuthenticateUserAsync(email, password));
        }

        [Fact]
        public async Task GenerateJwtToken_WithValidConfiguration_ShouldReturnToken()
        {
            // Arrange
            var user = new User("Test", "User", "test@example.com", "hashedPassword");

            // Act
            var methodInfo = _authenticationService.GetType()
                                .GetMethod("GenerateJwtToken", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var task = methodInfo?.Invoke(_authenticationService, [user]) as Task<string> ?? throw new InvalidOperationException("Failed to invoke GenerateJwtToken method.");
            var token = await task;

            // Assert
            Assert.NotNull(token);
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);
            Assert.Equal("testIssuer", jwtToken.Issuer);
            Assert.Equal("testAudience", jwtToken.Audiences.First());
        }

        [Fact]
        public async Task GenerateJwtToken_WithInvalidSecret_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var user = new User("Test", "User", "test@example.com", "hashedPassword");
            _mockConfiguration.Setup(config => config["Jwt:Secret"]).Returns("short");

            // Act & Assert
            var methodInfo = _authenticationService.GetType()
                                .GetMethod("GenerateJwtToken", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var task = methodInfo?.Invoke(_authenticationService, [user]) as Task<string> ?? throw new InvalidOperationException("Failed to invoke GenerateJwtToken method.");
            await Assert.ThrowsAsync<InvalidOperationException>(async () => await task);
        }
    }
}