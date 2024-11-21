using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseCreateDto<T>
        where T : BaseEntity

    {
        public T ToEntity();
    }
}
