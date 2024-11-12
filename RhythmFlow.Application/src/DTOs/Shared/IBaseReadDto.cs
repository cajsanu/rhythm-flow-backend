using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseReadDto<T>
        where T : BaseEntity
    {
        public Guid Id { get; } // This is needed for some of the methods using Read DTOs in the BaseController
        public IBaseReadDto<T> ToDto(T entity);
    }
}
