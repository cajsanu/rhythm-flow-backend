using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface BaseReadDto<T> where T : BaseEntity
    {
        public BaseReadDto<T> ToDto(T entity);
    }
}

