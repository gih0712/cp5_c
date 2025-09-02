using global.Data;
using global.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace global.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SensoresController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sensor>>> Get()
        {
            return await _context.Sensores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sensor>> Get(int id)
        {
            var sensor = await _context.Sensores.FindAsync(id);
            if (sensor == null)
                return NotFound();
            return Ok(sensor);
        }

        [HttpPost]
        public async Task<ActionResult<Sensor>> Post(Sensor sensor)
        {
            _context.Sensores.Add(sensor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = sensor.IdSensor }, sensor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Sensor sensor)
        {
            if (id != sensor.IdSensor)
                return BadRequest();

            _context.Entry(sensor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sensor = await _context.Sensores.FindAsync(id);
            if (sensor == null)
                return NotFound();

            _context.Sensores.Remove(sensor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
