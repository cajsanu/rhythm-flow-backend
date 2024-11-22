using Microsoft.AspNetCore.Authorization;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    public class UserController(IUserService service) : BaseController<User, UserReadDto, UserCreateDto, UserUpdateDto>(service)
    {
    }
}