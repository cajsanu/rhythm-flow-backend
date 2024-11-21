namespace RhythmFlow.Application.src.DTOs.Shared
{
    public interface IBaseUpdateDto<T>

    // where T : BaseEntity
    {
        public T ToEntity(Guid guid);
        public static abstract IBaseUpdateDto<T> ToDto(T entity);
    }
}
