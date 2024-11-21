using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class TicketService : BaseService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>, ITicketService
    {
        private readonly AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> _assignmentService;
        private readonly IProjectRepo _projectRepo;
        private readonly ITicketRepo _ticketRepo;

        private bool CheckUserInTheProject(Guid userId, Guid ticketId)
        {
            Ticket ticket = _ticketRepo.GetByIdAsync(ticketId).Result;
            Project project = _projectRepo.GetByIdAsync(ticket.ProjectId).Result;
            var userInProject = project.Users.FirstOrDefault(u => u.Id == userId);
            if (userInProject != null) return true;
            else throw new InvalidOperationException("User is not in the project");
        }
        public TicketService(
        ITicketRepo ticketRepository,
        AssignmentService<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto> assignmentService,
        TicketDtoFactory ticketDtoFactory, IProjectRepo projectRepo)
        : base(ticketRepository, ticketDtoFactory)
        {
            _assignmentService = assignmentService;
            _ticketRepo = ticketRepository;
            _projectRepo = projectRepo;
        }

        public Task<TicketReadDto> AssignUserToEntityAsync(Guid userId, Guid ticketId)
        {
            CheckUserInTheProject(userId, ticketId);
            return _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        public Task<TicketReadDto> RemoveUserFromEntityAsync(Guid userId, Guid ticketId)
        {
            CheckUserInTheProject(userId, ticketId);
            return _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
        }
    }
}