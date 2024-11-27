using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests.FacttoryTests
{
    public class DtoFactoryTests
    {
        private readonly ProjectDtoFactory _projectDtoFactory = new ProjectDtoFactory();
        private readonly WorkspaceDtoFactory _workspaceDtoFactory = new WorkspaceDtoFactory();
        private readonly UserDtoFactory _userDtoFactory = new UserDtoFactory();
        private readonly TicketDtoFactory _ticketDtoFactory = new TicketDtoFactory();

        [Fact]
        public void CreateReadDto_Project_ReturnsProjectReadDto()
        {
            // Arrange
            var project = new TestProject("Line", "Description", new DateOnly(2023, 4, 4), new DateOnly(2026, 3, 3), Status.InProgress, Guid.NewGuid());

            // Act
            var result = _projectDtoFactory.CreateReadDto(project);

            // Assert
            Assert.IsType<ProjectReadDto>(result);
            Assert.Equal(project.Id, result.Id);
            Assert.Equal(project.Name, result.Name);
            Assert.Equal(project.Description, result.Description);
        }

        [Fact]
        public void CreateReadDto_Workspace_ReturnsWorkspaceReadDto()
        {
            // Arrange
            var workspace = new TestWorkSpace("Line workspace", Guid.NewGuid());

            // Act
            var result = _workspaceDtoFactory.CreateReadDto(workspace);

            // Assert
            Assert.IsType<WorkspaceReadDto>(result);
            Assert.Equal(workspace.Id, result.Id);
            Assert.Equal(workspace.Name, result.Name);
        }

        [Fact]
        public void CreateReadDto_User_ReturnsUserReadDto()
        {
            // Arrange
            var user = new TestUser("Anouar", "Belila", "anouar@gmail.com", "password213!@");

            // Act
            var result = _userDtoFactory.CreateReadDto(user);

            // Assert
            Assert.IsType<UserReadDto>(result);
            Assert.Equal(user.Id, result.Id);
            Assert.Equal(user.FirstName, result.FirstName);
            Assert.Equal(user.LastName, result.LastName);
            Assert.Equal(user.Email.Value, result.Email);
        }

        [Fact]
        public void CreateReadDto_Ticket_ReturnsTicketReadDto()
        {
            // Arrange
            var ticket = new TestTicket("Design the table", "Bla bla bla", Priority.High, new DateOnly(2026, 12, 12), Status.InProgress, Guid.NewGuid(), TicketType.Bug);

            // Act
            var result = _ticketDtoFactory.CreateReadDto(ticket);

            // Assert
            Assert.IsType<TicketReadDto>(result);
            Assert.Equal(ticket.Id, result.Id);
            Assert.Equal(ticket.Title, result.Title);
            Assert.Equal(ticket.Description, result.Description);
        }
    }
}