using Microsoft.AspNetCore.Mvc;
using PersonasApi.Interfaces;
using PersonasApi.Models;

namespace PersonasApi.Controllers
{
    [ApiController]
    [Route("api/personas")]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaService _service;

        public PersonasController(IPersonaService service)
        {
            _service = service;
        }

        // GET: api/personas
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        // GET: api/personas/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var persona = await _service.GetById(id);
            if (persona == null)
                return NotFound();

            return Ok(persona);
        }

        // POST: api/personas
        [HttpPost]
        public async Task<IActionResult> Create(Persona persona)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var nuevaPersona = await _service.Create(persona);
            return CreatedAtAction(nameof(GetById), new { id = nuevaPersona.Id }, nuevaPersona);
        }

        // PUT: api/personas/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Persona persona)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updated = await _service.Update(id, persona);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/personas/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }

        // GET: api/personas/buscar?texto=juan
        [HttpGet("buscar")]
        public async Task<IActionResult> Buscar([FromQuery] string texto)
        {
            return Ok(await _service.Search(texto));
        }
    }
}
