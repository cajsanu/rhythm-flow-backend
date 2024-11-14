using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Framework.src.Services
{
    public class PasswordService : IPasswordService
    {
        // Hash the password before storing it in the database
        public string HashPassword(string password)
        {
            // Hash password using BCrypt, which automatically salts the password
            // and has a default work factor of 11
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}