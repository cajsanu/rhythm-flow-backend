using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.DTOsTests.UserWorkspaceDtoTests
{
    public class UserWorkspaceCreateReadDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("6fa85f64-5717-4562-b3fc-2c963f66afa6", "6fa85f64-5717-4562-b3fc-2c963f66afa6", Role.Developer, true)] // Valid case
        [InlineData("00000000-0000-0000-0000-000000000000", "6fa85f64-5717-4562-b3fc-2c963f66afa6", Role.ProjectManager, false)] // Invalid UserId (empty GUID)
        [InlineData("6fa85f64-5717-4562-b3fc-2c963f66afa6", "00000000-0000-0000-0000-000000000000", Role.ProjectManager, false)] // Invalid WorkspaceId (empty GUID)
        [InlineData("6fa85f64-5717-4562-b3fc-2c963f66afa6", "6fa85f64-5717-4562-b3fc-2c963f66afa6", (Role)999, false)] // Invalid Role (out of range)
        public void UserWorkspaceCreateReadDto_ValidationTests(
            string userId,
            string workspaceId,
            Role role,
            bool isValid)
        {
            // Arrange
            var dto = new UserWorkspaceCreateDto
            {
                UserId = Guid.Parse(userId),
                WorkspaceId = Guid.Parse(workspaceId),
                Role = role
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
