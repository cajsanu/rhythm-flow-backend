using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IBaseService<T, TReadDto, TCreateDto, TUpdateDto>
        where T : BaseEntity

        // where TReadDto : IBaseReadDto<T>
    {
        Task<IEnumerable<TReadDto>> GetAllAsync();
        Task<TReadDto?> GetByIdAsync(Guid id);
        Task<TReadDto> AddAsync(TCreateDto entityDto);
        Task<TReadDto?> UpdateAsync(Guid id, TUpdateDto entityDto);
        Task DeleteAsync(Guid id);
    }
}