using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class BaseService<T>(IBaseRepo<T> repository) : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepo<T> _repository = repository;

        // Add DTOs to all methods when possible
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            if (entities == null || !entities.Any())
            {
                throw new InvalidOperationException($"No {typeof(T).Name}s found.");
            }

            return entities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            // Check if entity exists
            var entity = await _repository.GetByIdAsync(id) ?? throw new KeyNotFoundException($"{typeof(T).Name} with ID {id} not found.");
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            // Do we want to check for duplicates before adding?
            var newEntity = await _repository.AddAsync(entity);
            return newEntity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            // This will throw an exception if the entity does not exist
            await GetByIdAsync(entity.Id);
            var updatedEntity = await _repository.UpdateAsync(entity) ?? throw new InvalidOperationException($"Failed to update {typeof(T).Name} with ID {entity.Id}.");
            return updatedEntity;
        }

        public async Task DeleteAsync(Guid id)
        {
            // This will throw an exception if the entity does not exist
            await GetByIdAsync(id);
            await _repository.DeleteAsync(id);
        }
    }
}