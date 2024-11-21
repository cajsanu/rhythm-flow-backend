using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Authentication;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService = authenticationService;

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] AuthenticationDto authenticationDto)
        {
            var token = await _authenticationService.AuthenticateUserAsync(authenticationDto.Email, authenticationDto.Password);
            return Ok(token);
        }
    }
}