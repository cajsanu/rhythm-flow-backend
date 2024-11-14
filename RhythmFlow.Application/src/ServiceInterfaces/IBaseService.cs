using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IBaseService<T, TReadDto>
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
    {
        Task<IEnumerable<TReadDto>> GetAllAsync();
        Task<TReadDto> GetByIdAsync(Guid id);
        Task<TReadDto> AddAsync(T entity);
        Task<TReadDto> UpdateAsync(Guid id, T entity);
        Task DeleteAsync(Guid id);
    }
}