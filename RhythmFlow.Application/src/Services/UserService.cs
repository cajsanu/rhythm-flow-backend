using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class UserService : BaseService<User, UserReadDto, UserCreateReadDto, UserUpdateDto>, IUserService
    {
        public UserService(IBaseRepo<User> repository, IDtoFactory<User, UserReadDto, UserCreateReadDto, UserUpdateDto> dtoFactory) : base(repository, dtoFactory)
        {
        }
    }
}