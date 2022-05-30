using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cars.Data;
using Cars.Models;
using Cars.Authorization;

namespace Cars.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private readonly CarsContext _context;

        public ModelosController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/Modelos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modelos>>> GetModelos()
        {
          if (_context.Modelos == null)
          {
              return NotFound();
          }
            return await _context.Modelos.ToListAsync();
        }

        // GET: api/Modelos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modelos>> GetModelos(int id)
        {
          if (_context.Modelos == null)
          {
              return NotFound();
          }
            var modelos = await _context.Modelos.FindAsync(id);

            if (modelos == null)
            {
                return NotFound();
            }

            return modelos;
        }

        // PUT: api/Modelos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModelos(int id, Modelos modelos)
        {
            if (id != modelos.Id)
            {
                return BadRequest();
            }

            _context.Entry(modelos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Modelos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Modelos>> PostModelos(Modelos modelos)
        {
          if (_context.Modelos == null)
          {
              return Problem("Entity set 'CarsContext.Modelos'  is null.");
          }
            _context.Modelos.Add(modelos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModelos", new { id = modelos.Id }, modelos);
        }

        // DELETE: api/Modelos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModelos(int id)
        {
            if (_context.Modelos == null)
            {
                return NotFound();
            }
            var modelos = await _context.Modelos.FindAsync(id);
            if (modelos == null)
            {
                return NotFound();
            }

            _context.Modelos.Remove(modelos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModelosExists(int id)
        {
            return (_context.Modelos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
