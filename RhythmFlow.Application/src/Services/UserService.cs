using RhythmFlow.Application.src.DTOs.Users;
<<<<<<< HEAD
using RhythmFlow.Application.src.FactoryInterfaces;
=======
>>>>>>> main
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
<<<<<<< HEAD
    public class UserService : BaseService<User, UserReadDto>, IUserService
    {
        public UserService(IBaseRepo<User> repository, IDtoFactory<User, UserReadDto> dtoFactory) : base(repository, dtoFactory)
        {
        }
=======
    public class UserService(IUserRepo repository) : BaseService<User, UserReadDto>(repository), IUserService
    {
>>>>>>> main
    }
}