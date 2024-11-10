using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseReadDto<T> where T : BaseEntity
    {
        public IBaseReadDto<T> ToDto(T entity);
    }
}

