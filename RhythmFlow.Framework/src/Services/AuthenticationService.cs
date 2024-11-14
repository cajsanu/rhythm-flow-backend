using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.RepoInterfaces;

namespace RhythmFlow.Framework.src.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepo _userRepo;
        // private readonly IPasswordService _passwordService;

        public AuthenticationService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
            // _passwordService = passwordService;
        }

        public async Task<string?> AuthenticateUser(string username, string password)
        {
           throw new NotImplementedException();
        }
    }
}