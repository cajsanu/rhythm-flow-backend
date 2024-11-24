using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]s")]
    public class UserController(IUserService service) : BaseController<User, UserReadDto, UserCreateDto, UserUpdateDto>(service)
    {

        [AllowAnonymous]
        public override async Task<ActionResult<UserReadDto>> Add([FromBody] UserCreateDto entity, Guid workspaceId)
        {
            return await base.Add(entity, workspaceId);
        }
    }
}