using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.Factories;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    // The assignment service is used to assign a user to an entity and remove a user from an entity.
    // This happens through a many-to-many relationship between the user and the entity.
    // This relationship is represented by a collection of users on the entity and collections of entities on the user.
    // The many-to-many table is implemented in the database as a implicit join table, which means that the table is not explicitly defined in the database schema.
    // Read more about it here: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
    public class AssignmentService<T, TReadDto>(IUserRepo userRepo, IBaseRepo<T> entityRepo,  IDtoFactory<T, TReadDto> dtoFactory) : IAssignmentService<T, TReadDto>
    where T : BaseEntity
    where TReadDto : IBaseReadDto<T>
    {
        private readonly IUserRepo _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
        private readonly IBaseRepo<T> _entityRepo = entityRepo ?? throw new ArgumentNullException(nameof(entityRepo));
        private readonly IDtoFactory<T, TReadDto> _dtoFactory = dtoFactory ?? throw new ArgumentNullException(nameof(dtoFactory));

        public async Task<TReadDto> AssignUserToEntityAsync(Guid userId, Guid entityId)
        {
            var user = await _userRepo.GetByIdAsync(userId);
            var entity = await _entityRepo.GetByIdAsync(entityId);

            if (user == null || entity == null)
            {
                throw new KeyNotFoundException("User or entity not found.");
            }

            // Use reflection to add the user to the entity's collection
            var entityUsers = (entity as dynamic).Users;
            if (!entityUsers.Contains(user))
            {
                entityUsers.Add(user);
                await _entityRepo.UpdateAsync(entity); // Need to make sure SaveChangesAsync is called
            }

            return _dtoFactory.CreateDto(entity);
        }

        public async Task<TReadDto> RemoveUserFromEntityAsync(Guid userId, Guid entityId)
        {
            var user = await _userRepo.GetByIdAsync(userId);
            var entity = await _entityRepo.GetByIdAsync(entityId);

            if (user == null || entity == null)
            {
                throw new KeyNotFoundException("User or entity not found.");
            }

            // Use reflection to remove the user from the entity's collection
            var entityUsers = (entity as dynamic).Users;
            if (entityUsers.Contains(user))
            {
                entityUsers.Remove(user);
                await _entityRepo.UpdateAsync(entity);
            }

            return _dtoFactory.CreateDto(entity);
        }
    }
}