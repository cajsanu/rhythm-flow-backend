using Moq;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    public class TicketServiceTests
    {
        private readonly Mock<ITicketRepo> _mockTicketRepo;
        private readonly Mock<IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>> _mockTicketDtoFactory;
        private readonly Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>> _mockUserDtoFactory;
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _serviceAssignment;
        private readonly TicketService _service;

        public TicketServiceTests()
        {
            _mockTicketRepo = new Mock<ITicketRepo>();
            _mockTicketDtoFactory = new Mock<IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>>();
            _mockUserDtoFactory = new Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>>();
            _mockUserRepo = new Mock<IUserRepo>();
            _serviceAssignment = new AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(
                _mockUserRepo.Object,
                _mockTicketRepo.Object,
                _mockTicketDtoFactory.Object
            );
            _service = new TicketService(_mockTicketRepo.Object, _mockUserRepo.Object, _serviceAssignment, _mockTicketDtoFactory.Object, _mockUserDtoFactory.Object);
        }

        [Fact]
        public async Task AssignUserToEntityAsync_ShouldAssignUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var ticketId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var ticket = new TestTicket("Design the table", "Bla bla bla", Priority.High, DateOnly.FromDateTime(new DateTime(2026, 12, 12)), Status.InProgress, Guid.NewGuid(), TicketType.Bug) { Id = ticketId };
            var dto = new TestTicketReadDto { Id = ticket.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockTicketRepo.Setup(repo => repo.GetByIdAsync(ticketId)).ReturnsAsync(ticket);
            _mockTicketDtoFactory.Setup(factory => factory.CreateReadDto(ticket)).Returns(dto);

            // Act
            var result = await _service.AssignUserToTicketAsync(userId, ticketId);

            // Assert
            Assert.Equal(ticketId, result.Id);
            Assert.Contains(user, ticket.Users);
        }

        [Fact]
        public async Task RemoveUserFromEntityAsync_ShouldRemoveUser_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var ticketId = Guid.NewGuid();
            var user = new TestUser("testname", "test2", "test@gmail.com", "testpassword21342@!!") { Id = userId };
            var ticket = new TestTicket("Design the table", "Bla bla bla", Priority.High, DateOnly.FromDateTime(new DateTime(2026, 12, 12)), Status.InProgress, Guid.NewGuid(), TicketType.Bug) { Id = ticketId, Users = new List<User> { user } };
            var dto = new TestTicketReadDto { Id = ticket.Id };
            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);
            _mockTicketRepo.Setup(repo => repo.GetByIdAsync(ticketId)).ReturnsAsync(ticket);
            _mockTicketDtoFactory.Setup(factory => factory.CreateReadDto(ticket)).Returns(dto);

            // Act
            var result = await _service.RemoveUserFromTicketAsync(userId, ticketId);

            // Assert
            Assert.Equal(ticket.Id, result.Id);
            Assert.DoesNotContain(user, ticket.Users);
        }

        [Fact]
        public async Task AddAsync_ShouldAddTicket_WhenValidInput()
        {
            // Arrange
            var ticketCreateDto = new TestTicketCreateDto
            {
                Title = "New Ticket",
                Description = "Ticket Description",
                Priority = Priority.High,
                Deadline = DateOnly.FromDateTime(DateTime.Now.AddDays(30)),
                Status = Status.InProgress,
                ProjectId = Guid.NewGuid(),
                Type = TicketType.Bug,
                UserIds = [Guid.NewGuid()]
            };
            var newTicket = new TestTicket(ticketCreateDto.Title, ticketCreateDto.Description, ticketCreateDto.Priority, ticketCreateDto.Deadline, ticketCreateDto.Status, ticketCreateDto.ProjectId, ticketCreateDto.Type);
            var dto = new TestTicketReadDto { Id = newTicket.Id };

            _mockUserRepo.Setup(repo => repo.GetByIdsAsync(ticketCreateDto.UserIds)).ReturnsAsync([new User("Test", "User", "test@example.com", "hashedPassword")]);
            _mockTicketRepo.Setup(repo => repo.AddAsync(It.IsAny<Ticket>())).ReturnsAsync(newTicket);
            _mockTicketDtoFactory.Setup(factory => factory.CreateReadDto(newTicket)).Returns(dto);

            // Act
            var result = await _service.AddAsync(ticketCreateDto);

            // Assert
            Assert.Equal(newTicket.Id, result.Id);
        }

        [Fact]
        public async Task GetAllTicketsInProjectAsync_ShouldReturnTickets_WhenTicketsExist()
        {
            // Arrange
            var projectId = Guid.NewGuid();
            var tickets = new List<Ticket>
            {
                new TestTicket("Ticket 1", "Description 1", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, projectId, TicketType.Bug),
                new TestTicket("Ticket 2", "Description 2", Priority.Medium, DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, projectId, TicketType.Feature)
            };
            var dtos = tickets.Select(t => new TestTicketReadDto { Id = t.Id }).ToList();

            _mockTicketRepo.Setup(repo => repo.GetAllTicketsInProjectAsync(projectId)).ReturnsAsync(tickets);
            _mockTicketDtoFactory.Setup(factory => factory.CreateReadDto(It.IsAny<Ticket>())).Returns((Ticket t) => new TestTicketReadDto { Id = t.Id });

            // Act
            var result = await _service.GetAllTicketsInProjectAsync(projectId);

            // Assert
            Assert.Equal(dtos.Count, result.Count());
        }

        [Fact]
        public async Task GetAllUsersInTicketAsync_ShouldReturnUsers_WhenUsersExist()
        {
            // Arrange
            var ticketId = Guid.NewGuid();
            var users = new List<User>
            {
                new ("Test", "User1", "user1@example.com", "hashedPassword") { Id = Guid.NewGuid() },
                new ("Test", "User2", "user2@example.com", "hashedPassword") { Id = Guid.NewGuid() }
            };
            var ticket = new TestTicket("Ticket", "Description", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.InProgress, Guid.NewGuid(), TicketType.Bug) { Id = ticketId, Users = users };
            var dtos = users.Select(u => new TestUserReadDto { Id = u.Id }).ToList();

            _mockTicketRepo.Setup(repo => repo.GetByIdAsync(ticketId)).ReturnsAsync(ticket);
            _mockUserDtoFactory.Setup(factory => factory.CreateReadDto(It.IsAny<User>())).Returns((User u) => new TestUserReadDto { Id = u.Id });

            // Act
            var result = await _service.GetAllUsersInTicketAsync(ticketId);

            // Assert
            Assert.Equal(dtos.Count, result.Count());
        }
    }
}
