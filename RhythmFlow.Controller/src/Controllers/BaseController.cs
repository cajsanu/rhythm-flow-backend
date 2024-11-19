using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class BaseController<T, TReadDto, TCreateReadDto, TUpdateDto>(IBaseService<T, TReadDto, TCreateReadDto, TUpdateDto> service) : ControllerBase
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
    {
        private readonly IBaseService<T, TReadDto, TCreateReadDto, TUpdateDto> _service = service;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TReadDto>>> GetAllAsync()
        {
            var entities = await _service.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TReadDto>> GetByIdAsync(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<TReadDto>> AddAsync(T entity)
        {
            var cretedEntity = await _service.AddAsync(entity);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = cretedEntity.Id }, cretedEntity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, T updateDto)
        {
            await _service.UpdateAsync(id, updateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}