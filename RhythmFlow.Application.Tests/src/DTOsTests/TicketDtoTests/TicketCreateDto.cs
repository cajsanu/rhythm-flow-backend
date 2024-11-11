using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.Tests.src.DTOsTests.TicketDtoTests
{
    public class TicketCreateDtoTests
    {
        private List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        [Theory]
        [InlineData("Ticket 1", "A sample ticket", PriorityEnum.High, "2025-12-31", StatusEnum.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketTypeEnum.Bug, true)]
        [InlineData("", "A sample ticket with missing title", PriorityEnum.Low, "2025-12-31", StatusEnum.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketTypeEnum.Bug, false)] // Missing Title
        [InlineData("Ticket 3", "", PriorityEnum.Medium, "2025-01-01", StatusEnum.Completed, "00000000-0000-0000-0000-000000000000", TicketTypeEnum.Feature, false)] // Invalid ProjectId
        [InlineData("Ticket 4", "Deadline in the past", PriorityEnum.High, "2020-01-01", StatusEnum.InProgress, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketTypeEnum.Feature, false)] // Past Deadline
        [InlineData("Ticket 5", "A valid ticket", PriorityEnum.Low, "2026-07-15", StatusEnum.Completed, "6fa85f64-5717-4562-b3fc-2c963f66afa6", TicketTypeEnum.Bug, true)] // Valid Case
        public void TicketCreateDto_ValidationTests(
            string title, 
            string description, 
            PriorityEnum priority, 
            string deadline, 
            StatusEnum status, 
            string projectId, 
            TicketTypeEnum type, 
            bool isValid)
        {
            // Arrange
            var dto = new TicketCreateDto
            {
                Title = title,
                Description = description,
                Priority = priority,
                Deadline = DateTime.Parse(deadline),
                Status = status,
                ProjectId = Guid.Parse(projectId),
                Type = type
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
