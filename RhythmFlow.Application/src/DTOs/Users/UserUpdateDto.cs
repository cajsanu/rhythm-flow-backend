using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserUpdateDto : IBaseUpdateDto<User>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public IBaseUpdateDto<User> ToDto(User entity)
        {
            return new UserUpdateDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value,
            };
        }


    }
}