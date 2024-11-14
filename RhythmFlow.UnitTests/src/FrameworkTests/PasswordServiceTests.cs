using RhythmFlow.Framework.src.Services;

namespace RhythmFlow.UnitTests.src.FrameworkTests
{
    public class PasswordServiceTests
    {
        private readonly PasswordService _passwordService;

        public PasswordServiceTests()
        {
            _passwordService = new PasswordService();
        }

        [Fact]
        public void HashPassword_ShouldReturnHashedPassword()
        {
            // Arrange
            var password = "TestPassword123";

            // Act
            var hashedPassword = _passwordService.HashPassword(password);

            // Assert
            Assert.False(string.IsNullOrEmpty(hashedPassword));
            Assert.NotEqual(password, hashedPassword);
        }

        [Fact]
        public void VerifyPassword_WithCorrectPassword_ShouldReturnTrue()
        {
            // Arrange
            var password = "TestPassword123";
            var hashedPassword = _passwordService.HashPassword(password);

            // Act
            var result = _passwordService.VerifyPassword(password, hashedPassword);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_WithIncorrectPassword_ShouldReturnFalse()
        {
            // Arrange
            var password = "TestPassword123";
            var incorrectPassword = "WrongPassword123";
            var hashedPassword = _passwordService.HashPassword(password);

            // Act
            var result = _passwordService.VerifyPassword(incorrectPassword, hashedPassword);

            // Assert
            Assert.False(result);
        }
    }
}