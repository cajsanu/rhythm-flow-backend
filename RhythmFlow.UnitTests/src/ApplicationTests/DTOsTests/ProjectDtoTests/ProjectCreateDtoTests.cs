using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.DTOsTests.ProjectDtoTests
{
    public class ProjectCreateReadDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("Project Alpha", "A sample project", "2024-01-01", "2028-12-31", Status.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6", "7fa85f64-5717-4562-b3fc-2c963f66afa7" }, true)]
        [InlineData("", "A sample project", "2024-01-01", "2027-12-31", Status.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6" }, false)] // Missing Name
        [InlineData("Project Beta", "", "2024-01-01", "2027-01-01", Status.NotStarted, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[0], true)] // Valid with empty Description and UsersId
        [InlineData("Project Gamma", "Another project", "2025-01-01", "2026-12-31", Status.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "00000000-0000-0000-0000-000000000000" }, false)] // Invalid UsersId GUID
        [InlineData("Project Delta", "Description", "2024-01-01", "2026-12-31", Status.Cancelled, "00000000-0000-0000-0000-000000000000", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6" }, false)] // Invalid WorkspaceId
        public void ProjectCreateReadDtoValidationTests(
            string name,
            string description,
            string startDate,
            string endDate,
            Status status,
            string workspaceId,
            string[] usersId,
            bool isValid)
        {
            // Arrange
            var dto = new ProjectCreateDto
            {
                Name = name,
                Description = description,
                StartDate = DateOnly.Parse(startDate),
                EndDate = DateOnly.Parse(endDate),
                Status = status,
                WorkspaceId = Guid.Parse(workspaceId),
                UserIds = ParseGuids(usersId)
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

        private static List<Guid> ParseGuids(string[] guids)
        {
            var result = new List<Guid>();
            foreach (var guid in guids)
            {
                if (Guid.TryParse(guid, out var parsedGuid))
                {
                    result.Add(parsedGuid);
                }
                else
                {
                    // Add Guid.Empty to simulate an invalid GUID
                    result.Add(Guid.Empty);
                }
            }

            return result;
        }
    }
}
