using global.Data;
using global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace global.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlertaController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alerta>>> Get() =>
            await _context.Alertas.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Alerta>> Get(int id)
        {
            var alerta = await _context.Alertas.FindAsync(id);
            return alerta == null ? NotFound() : Ok(alerta);
        }

        [HttpPost]
        public async Task<ActionResult<Alerta>> Post(Alerta alerta)
        {
            _context.Alertas.Add(alerta);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = alerta.Id }, alerta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Alerta alerta)
        {
            if (id != alerta.Id) return BadRequest();
            _context.Entry(alerta).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var alerta = await _context.Alertas.FindAsync(id);
            if (alerta == null) return NotFound();
            _context.Alertas.Remove(alerta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
