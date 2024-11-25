using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService(
        ITicketRepo ticketRepo,
        IUserRepo userRepo,
        AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> assignmentService,
        IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> ticketDtoFactory, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> userDtoFactory) : BaseService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>(ticketRepo, ticketDtoFactory), ITicketService
    {
        private readonly ITicketRepo _ticketRepo = ticketRepo;
        private readonly IUserRepo _userRepo = userRepo;
        private readonly IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _ticketDtoFactory = ticketDtoFactory;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _userDtoFactory = userDtoFactory;
        private readonly AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _assignmentService = assignmentService;

        public override async Task<TicketReadDto> AddAsync(TicketCreateDto ticketCreateDto)
        {
            var newTicketEntity = ticketCreateDto.ToEntity();

            var users = await _userRepo.GetByIdsAsync(ticketCreateDto.UserIds) ?? throw new InvalidOperationException("User not found");

            newTicketEntity.Users = users;

            var newEntity = await _ticketRepo.AddAsync(newTicketEntity) ?? throw new InvalidOperationException($"Failed to add {typeof(Ticket).Name}.");
            return _ticketDtoFactory.CreateReadDto(newEntity);
        }

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