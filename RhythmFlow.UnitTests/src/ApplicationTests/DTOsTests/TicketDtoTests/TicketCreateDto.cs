using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.DTOsTests.TicketDtoTests
{
    public class TicketCreateReadDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("Ticket 1", "A sample ticket", Priority.High, "2025-12-31", Status.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketType.Bug, true)]
        [InlineData("", "A sample ticket with missing title", Priority.Low, "2025-12-31", Status.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketType.Bug, false)] // Missing Title
        [InlineData("Ticket 3", "", Priority.Medium, "2025-01-01", Status.Completed, "00000000-0000-0000-0000-000000000000", TicketType.Feature, false)] // Invalid ProjectId
        [InlineData("Ticket 4", "Deadline in the past", Priority.High, "2020-01-01", Status.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketType.Feature, false)] // Past Deadline
        [InlineData("Ticket 5", "A valid ticket", Priority.Low, "2026-07-15", Status.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketType.Bug, true)] // Valid Case
        public void TicketCreateReadDto_ValidationTests(
            string title,
            string description,
            Priority priority,
            string deadline,
            Status status,
            string projectId,
            TicketType type,
            bool isValid)
            
        {
            // Arrange
            var dto = new TicketCreateDto
            {
                Title = title,
                Description = description,
                Priority = priority,
                Deadline = DateOnly.Parse(deadline),
                Status = status,
                ProjectId = Guid.Parse(projectId),
                Type = type,
                UserIds = []
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
