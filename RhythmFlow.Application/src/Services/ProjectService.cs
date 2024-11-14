using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService : BaseService<Project, ProjectReadDto>, IProjectService
    {
        // T
        private readonly AssignmentService<Project, ProjectReadDto> _assignmentService;

        public ProjectService(
            IProjectRepo projectRepo,
            AssignmentService<Project, ProjectReadDto> assignmentService,
            ProjectDtoFactory projectDtoFactory)
            : base(projectRepo, projectDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarAnalyzer", "S927", Justification = "This is a special implementation")]
        public Task<ProjectReadDto> AssignUserToEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarAnalyzer", "S927", Justification = "This is a special implementation")]
        public Task<ProjectReadDto> RemoveUserFromEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
        }
    }
}