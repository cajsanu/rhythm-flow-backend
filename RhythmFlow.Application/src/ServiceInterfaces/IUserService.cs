using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IUserService : IBaseService<User, UserReadDto, UserCreateDto, UserUpdateDto>
    {
    }
}