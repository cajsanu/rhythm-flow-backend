using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class BaseController<T, TReadDto, TCreateDto, TUpdateDto>(IBaseService<T, TReadDto, TCreateDto, TUpdateDto> service) : ControllerBase
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
        where TUpdateDto : IBaseUpdateDto<T>
        where TCreateDto : IBaseCreateDto<T>
    {
        private readonly IBaseService<T, TReadDto, TCreateDto, TUpdateDto> _service = service;

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
            await _service.UpdateAsync(id, updateDto.ToEntity(id));
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