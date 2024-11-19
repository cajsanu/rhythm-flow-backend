using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IAuthenticationService
    {
        // Authenticate user and return JWT token the authentication is successful
        Task<string?> AuthenticateUserAsync(Email userEmail, string password);
    }
}