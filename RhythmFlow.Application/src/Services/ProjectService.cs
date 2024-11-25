using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService(
        IProjectRepo projectRepo,
        AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> assignmentService,
        IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> projectDtoFactory, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> userDtoFactory) : BaseService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(projectRepo, projectDtoFactory), IProjectService
    {
        private readonly IProjectRepo _projectRepo = projectRepo;
        private readonly IDtoFactory<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _projectDtoFactory = projectDtoFactory;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _userDtoFactory = userDtoFactory;
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

        public async Task<IEnumerable<UserReadDto>> GetAllUsersInProjectAsync(Guid projectId)
        {
            var project = await _projectRepo.GetByIdAsync(projectId) ?? throw new InvalidOperationException("Project not found");
            var users = project.Users.Select(_userDtoFactory.CreateReadDto).ToList();
            if (users.Count == 0)
            {
                return [];
            }

            return users;
        }

        public async Task<ProjectReadDto> AssignUserToProjectAsync(Guid userId, Guid projectId)
        {
            return await _assignmentService.AssignUserToEntityAsync(userId, projectId);
        }

        public async Task<ProjectReadDto> RemoveUserFromProjectAsync(Guid userId, Guid projectId)
        {
            return await _assignmentService.RemoveUserFromEntityAsync(userId, projectId);
        }
    }
}
