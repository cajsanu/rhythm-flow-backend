using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]s")]
    public class UserController(IUserService service) : BaseController<User, UserReadDto, UserCreateDto, UserUpdateDto>(service)
    {
        [Authorize(Policy = "UserIsUserPolicy")]
        [HttpDelete("{id}")] // this part here has to match the one in base for it to work correctly (i.e HttpPut("{userId}") will not work)
        [SwaggerOperation(Summary = "Delete a User")]
        public override async Task<ActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }

        [Authorize(Policy = "UserIsUserPolicy")]
        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update a User information")]
        public override async Task<ActionResult> Update(Guid id, [FromBody] UserUpdateDto updateDto)
        {
            return await base.Update(id, updateDto);
        }

        [AllowAnonymous]
        [SwaggerOperation(Summary = "Create a new User")]
        public override async Task<ActionResult<UserReadDto>> Add([FromBody] UserCreateDto entity)
        {
            return await base.Add(entity);
        }
    }
}