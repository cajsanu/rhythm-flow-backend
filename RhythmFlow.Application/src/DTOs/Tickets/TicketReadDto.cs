using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Tickets
{
    public class TicketReadDto : IBaseReadDto<Ticket>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityEnum Priority { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }
        public Guid ProjectId { get; set; }
        public TicketTypeEnum Type { get; set; }
        public ICollection<UserReadDto> Users { get; set; } = [];

        public IBaseReadDto<Ticket> ToDto(Ticket entity)
        {
            return new TicketReadDto()
            {
                Title = entity.Title,
                Description = entity.Description,
                Priority = entity.Priority,
                Deadline = entity.Deadline,
                Status = entity.Status,
                ProjectId = entity.ProjectId,
                Type = entity.Type,
                Users = entity.Users.Select(u => new UserReadDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email.Value
                    // Add other properties as needed
                }).ToList()
               
            };
        }

    }
}