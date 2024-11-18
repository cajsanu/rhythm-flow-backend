using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectReadDto : IBaseReadDto<Project>
    {
        // Addded the Id property to the ProjectReadDto because the BaseController needs it
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<UserReadDto> Users { get; set; } = [];

        public static IBaseReadDto<Project> ToDto(Project entity)
        {
            return new ProjectReadDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                WorkspaceId = entity.WorkspaceId,
                Users = entity.Users.Select(u => (UserReadDto)UserReadDto.ToDto(u)).ToList()
            };
        }
    }
}