using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class AssignmentService<T, TReadDto>(IBaseRepo<T> repository) : IAssignmentService<T, TReadDto>
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
    {
        private readonly IBaseRepo<T> _repository = repository;

        public async Task<TReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public async Task<TReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}