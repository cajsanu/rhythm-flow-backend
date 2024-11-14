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

        // Verify the password against a stored hash
        public bool VerifyPassword(string password, string passwordHash)
        {
            // Verify password using BCrypt
            var passwordIsValid = BCrypt.Net.BCrypt.Verify(password, passwordHash);
            return passwordIsValid;
        }
    }
}