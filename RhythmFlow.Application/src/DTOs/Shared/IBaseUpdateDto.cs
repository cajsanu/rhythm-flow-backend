using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseUpdateDto<T> where T : BaseEntity
    {
        public IBaseUpdateDto<T> ToDto(T entity);
        // This is method is used if the entity should be fully updated
    }
}

