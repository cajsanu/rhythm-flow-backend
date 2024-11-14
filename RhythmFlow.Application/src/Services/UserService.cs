using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserService(IUserRepo repository) : BaseService<User, UserReadDto>(repository), IUserService
    {
        public async Task<User?> GetUserByEmailAsync(Email email)
        {
            var user = await repository.GetUserByEmailAsync(email) ?? throw new KeyNotFoundException($"User with email {email} not found.");
            return user;
        }
    }
}