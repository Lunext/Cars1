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
    public class TiposVehiculosController : ControllerBase
    {
        private readonly CarsContext _context;

        public TiposVehiculosController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/TiposVehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposVehiculos>>> GetTiposVehiculos()
        {
          if (_context.TiposVehiculos == null)
          {
              return NotFound();
          }
            return await _context.TiposVehiculos.ToListAsync();
        }

        // GET: api/TiposVehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposVehiculos>> GetTiposVehiculos(int id)
        {
          if (_context.TiposVehiculos == null)
          {
              return NotFound();
          }
            var tiposVehiculos = await _context.TiposVehiculos.FindAsync(id);

            if (tiposVehiculos == null)
            {
                return NotFound();
            }

            return tiposVehiculos;
        }

        // PUT: api/TiposVehiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposVehiculos(int id, TiposVehiculos tiposVehiculos)
        {
            if (id != tiposVehiculos.Id)
            {
                return BadRequest();
            }

            _context.Entry(tiposVehiculos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposVehiculosExists(id))
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

        // POST: api/TiposVehiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiposVehiculos>> PostTiposVehiculos(TiposVehiculos tiposVehiculos)
        {
          if (_context.TiposVehiculos == null)
          {
              return Problem("Entity set 'CarsContext.TiposVehiculos'  is null.");
          }
            _context.TiposVehiculos.Add(tiposVehiculos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposVehiculos", new { id = tiposVehiculos.Id }, tiposVehiculos);
        }

        // DELETE: api/TiposVehiculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposVehiculos(int id)
        {
            if (_context.TiposVehiculos == null)
            {
                return NotFound();
            }
            var tiposVehiculos = await _context.TiposVehiculos.FindAsync(id);
            if (tiposVehiculos == null)
            {
                return NotFound();
            }

            _context.TiposVehiculos.Remove(tiposVehiculos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiposVehiculosExists(int id)
        {
            return (_context.TiposVehiculos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
