using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService = authenticationService;

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] Email email, [FromBody] string password)
        {
            var token = await _authenticationService.AuthenticateUserAsync(email, password);
            return Ok(token);
        }
    }
}