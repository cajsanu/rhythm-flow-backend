using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseUpdateDto<T>
      //  where T : BaseEntity
    {
        public T ToEntity(Guid guid);
        public abstract IBaseUpdateDto<T> ToDto(T entity);
    }
}
