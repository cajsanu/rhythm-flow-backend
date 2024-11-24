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
        [Authorize(Policy = "UserIsUserPolicy")]
        [HttpDelete("{userId}")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [Authorize(Policy = "UserIsUserPolicy")]
        [HttpPut("{userId}")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] UserUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }
    }
}