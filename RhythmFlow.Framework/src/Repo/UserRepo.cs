using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserRepo(AppDbContext _context) : BaseRepo<User>(_context), IUserRepo
    {
        public Task<User> GetUserByEmailAsync(Email email)
        {
            throw new NotImplementedException();
        }
        
    }
}