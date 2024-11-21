using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IBaseService<T, TReadDto, TCreateDto, TUpdateDto>
        where T : BaseEntity
    {
        Task<IEnumerable<TReadDto>> GetAllAsync();
        Task<TReadDto> GetByIdAsync(Guid id);
        Task<TReadDto> AddAsync(TCreateDto entity);
        Task<TReadDto> UpdateAsync(Guid id, T entity);
        Task DeleteAsync(Guid id);
    }
}