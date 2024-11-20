using RhythmFlow.Application.DTOs.Workspaces;
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

        public WorkspaceService(
            IWorkspaceRepo ticketRepository,
            AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> assignmentService,
            WorkspaceDtoFactory workspaceDtoFactory)
            : base(ticketRepository, workspaceDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        public Task<WorkspaceReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, entityId);
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceJoinedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceOwnedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<WorkspaceReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, entityId);
        }
    }
}