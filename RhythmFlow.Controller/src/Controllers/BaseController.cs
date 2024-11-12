using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    // Move IBaseService to Application layer when it is created
    public interface IBaseService<T>
    {
        Task GetAllAsync();
        Task GetByIdAsync(Guid id);
        Task AddAsync();
        Task UpdateAsync(Guid id);
        Task DeleteAsync(Guid id);
    }

    [ApiController]
    [Route("api/v1/[controller]s")]
    public class BaseController<T>(IBaseService<T> service) : ControllerBase
        where T : BaseEntity
    {

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Create()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}