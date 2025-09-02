using global.Data;
using global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace global.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrevisaoTempoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PrevisaoTempoController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrevisaoTempo>>> Get() =>
            await _context.Previsoes.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<PrevisaoTempo>> Get(int id)
        {
            var previsao = await _context.Previsoes.FindAsync(id);
            return previsao == null ? NotFound() : Ok(previsao);
        }

        [HttpPost]
        public async Task<ActionResult<PrevisaoTempo>> Post(PrevisaoTempo previsao)
        {
            _context.Previsoes.Add(previsao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = previsao.Id }, previsao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PrevisaoTempo previsao)
        {
            if (id != previsao.Id) return BadRequest();
            _context.Entry(previsao).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var previsao = await _context.Previsoes.FindAsync(id);
            if (previsao == null) return NotFound();
            _context.Previsoes.Remove(previsao);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
