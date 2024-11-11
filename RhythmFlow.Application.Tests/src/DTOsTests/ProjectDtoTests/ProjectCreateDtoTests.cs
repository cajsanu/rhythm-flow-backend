using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using Xunit;

namespace RhythmFlow.Application.Tests.src.DTOsTests.ProjectDtoTests
{
    public class ProjectCreateDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
       {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("Project Alpha", "A sample project", "2024-01-01", "2024-12-31", StatusEnum.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6", "7fa85f64-5717-4562-b3fc-2c963f66afa7" }, true)]
        [InlineData("", "A sample project", "2024-01-01", "2024-12-31", StatusEnum.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6" }, false)] // Missing Name
        [InlineData("Project Beta", "", "2024-01-01", "2024-01-01", StatusEnum.NotStarted, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[0], true)] // Valid with empty Description and UsersId
        [InlineData("Project Gamma", "Another project", "2025-01-01", "2024-12-31", StatusEnum.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", new string[] { "invalid-guid" }, false)] // Invalid UsersId GUID
        [InlineData("Project Delta", "Description", "2024-01-01", "2024-12-31", StatusEnum.Cancelled, "00000000-0000-0000-0000-000000000000", new string[] { "6fa85f64-5717-4562-b3fc-2c963f66afa6" }, false)] // Invalid WorkspaceId
        public void ProjectCreateDto_ValidationTests(
            string name, 
            string description, 
            string startDate, 
            string endDate, 
            StatusEnum status, 
            string workspaceId, 
            string[] usersId, 
            bool isValid)
        {
            // Arrange
            var dto = new ProjectCreateDto
            {
                Name = name,
                Description = description,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate),
                Status = status,
                WorkspaceId = Guid.Parse(workspaceId),
                UsersId = ParseGuids(usersId)
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

        private ICollection<Guid> ParseGuids(string[] guids)
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
                    // Return an invalid GUID to trigger validation failure
                    result.Add(Guid.Empty);
                }
            }
            return result;
        }
    }
}
