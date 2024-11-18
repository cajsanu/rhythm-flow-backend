using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Tickets
{
    public class TicketUpdateDto : IBaseUpdateDto<Ticket>
    {
        required public string Title { get; set; }
        required public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime Deadline { get; set; }
        public Status Status { get; set; }
        public Guid ProjectId { get; set; }
        public TicketType Type { get; set; }
        public ICollection<Guid> UsersId { get; set; } = [];

        public static IBaseUpdateDto<Ticket> ToDto(Ticket entity)
        {
            return new TicketUpdateDto()
            {
                Title = entity.Title,
                Description = entity.Description,
                Priority = entity.Priority,
                Deadline = entity.Deadline,
                Status = entity.Status,
                ProjectId = entity.ProjectId,
                Type = entity.Type,
                UsersId = entity.Users.Select(u => u.Id).ToList()
            };
        }

        public Ticket ToEntity()
        {
            return new Ticket(Title!, Description!, Priority, Deadline, Status, ProjectId, Type);
        }
    }
}