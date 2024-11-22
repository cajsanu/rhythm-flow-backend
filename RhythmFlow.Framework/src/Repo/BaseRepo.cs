using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class BaseRepo<T>(AppDbContext context) : IBaseRepo<T>
        where T : BaseEntity
    {
        private readonly AppDbContext _context = context;
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id) ?? throw new ArgumentException($"{typeof(T)} with ID {id} does not exist.");
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            // maybe a good idea to do some pagination
            var allItems = await _dbSet.ToListAsync();
            return await Task.FromResult(allItems);
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            // var entity = _context.GetById<T>(id) ?? throw new ArgumentException($"{typeof(T)} with ID {id} does not exist.");
            return await _dbSet.FindAsync(id);
        }

        public async Task<T?> UpdateAsync(T entity)
        {
            _ = await _dbSet.FindAsync(entity.Id) ?? throw new ArgumentException($"{typeof(T)} with ID {entity.Id} not found. ");
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return await _dbSet.FindAsync(entity.Id);
        }
    }
}