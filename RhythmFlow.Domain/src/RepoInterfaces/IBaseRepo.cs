using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}