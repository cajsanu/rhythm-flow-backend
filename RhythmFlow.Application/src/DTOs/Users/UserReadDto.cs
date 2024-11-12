

using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserReadDto : IBaseReadDto<User>
    {
        public required string FirstName { get; set;}
        public required string LastName { get; set;}
        public required string Email { get; set; }

        public IBaseReadDto<User> ToDto(User entity)
        {
            return new UserReadDto() {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value
            };
        }
        
    }
}