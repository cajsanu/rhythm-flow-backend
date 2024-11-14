using RhythmFlow.Application.src.DTOs.Projects;
<<<<<<< HEAD
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Application.src.Factories;
=======
>>>>>>> main
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
<<<<<<< HEAD
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
=======
    public class ProjectService(IProjectRepo repository) : BaseService<Project, ProjectReadDto>(repository), IProjectService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
>>>>>>> main
