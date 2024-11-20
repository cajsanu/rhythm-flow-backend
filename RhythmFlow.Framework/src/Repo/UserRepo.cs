using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserRepo(AppDbContext _context) : BaseRepo<User>(_context), IUserRepo
    {
        public async Task<User?> GetUserByEmailAsync(Email email)
        {
            return await Task.FromResult(_context.Users.Find(u => u.Email == email));
        }
    }
}