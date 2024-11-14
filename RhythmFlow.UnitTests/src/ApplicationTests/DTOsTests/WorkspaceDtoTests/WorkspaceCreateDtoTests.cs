using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.DTOs.Workspaces;

namespace RhythmFlow.UnitTests.src.ApplicationTests.DTOsTests.WorkspaceDtoTests
{
    public class WorkspaceCreateDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("Workspace Alpha", "6fa85f64-5717-4562-b3fc-2c963f66afa6", true)] // Valid case
        [InlineData("", "6fa85f64-5717-4562-b3fc-2c963f66afa6", false)] // Missing Name
        [InlineData("Workspace Beta", "00000000-0000-0000-0000-000000000000", false)] // Invalid OwnerId (empty GUID)
        public void WorkspaceCreateDto_ValidationTests(
            string name,
            string ownerId,
            bool isValid)
        {
            // Arrange
            var dto = new WorkspaceCreateDto
            {
                Name = name,
                OwnerId = Guid.Parse(ownerId)
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
