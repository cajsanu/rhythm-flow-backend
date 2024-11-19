using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserService(IUserRepo userRepo, IDtoFactory<User, UserReadDto> dtoFactory) : BaseService<User, UserReadDto>(userRepo, dtoFactory), IUserService
    {
        private readonly IUserRepo _userRepo = userRepo;
        private readonly IDtoFactory<User, UserReadDto> _dtoFactory = dtoFactory;

        public async Task<UserReadDto?> GetUserByEmailAsync(Email email)
        {
            var user = await _userRepo.GetUserByEmailAsync(email) ?? throw new KeyNotFoundException($"User with email {email} not found.");
            return _dtoFactory.CreateDto(user);
        }
    }
}