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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InspeccionsController : ControllerBase
    {
        private readonly CarsContext _context;

        public InspeccionsController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/Inspeccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inspeccion>>> GetInspeccion()
        {
          if (_context.Inspeccion == null)
          {
              return NotFound();
          }
            return await _context.Inspeccion
                .Include(Inspeccion=>Inspeccion.Clientes)
                .Include(Inspeccion=>Inspeccion.Empleados)
                .Include(Inspeccion=>Inspeccion.Vehiculos)
                .ToListAsync();
        }

        // GET: api/Inspeccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inspeccion>> GetInspeccion(int id)
        {
          if (_context.Inspeccion == null)
          {
              return NotFound();
          }
            var inspeccion = await _context.Inspeccion.FindAsync(id);

            if (inspeccion == null)
            {
                return NotFound();
            }

            return inspeccion;
        }

        // PUT: api/Inspeccions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInspeccion(int id, Inspeccion inspeccion)
        {
            if (id != inspeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(inspeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspeccionExists(id))
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

        // POST: api/Inspeccions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inspeccion>> PostInspeccion(Inspeccion inspeccion)
        {
          if (_context.Inspeccion == null)
          {
              return Problem("Entity set 'CarsContext.Inspeccion'  is null.");
          }
            _context.Inspeccion.Add(inspeccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInspeccion", new { id = inspeccion.Id }, inspeccion);
        }

        // DELETE: api/Inspeccions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspeccion(int id)
        {
            if (_context.Inspeccion == null)
            {
                return NotFound();
            }
            var inspeccion = await _context.Inspeccion.FindAsync(id);
            if (inspeccion == null)
            {
                return NotFound();
            }

            _context.Inspeccion.Remove(inspeccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InspeccionExists(int id)
        {
            return (_context.Inspeccion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
