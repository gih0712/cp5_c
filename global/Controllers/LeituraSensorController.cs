using global.Data;
using global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace global.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeituraSensorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeituraSensorController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeituraSensor>>> Get() =>
            await _context.LeituraSensores.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<LeituraSensor>> Get(int id)
        {
            var leitura = await _context.LeituraSensores.FindAsync(id);
            return leitura == null ? NotFound() : Ok(leitura);
        }

        [HttpPost]
        public async Task<ActionResult<LeituraSensor>> Post(LeituraSensor leitura)
        {
            _context.LeituraSensores.Add(leitura);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = leitura.Id }, leitura);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, LeituraSensor leitura)
        {
            if (id != leitura.Id) return BadRequest();

            _context.Entry(leitura).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var leitura = await _context.LeituraSensores.FindAsync(id);
            if (leitura == null) return NotFound();

            _context.LeituraSensores.Remove(leitura);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
