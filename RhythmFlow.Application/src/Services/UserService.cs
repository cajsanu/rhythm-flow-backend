using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Services
{
    public class UserService : IUserService
    {
        public Task<UserReadDto> AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserReadDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserReadDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(Guid id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}