using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IUserRepo : IBaseRepo<User>
    {
        Task<User> GetUserByEmailAsync(Email email);
    }
}