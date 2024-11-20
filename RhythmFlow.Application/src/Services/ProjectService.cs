using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService(
        IProjectRepo projectRepo,
        AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> assignmentService,
        ProjectDtoFactory projectDtoFactory) : BaseService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>(projectRepo, projectDtoFactory), IProjectService
    {
        private readonly AssignmentService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto> _assignmentService = assignmentService;

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
