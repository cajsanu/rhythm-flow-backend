using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserCreateDto : IBaseCreateDto<User>
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        // Projects and Workspaces are not needed in the create dto but can be added in update dto

        public IBaseCreateDto<User> ToDto(User entity)
        {
            return new UserCreateDto() {
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