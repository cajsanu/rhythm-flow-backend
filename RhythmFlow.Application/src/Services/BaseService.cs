using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class BaseService<T, TReadDto>(IBaseRepo<T> repository, IDtoFactory<T, TReadDto> dtoFactory) : IBaseService<T, TReadDto>
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
    {
        private readonly IBaseRepo<T> _repository = repository;
        private readonly IDtoFactory<T, TReadDto> _dtoFactory = dtoFactory;

        // Add DTOs to all methods when possible
        public async Task<IEnumerable<TReadDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            if (entities == null || !entities.Any())
            {
                throw new InvalidOperationException($"No {typeof(T).Name}s found.");
            }

            return entities.Select(_dtoFactory.CreateDto).ToList();
        }

        public async Task<TReadDto> GetByIdAsync(Guid id)
        {
            // Check if entity exists
            var entity = await _repository.GetByIdAsync(id) ?? throw new KeyNotFoundException($"{typeof(T).Name} with ID {id} not found.");
            return _dtoFactory.CreateDto(entity);
        }

        public async Task<TReadDto> AddAsync(T entity)
        {
            // Do we want to check for duplicates before adding?
            var newEntity = await _repository.AddAsync(entity);
            return _dtoFactory.CreateDto(newEntity);
        }

        public async Task<TReadDto> UpdateAsync(Guid id, T entity)
        {
            // This will throw an exception if the entity does not exist
            _ = await _repository.GetByIdAsync(id) ?? throw new KeyNotFoundException($"{typeof(T).Name} with ID {id} not found.");
            var updatedEntity = await _repository.UpdateAsync(entity) ?? throw new InvalidOperationException($"Failed to update {typeof(T).Name} with ID {entity.Id}.");
            return _dtoFactory.CreateDto(updatedEntity);
        }

        public async Task DeleteAsync(Guid id)
        {
            // This will throw an exception if the entity does not exist
            await GetByIdAsync(id);
            await _repository.DeleteAsync(id);
        }
    }
}