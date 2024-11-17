using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class ProjectService(
        IProjectRepo projectRepo,
        AssignmentService<Project, ProjectReadDto> assignmentService,
        IDtoFactory<Project, ProjectReadDto> projectDtoFactory) : BaseService<Project, ProjectReadDto>(projectRepo, projectDtoFactory), IProjectService
    {
        private readonly AssignmentService<Project, ProjectReadDto> _assignmentService = assignmentService;

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
