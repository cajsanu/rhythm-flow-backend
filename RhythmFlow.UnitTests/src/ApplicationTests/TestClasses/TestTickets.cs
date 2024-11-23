using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestTicket(string title, string description, Priority priority, DateOnly deadline, Status status, Guid projectId, TicketType type) : Ticket(title, description, priority, deadline, status, projectId, type)
    {
    }

    public class TestTicketReadDto : TicketReadDto
    {
    }
    public class TestTicketCreateDto : TicketCreateDto
    {
    }
    public class TestTicketUpdateDto : TicketUpdateDto
    {
    }
}