using RhythmFlow.Application.DTOs.Workspaces;
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
    public class WorkspaceService : BaseService<Workspace, WorkspaceReadDto>, IWorkspaceService
    {
        // T
        private readonly AssignmentService<Workspace, WorkspaceReadDto> _assignmentService;

        public WorkspaceService(
            IWorkspaceRepo ticketRepository,
            AssignmentService<Workspace, WorkspaceReadDto> assignmentService,
            WorkspaceDtoFactory workspaceDtoFactory)
            : base(ticketRepository, workspaceDtoFactory)
        {
            _assignmentService = assignmentService;
        }

        public Task<WorkspaceReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.AssignUserToEntityAsync(userId, entityId);
=======
    public class WorkspaceService(IWorkspaceRepo repository) : BaseService<Workspace, WorkspaceReadDto>(repository), IWorkspaceService
    {
        public Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
>>>>>>> main
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceJoinedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Workspace>> GetAllWorkspaceOwnedByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Task<WorkspaceReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            return _assignmentService.RemoveUserFromEntityAsync(userId, entityId);
=======
        public Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
>>>>>>> main
        }
    }
}