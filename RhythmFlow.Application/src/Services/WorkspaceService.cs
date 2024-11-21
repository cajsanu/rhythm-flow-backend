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
    public class WorkspaceService : BaseService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>, IWorkspaceService
    {
        // T
        private readonly AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _assignmentService;
        private readonly IUserWorkspaceRepo _userWorkspaceRepo;
        private readonly IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _workspaceDtoFactory;
        public WorkspaceService(
            IWorkspaceRepo ticketRepository,
            AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> assignmentService,
            WorkspaceDtoFactory workspaceDtoFactory, IUserWorkspaceRepo userWorkspaceRepo)
            : base(ticketRepository, workspaceDtoFactory)
        {
            _assignmentService = assignmentService;
            _userWorkspaceRepo = userWorkspaceRepo;
            _workspaceDtoFactory = workspaceDtoFactory;
        }

        public Task<WorkspaceReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, entityId);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceJoinedByUser(Guid userId)
        {
            IEnumerable<WorkspaceReadDto> workspacesJoinedByUser = _userWorkspaceRepo.GetAllUserWorkspacesByUserIdAsync(userId).Result.Select(_workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesJoinedByUser);
        }

        public Task<IEnumerable<WorkspaceReadDto>> GetAllWorkspaceOwnedByUser(Guid userId)
        {   
            IEnumerable<WorkspaceReadDto> workspacesOwnedByUser = _userWorkspaceRepo.GetWorkspacesOwnedByUserAsync(userId).Result.Select(_workspaceDtoFactory.CreateReadDto);
            return Task.FromResult(workspacesOwnedByUser);
        }

        public Task<WorkspaceReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, entityId);
        }
    }
}