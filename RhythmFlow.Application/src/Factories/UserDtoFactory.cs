using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class UserDtoFactory : IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>
    {
        // public UserCreateDto CreateCreateReadDto(User entity)
        // {
        //     return new UserCreateDto
        //     {
        //         FirstName = entity.FirstName,
        //         LastName = entity.LastName,
        //         Email = entity.Email.Value
        //     };
        // }
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

        public UserUpdateDto CreateUpdateDto(User entity)
        {
            return new UserUpdateDto
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
                PasswordHash = entity.PasswordHash
            };
        }
    }
}