using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Users;

namespace RhythmFlow.UnitTests.src.ApplicationTests.DTOsTests.UserDtoTests
{
    public class UserCreateReadDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("John", "Doe", "john.doe@example.com", "hashedPassword", true)]
        [InlineData("", "Doe", "john.doe@example.com", "hashedPassword", false)] // Missing FirstName
        [InlineData("John", "", "john.doe@example.com", "hashedPassword", false)] // Missing LastName
        [InlineData("John", "Doe", "invalid-email", "hashedPassword", false)] // Invalid Email
        [InlineData("John", "Doe", "john.doe@example.com", "", false)] // Missing PasswordHash
        public void UserCreateReadDto_ValidationTests(string firstName, string lastName, string email, string passwordHash, bool isValid)
        {
            // Arrange
            var dto = new UserCreateDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PasswordHash = passwordHash
            };

            // Act
            var validationResults = ValidateModel(dto);

            // Assert
            if (isValid)
            {
                Assert.Empty(validationResults);
            }
            else
            {
                Assert.NotEmpty(validationResults);
            }
        }
    }
}
