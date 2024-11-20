using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.FactoryInterfaces
{
    public interface IDtoFactory<in T, out TReadDto, out TCreateReadDto, out TUpdateDto>
        where T : BaseEntity
    {
        TReadDto CreateReadDto(T entity);
        // TCreateReadDto CreateCreateReadDto(T entity);
        TUpdateDto CreateUpdateDto(T entity);

    }
}