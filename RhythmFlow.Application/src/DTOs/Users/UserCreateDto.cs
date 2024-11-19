using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserCreateReadDto : IBaseCreateReadDto<User>
    {
        [Required]
        required public string FirstName { get; set; }
        [Required]
        required public string LastName { get; set; }
        [Required]
        [EmailAddress]
        required public string Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }

        public IBaseCreateReadDto<User> ToDto(User entity)
        {
            return new UserCreateReadDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
                PasswordHash = entity.PasswordHash
            };
        }

        public User ToEntity()
        {
            return new User(FirstName, LastName, Email!, PasswordHash!);
        }
    }
}