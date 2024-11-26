using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class TicketDtoFactory : IDtoFactory<Ticket, TicketReadDto, TicketCreateDto, TicketUpdateDto>
    {
        public TicketReadDto CreateReadDto(Ticket entity)
        {
            return new TicketReadDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Status = entity.Status,
                Priority = entity.Priority,
                Type = entity.Type,
                ProjectId = entity.ProjectId,
                Users = entity.Users.Select(u => new UserReadDto
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email.Value
                }).ToList()
            };
        }
    }
}