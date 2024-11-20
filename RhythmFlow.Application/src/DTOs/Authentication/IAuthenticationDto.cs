using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Authentication;
public interface IAuthenticationDto
{
    Email Email { get; set; }
    string Password { get; set; }
}