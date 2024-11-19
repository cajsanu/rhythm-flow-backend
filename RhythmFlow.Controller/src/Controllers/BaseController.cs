using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class BaseController<T, TReadDto, TUpdateDto, TCreateDto>(IBaseService<T, TReadDto> service) : ControllerBase
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
        where TUpdateDto : IBaseUpdateDto<T>
        where TCreateDto : IBaseCreateDto<T>
    {
        // Read more here: https://stackoverflow.com/questions/39459348/asp-net-core-web-api-no-route-matches-the-supplied-values
        // ASP automatically removes the Async from action name by default so we should avoid naming functions in controller with suffix Async to avoid 3am confusions
        private readonly IBaseService<T, TReadDto> _service = service;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TReadDto>>> GetAll()
        {
            var entities = await _service.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TReadDto>> GetById(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<TReadDto>> Add([FromBody] TCreateDto entity)
        {
            Console.WriteLine(entity);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdEntity = await _service.AddAsync(entity.ToEntity());
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id }, createdEntity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] TUpdateDto updateDto)
        {
            await _service.UpdateAsync(id, updateDto.ToEntity());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}