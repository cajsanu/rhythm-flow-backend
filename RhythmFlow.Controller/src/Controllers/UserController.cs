using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    public class UserController(IBaseService<User> service) : BaseController<User>(service)
    {
    }
}