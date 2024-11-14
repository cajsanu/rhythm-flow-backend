using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class UserService(IUserRepo repository) : BaseService<User, UserReadDto>(repository), IUserService
    {
    }
}