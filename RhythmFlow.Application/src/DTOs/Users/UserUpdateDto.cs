using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserUpdateDto : IBaseUpdateDto<User>
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set; }
        // Not sure if this is the right way to handle password in user create dto or the password should in hased way in the request body
        public string PasswordHash { get; set; }

        public IBaseUpdateDto<User> ToDto(User entity)
        {
            return new UserUpdateDto() {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
                PasswordHash = entity.PasswordHash
            };
        }
        public User ToEntity()
        {
            return new User(FirstName, LastName, Email, PasswordHash);
        }
        
    }
}