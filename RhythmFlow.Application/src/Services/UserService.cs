using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserService : BaseService<User, UserReadDto, UserCreateDto, UserUpdateDto>, IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _dtoFactory;
        public UserService(IUserRepo repository, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> dtoFactory) : base(repository, dtoFactory)
        {
            _userRepo = repository;
            _dtoFactory = dtoFactory;
        }

        public async Task<UserReadDto?> GetUserByEmailAsync(Email email)
        {
            var user = await _userRepo.GetUserByEmailAsync(email) ?? throw new KeyNotFoundException($"User with email {email} not found.");
            return _dtoFactory.CreateReadDto(user);
        }
    }
}