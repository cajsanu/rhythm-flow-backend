using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.FactoryInterfaces
{
    public interface IDtoFactory<in T, out TReadDto>
        where T : BaseEntity
    {
        TReadDto CreateDto(T entity);
    }
}