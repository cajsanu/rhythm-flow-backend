using Moq;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
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
        private readonly Mock<IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>> _mockDtoFactory;
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _serviceAssignment;
        private readonly TicketService _service;

        public TicketServiceTests()
        {
            _mockTicketRepo = new Mock<ITicketRepo>();
            _mockDtoFactory = new Mock<IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>>();
            _mockUserRepo = new Mock<IUserRepo>();
            _serviceAssignment = new AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(
                _mockUserRepo.Object,
                _mockTicketRepo.Object,
                _mockDtoFactory.Object
            );
            _service = new TicketService(_mockTicketRepo.Object, _serviceAssignment, new TicketDtoFactory());
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
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(ticket)).Returns(dto);

            // Act
            var result = await _service.AssignUserToEntityAsync(userId, ticketId);

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
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(ticket)).Returns(dto);

            // Act
            var result = await _service.RemoveUserFromEntityAsync(userId, ticketId);

            // Assert
            Assert.Equal(ticket.Id, result.Id);
            Assert.DoesNotContain(user, ticket.Users);
        }
    }
}
