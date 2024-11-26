using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class WorkspaceService(AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> assignmentService, IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> workspaceDtoFactory, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> userDtoFactory, IUserWorkspaceRepo userWorkspaceRepo, IWorkspaceRepo workspaceRepo)
    : BaseService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(workspaceRepo, workspaceDtoFactory), IWorkspaceService
    {
        private readonly AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _assignmentService = assignmentService;
        private readonly IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _workspaceDtoFactory = workspaceDtoFactory;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _userDtoFactory = userDtoFactory;
        private readonly IUserWorkspaceRepo _userWorkspaceRepo = userWorkspaceRepo;

        public Task<WorkspaceReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, entityId);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceJoinedByUserAsync(Guid userId)
        {
            IEnumerable<WorkspaceReadDto> workspacesJoinedByUser = _userWorkspaceRepo.GetAllUserWorkspacesByUserIdAsync(userId).Result.Select(_workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesJoinedByUser);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceOwnedByUserAsync(Guid userId)
        {
            IEnumerable<WorkspaceReadDto> workspacesOwnedByUser = _userWorkspaceRepo.GetWorkspacesOwnedByUserAsync(userId).Result.Select(_workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesOwnedByUser);
        }

        public async Task<IEnumerable<UserReadDto>> GetAllUsersInWorkspaceAsync(Guid workspaceId)
        {
            var usersInWorkspace = await _userWorkspaceRepo.GetAllUsersInWorkspaceAsync(workspaceId);
            return usersInWorkspace.Select(_userDtoFactory.CreateReadDto).ToList();
        }

        public Task<WorkspaceReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, entityId);
        }
    }
}