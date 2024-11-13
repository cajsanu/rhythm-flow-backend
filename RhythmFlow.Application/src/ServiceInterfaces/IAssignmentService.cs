using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    // Methods to add or remove a user to a workspace/project/ticket
    public interface IAssignmentService<T>
        where T : BaseEntity
    {
        Task<User> AssignUserToEntityAsync(Guid userId, Guid entityId);
        Task<User> RemoveUserFromEntityAsync(Guid userId, Guid entityId);
    }
}