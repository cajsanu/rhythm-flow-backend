using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class BaseService<T, TReadDto>(IBaseRepo<T> repository) : IBaseService<T, TReadDto> 
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>, new()
    {
        private readonly IBaseRepo<T> _repository = repository;

        // Add DTOs to all methods when possible
        public async Task<IEnumerable<TReadDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            if (entities == null || !entities.Any())
            {
                throw new InvalidOperationException($"No {typeof(T).Name}s found.");
            }

            return entities.Select(entity => (TReadDto)new TReadDto().ToDto(entity));
        }

        public async Task<TReadDto> GetByIdAsync(Guid id)
        {
            // Check if entity exists
            var entity = await _repository.GetByIdAsync(id) ?? throw new KeyNotFoundException($"{typeof(T).Name} with ID {id} not found.");
            return (TReadDto)new TReadDto().ToDto(entity);
        }

        public async Task<TReadDto> AddAsync(T entity)
        {
            // Do we want to check for duplicates before adding?
            var newEntity = await _repository.AddAsync(entity);
            return (TReadDto)new TReadDto().ToDto(newEntity);
        }

        public async Task<T> UpdateAsync(Guid id, T entity)
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