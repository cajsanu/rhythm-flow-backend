using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class WorkspaceService(AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> assignmentService, IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> workspaceDtoFactory, IUserWorkspaceRepo userWorkspaceRepo, IWorkspaceRepo workspaceRepo)
    : BaseService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(workspaceRepo, workspaceDtoFactory), IWorkspaceService
    {
        public Task<WorkspaceReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            return assignmentService.AssignUserToEntityAsync(userId, entityId);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceJoinedByUser(Guid userId)
        {
            IEnumerable<WorkspaceReadDto> workspacesJoinedByUser = userWorkspaceRepo.GetAllUserWorkspacesByUserIdAsync(userId).Result.Select(workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesJoinedByUser);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceOwnedByUser(Guid userId)
        {
            IEnumerable<WorkspaceReadDto> workspacesOwnedByUser = userWorkspaceRepo.GetWorkspacesOwnedByUserAsync(userId).Result.Select(workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesOwnedByUser);
        }

        public Task<WorkspaceReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            return assignmentService.RemoveUserFromEntityAsync(userId, entityId);
        }
    }
}