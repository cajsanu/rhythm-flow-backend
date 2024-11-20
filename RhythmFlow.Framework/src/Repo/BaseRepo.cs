using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class BaseRepo<T>(AppDbContext _context) : IBaseRepo<T>
        where T : BaseEntity
    {
        public Task<T> AddAsync(T entity)
        {
            _context.Add(entity);
            return Task.FromResult(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            var entity = _context.GetById<T>(id) ?? throw new ArgumentException($"{typeof(T)} with ID {id} does not exist.");
            _context.Delete<T>(id);
            return Task.FromResult(entity);
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            // maybe a good idea to do some pagination
            var allItems = _context.GetAll<T>();
            return Task.FromResult(allItems);
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            var entity = _context.GetById<T>(id) ?? throw new ArgumentException($"{typeof(T)} with ID {id} does not exist.");
            return Task.FromResult(entity);
        }

        public Task<T> UpdateAsync(T entity)
        {
            _ = _context.GetById<T>(entity.Id) ?? throw new ArgumentException($"{typeof(T)} with ID {entity.Id} not found. ");
            _context.Update(entity);
            return Task.FromResult(entity);
        }
    }
}