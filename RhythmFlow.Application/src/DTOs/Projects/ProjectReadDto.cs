

using System.Runtime.CompilerServices;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectReadDto : IBaseReadDto<Project>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<UserReadDto> Users { get; set; } = [];

        public IBaseReadDto<Project> ToDto(Project entity)
        {
            return new ProjectReadDto()
            {
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
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