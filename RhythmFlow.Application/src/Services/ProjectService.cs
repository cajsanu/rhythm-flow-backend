using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService : BaseService<Project, ProjectReadDto, ProjectCreateReadDto, ProjectUpdateDto>, IProjectService
    {
        private readonly AssignmentService<Project, ProjectReadDto, ProjectCreateReadDto, ProjectUpdateDto> _assignmentService;

        public ProjectService(
            IProjectRepo projectRepo,
            AssignmentService<Project, ProjectReadDto, ProjectCreateReadDto, ProjectUpdateDto> assignmentService,
            ProjectDtoFactory projectDtoFactory)
            : base(projectRepo, projectDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        public Task<ProjectReadDto> AssignUserToEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, ticketId);
        }

        public Task<ProjectReadDto> RemoveUserFromEntityAsync(Guid userId, Guid ticketId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, ticketId);
        }
    }
}
