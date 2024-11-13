using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class AssignmentService<T, TReadDto>(IUserRepo userRepo, IBaseRepo<T> entityRepo) : IAssignmentService<T, TReadDto>
    where T : BaseEntity
    where TReadDto : IBaseReadDto<T>, new()
    {
        private readonly IUserRepo _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
        private readonly IBaseRepo<T> _entityRepo = entityRepo ?? throw new ArgumentNullException(nameof(entityRepo));

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
                await _entityRepo.UpdateAsync(entity);
            }

            return (TReadDto)new TReadDto().ToDto(entity);
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

            return (TReadDto)new TReadDto().ToDto(entity);
        }
    }
}