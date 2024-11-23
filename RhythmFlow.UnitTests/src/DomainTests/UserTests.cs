using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.DomainTests
{
    public class UserTests
    {
        [Fact]
        public void CreateUser_WithValidData_ShouldCreateUser()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Doe";
            var email = "john.doe@example.com";
            var password = "passwordHash";

            // Act
            var user = new User(firstName, lastName, email, password);

            // Assert
            Assert.Equal(firstName, user.FirstName);
            Assert.Equal(lastName, user.LastName);
            Assert.Equal(email, user.Email.Value);
            Assert.Equal(password, user.PasswordHash);
        }

        [Fact]
        public void CreateUser_WithInvalidFirstName_ShouldThrowException()
        {
            // Arrange
            var firstName = "";
            var lastName = "Doe";
            var email = "john.doe@example.com";
            var password = "passwordHash";

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new User(firstName, lastName, email, password));
        }

        [Fact]
        public void CreateUser_WithInvalidLastName_ShouldThrowException()
        {
            // Arrange
            var firstName = "John";
            var lastName = "";
            var email = "john.doe@example.com";
            var password = "passwordHash";

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new User(firstName, lastName, email, password));
        }

        [Fact]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var user = new User("John", "Doe", "john.doe@example.com", "passwordHash");

            // Act
            var result = user.ToString();

            // Assert
            Assert.Equal($"Id: {user.Id} name: John Doe, email: (john.doe@example.com)", result);
        }

        [Fact]
        public void User_ShouldAddProjectToProjectsCollection()
        {
            // Arrange
            var user = new User("John", "Doe", "john.doe@example.com", "passwordHash");
            var project = new Project("Project Name", "Project Description", DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, Guid.NewGuid());

            // Act
            user.Projects.Add(project);

            // Assert
            Assert.Single(user.Projects);
            Assert.Contains(project, user.Projects);
        }

        [Fact]
        public void User_ShouldAddTicketToTicketsCollection()
        {
            // Arrange
            var user = new User("John", "Doe", "john.doe@example.com", "passwordHash");
            var ticket = new Ticket("Ticket Title", "Ticket Description", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(7)), Status.InProgress, Guid.NewGuid(), TicketType.Bug);

            // Act
            user.Tickets.Add(ticket);

            // Assert
            Assert.Single(user.Tickets);
            Assert.Contains(ticket, user.Tickets);
        }
    }
}