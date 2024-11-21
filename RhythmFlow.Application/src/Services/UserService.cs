using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserService(IUserRepo userRepo, IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> dtoFactory, IPasswordService passwordService) : BaseService<User, UserReadDto, UserCreateDto, UserUpdateDto>(userRepo, dtoFactory), IUserService
    {
        private readonly IUserRepo _userRepo = userRepo;
        private readonly IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto> _dtoFactory = dtoFactory;
        private readonly IPasswordService _passwordService = passwordService;

        public override async Task<UserReadDto> AddAsync(UserCreateDto createDto)
        {
            // Check if user with email already exists
            Email email = new (createDto.Email);
            var user = await _userRepo.GetUserByEmailAsync(email);
            if (user != null)
            {
                throw new InvalidOperationException($"User with email {createDto.Email} already exists.");
            }

            createDto.PasswordHash = _passwordService.HashPassword(createDto.Password);
            return await base.AddAsync(createDto);
        }

        public async Task<UserReadDto?> GetUserByEmailAsync(Email email)
        {
            var user = await _userRepo.GetUserByEmailAsync(email) ?? throw new KeyNotFoundException($"User with email {email} not found.");
            return _dtoFactory.CreateReadDto(user);
        }
    }
}