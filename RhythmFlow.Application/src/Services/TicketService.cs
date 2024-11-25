using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService(
        ITicketRepo ticketRepository,
        AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> assignmentService,
        IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> ticketDtoFactory, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> userDtoFactory) : BaseService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(ticketRepository, ticketDtoFactory), ITicketService
    {
        private readonly ITicketRepo _ticketRepo = ticketRepository;
        private readonly IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _ticketDtoFactory = ticketDtoFactory;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _userDtoFactory = userDtoFactory;
        private readonly AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _assignmentService = assignmentService;

        public async Task<IEnumerable<TicketReadDto>> GetAllTicketsInProjectAsync(Guid projectId)
        {
            var ticketsInProject = await _ticketRepo.GetAllTicketsInProjectAsync(projectId);
            if (ticketsInProject == null || !ticketsInProject.Any())
            {
                throw new InvalidOperationException("No tickets found in project.");
            }

            return ticketsInProject.Select(_ticketDtoFactory.CreateReadDto).ToList();
        }

        public async Task<IEnumerable<UserReadDto>> GetAllUsersInTicketAsync(Guid ticketId)
        {
            var ticket = await _ticketRepo.GetByIdAsync(ticketId) ?? throw new InvalidOperationException("Ticket not found.");
            var users = ticket.Users;
            if (users.Count == 0)
            {
                return [];
            }

            return users.Select(_userDtoFactory.CreateReadDto).ToList();
        }

        public async Task<TicketReadDto> AssignUserToTicketAsync(Guid userId, Guid ticketId)
        {
            return await _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        public async Task<TicketReadDto> RemoveUserFromTicketAsync(Guid userId, Guid ticketId)
        {
            return await _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
        }
    }
}