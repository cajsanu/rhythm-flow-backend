using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Application.src.ServiceInterfaces;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class BaseController<T>(IBaseService<T> service) : ControllerBase
        where T : BaseEntity
    {
        private readonly IBaseService<T> _service = service;

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}