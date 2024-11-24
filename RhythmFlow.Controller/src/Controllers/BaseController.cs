using System.ComponentModel.DataAnnotations;
using System.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.ServiceInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Controller.src.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/workspaces/{workspaceId}/[controller]s")]
    public class BaseController<T, TReadDto, TCreateDto, TUpdateDto>(IBaseService<T, TReadDto, TCreateDto, TUpdateDto> service) : ControllerBase
        where T : BaseEntity
        where TReadDto : IBaseReadDto<T>
        where TUpdateDto : IBaseUpdateDto<T>
        where TCreateDto : IBaseCreateDto<T>
    {
        // Read more here: https://stackoverflow.com/questions/39459348/asp-net-core-web-api-no-route-matches-the-supplied-values
        // ASP automatically removes the Async from action name by default so we should avoid naming functions in controller with suffix Async to avoid 3am confusions
        private readonly IBaseService<T, TReadDto, TCreateDto, TUpdateDto> _service = service;

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TReadDto>>> GetAll()
        {
            var entities = await _service.GetAllAsync();
            return Ok(entities);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<TReadDto>> GetById(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            return Ok(entity);
        }

        [AllowAnonymous]
        [HttpPost]
        public virtual async Task<ActionResult<TReadDto>> Add([FromBody] TCreateDto entity, Guid workspaceId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdEntity = await _service.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id, workspaceId }, createdEntity);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update(Guid id, [FromBody] TUpdateDto updateDto)
        {
            await _service.UpdateAsync(id, updateDto.ToEntity(id));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}