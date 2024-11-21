using System.ComponentModel.DataAnnotations;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Authentication
{
    public class AuthenticationDto : IAuthenticationDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}