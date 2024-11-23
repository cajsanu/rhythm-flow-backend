using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Projects
{
    public class ProjectReadDto : IBaseReadDto<Project>
    {
        // Added the Id property to the ProjectReadDto because the BaseController needs it
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Status Status { get; set; }
        public Guid WorkspaceId { get; set; }
        public ICollection<UserReadDto> Users { get; set; } = [];
    }
}