using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserUpdateDto : IBaseUpdateDto<User>
    {
        required public string FirstName { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string PasswordHash { get; set; }

        public IBaseUpdateDto<User> ToDto(User entity)
        {
            return new UserUpdateDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
                PasswordHash = entity.PasswordHash
            };
        }

        public User ToEntity(Guid guid)
        {
            return new User(FirstName, LastName, Email, PasswordHash, guid);
        }
    }
}