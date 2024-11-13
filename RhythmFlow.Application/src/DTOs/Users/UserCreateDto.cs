using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserCreateDto : IBaseCreateDto<User>
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }
        // Projects and Workspaces are not needed in the create dto but can be added in update dto

        public IBaseCreateDto<User> ToDto(User entity)
        {
            return new UserCreateDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
                PasswordHash = entity.PasswordHash
            };
        }
        // Exlamation mark is used to tell the compiler that the value is not null
        public User ToEntity()
        {
            return new User(FirstName!, LastName!, Email!, PasswordHash!);
        }

    }
}