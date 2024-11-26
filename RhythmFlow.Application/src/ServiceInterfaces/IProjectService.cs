using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IProjectService : IBaseService<Project, ProjectReadDto, ProjectCreateDto, ProjectUpdateDto>
    {
        Task<IEnumerable<ProjectReadDto>> GetAllProjectsInWorkspaceAsync(Guid workspaceId);
        Task<IEnumerable<UserReadDto>> GetAllUsersInProjectAsync(Guid projectId);
        Task<ProjectReadDto> AssignUserToProjectAsync(Guid userId, Guid projectId);
        Task<ProjectReadDto> RemoveUserFromProjectAsync(Guid userId, Guid projectId);
    }
}