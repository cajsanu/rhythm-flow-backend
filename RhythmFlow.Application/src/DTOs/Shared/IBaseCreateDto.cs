using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseCreateReadDto<T>
        where T : BaseEntity

    {
        public IBaseCreateReadDto<T> ToDto(T entity);
        public T ToEntity();
    }
}
