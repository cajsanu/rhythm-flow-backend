using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    // Methods to add or remove a user to a workspace/project/ticket
    public interface IAssignmentService<T, TReadDto>
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
    {
        Task<TReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId);
        Task<TReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId);
    }
}