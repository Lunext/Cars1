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
    public class TiposCombustiblesController : ControllerBase
    {
        private readonly CarsContext _context;

        public TiposCombustiblesController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/TiposCombustibles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposCombustibles>>> GetTiposCombustibles()
        {
          if (_context.TiposCombustibles == null)
          {
              return NotFound();
          }
            return await _context.TiposCombustibles.ToListAsync();
        }

        // GET: api/TiposCombustibles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposCombustibles>> GetTiposCombustibles(int id)
        {
          if (_context.TiposCombustibles == null)
          {
              return NotFound();
          }
            var tiposCombustibles = await _context.TiposCombustibles.FindAsync(id);

            if (tiposCombustibles == null)
            {
                return NotFound();
            }

            return tiposCombustibles;
        }

        // PUT: api/TiposCombustibles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposCombustibles(int id, TiposCombustibles tiposCombustibles)
        {
            if (id != tiposCombustibles.Id)
            {
                return BadRequest();
            }

            _context.Entry(tiposCombustibles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposCombustiblesExists(id))
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

        // POST: api/TiposCombustibles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiposCombustibles>> PostTiposCombustibles(TiposCombustibles tiposCombustibles)
        {
          if (_context.TiposCombustibles == null)
          {
              return Problem("Entity set 'CarsContext.TiposCombustibles'  is null.");
          }
            _context.TiposCombustibles.Add(tiposCombustibles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposCombustibles", new { id = tiposCombustibles.Id }, tiposCombustibles);
        }

        // DELETE: api/TiposCombustibles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposCombustibles(int id)
        {
            if (_context.TiposCombustibles == null)
            {
                return NotFound();
            }
            var tiposCombustibles = await _context.TiposCombustibles.FindAsync(id);
            if (tiposCombustibles == null)
            {
                return NotFound();
            }

            _context.TiposCombustibles.Remove(tiposCombustibles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiposCombustiblesExists(int id)
        {
            return (_context.TiposCombustibles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
