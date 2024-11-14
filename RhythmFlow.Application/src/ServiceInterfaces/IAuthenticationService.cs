namespace RhythmFlow.Application.src.ServiceInterfaces
{
    public interface IAuthenticationService
    {
        // Authenticate user and return JWT token the authentication is successful
        Task<string?> AuthenticateUser(string username, string password);
    }
}