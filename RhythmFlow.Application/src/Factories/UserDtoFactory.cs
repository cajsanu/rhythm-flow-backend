using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class UserDtoFactory : IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>
    {
        public UserReadDto CreateReadDto(User entity)
        {
            return new UserReadDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value
            };
        }

    }
}