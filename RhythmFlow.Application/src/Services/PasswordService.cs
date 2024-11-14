using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Application.src.Services
{
    public class PasswordService : IPasswordService
    {
        public string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}