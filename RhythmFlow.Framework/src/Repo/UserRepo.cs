using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;

namespace RhythmFlow.Framework.src.Repo
{
    public class UserRepo(AppDbContext _context) : BaseRepo<User>(_context), IUserRepo
    {
        private readonly DbSet<User> _dbSet = _context.Set<User>();
        public async Task<User?> GetUserByEmailAsync(Email email)
        {
            return await Task.FromResult(_context.GetUserByEmail(email));
        }

        public async override Task<User?> UpdateAsync(User entity)
        {
            // swap entity property with foundEntity Property
            var foundEntity = await _dbSet.FindAsync(entity.Id) ?? throw new ArgumentException($"User with ID {entity.Id} not found. ");
            foundEntity.FirstName = entity.FirstName;
            foundEntity.LastName = entity.LastName;
            foundEntity.Email = entity.Email;
            foundEntity.PasswordHash = entity.PasswordHash;

            // then save the changes
            await _context.SaveChangesAsync();
            return await _dbSet.FindAsync(entity.Id);
        }
    }
}