using System.ComponentModel.DataAnnotations;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserCreateDto : IBaseCreateDto<User>
    {
        [Required]
        required public string FirstName { get; set; }
        [Required]
        required public string LastName { get; set; }
        [Required]
        [EmailAddress]
        required public string Email { get; set; }
        [Required]
        required public string Password { get; set; }
        public string? PasswordHash { get; set; }

        public User ToEntity()
        {
            if (PasswordHash == null)
            {
                throw new InvalidOperationException("PasswordHash cannot be null.");
            }

            return new User(FirstName, LastName, Email, PasswordHash);
        }
    }
}