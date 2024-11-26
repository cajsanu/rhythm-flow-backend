using System.ComponentModel.DataAnnotations;

namespace RhythmFlow.Application.src.DTOs.Authentication
{
    public class AuthenticationDto : IAuthenticationDto
    {
        [Required]
        required public string Email { get; set; }
        [Required]
        required public string Password { get; set; }
    }
}