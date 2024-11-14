using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.Services
{
    public class UserService(IUserRepo repository) : BaseService<User, UserReadDto>(repository), IUserService
    {
        public static User GetUserByEmailAsync(Email email)
        {
            throw new NotImplementedException();
        }
    }
}