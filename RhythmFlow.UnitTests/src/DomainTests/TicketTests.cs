using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.DomainTests
{
    public class TicketTests
    {
        [Fact]
        public void CreateTicket_WithValidData_ShouldCreateTicket()
        {
            // Arrange
            var title = "Ticket Title";
            var description = "Ticket Description";
            var priority = Priority.High;
            var deadline = DateTime.Now.AddDays(7);
            var status = Status.InProgress;
            var projectId = Guid.NewGuid();
            var type = TicketType.Bug;

            // Act
            var ticket = new Ticket(title, description, priority, deadline, status, projectId, type);

            // Assert
            Assert.Equal(title, ticket.Title);
            Assert.Equal(description, ticket.Description);
            Assert.Equal(priority, ticket.Priority);
            Assert.Equal(deadline, ticket.Deadline);
            Assert.Equal(status, ticket.Status);
            Assert.Equal(projectId, ticket.ProjectId);
            Assert.Equal(type, ticket.Type);
        }

        [Fact]
        public void CreateTicket_WithInvalidTitle_ShouldThrowException()
        {
            // Arrange
            var title = "";
            var description = "Ticket Description";
            var priority = Priority.High;
            var deadline = DateTime.Now.AddDays(7);
            var status = Status.InProgress;
            var projectId = Guid.NewGuid();
            var type = TicketType.Bug;

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new Ticket(title, description, priority, deadline, status, projectId, type));
        }

        [Fact]
        public void CreateTicket_WithInvalidDescription_ShouldThrowException()
        {
            // Arrange
            var title = "Ticket Title";
            var description = "";
            var priority = Priority.High;
            var deadline = DateTime.Now.AddDays(7);
            var status = Status.InProgress;
            var projectId = Guid.NewGuid();
            var type = TicketType.Bug;

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new Ticket(title, description, priority, deadline, status, projectId, type));
        }
    }
}