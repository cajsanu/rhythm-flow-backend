using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService(
        IProjectRepo projectRepo,
        AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> assignmentService,
        IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> projectDtoFactory) : BaseService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(projectRepo, projectDtoFactory), IProjectService
    {
        private readonly IProjectRepo _projectRepo = projectRepo;
        private readonly IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _projectDtoFactory = projectDtoFactory;
        private readonly AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _assignmentService = assignmentService;

        public async Task<IEnumerable<ProjectReadDto>> GetAllProjectsInWorkspaceAsync(Guid workspaceId)
        {
            var projectsInWorkspace = await _projectRepo.GetAllProjectsInWorkspaceAsync(workspaceId);
            if (projectsInWorkspace == null)
            {
                return [];
            }

            return projectsInWorkspace.Select(_projectDtoFactory.CreateReadDto).ToList();
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
