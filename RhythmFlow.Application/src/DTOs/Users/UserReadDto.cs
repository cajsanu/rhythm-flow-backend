using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.DTOs.Users
{
    public class UserReadDto : IBaseReadDto<User>
    {
        // Addded the Id property to the UserReadDto because the BaseController needs it
        public Guid Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set; }

        public IBaseReadDto<User> ToDto(User entity)
        {
            return new UserReadDto() {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email.Value
            };
        }
        
    }
}