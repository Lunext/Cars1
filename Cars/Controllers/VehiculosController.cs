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
    public class VehiculosController : ControllerBase
    {
        private readonly CarsContext _context;

        public VehiculosController(CarsContext context)
        {
            _context = context;

           
            
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculos>>> GetVehiculos()
        {
          if (_context.Vehiculos == null)
          {
              return NotFound();
          }

            return await _context.Vehiculos.
                Include(vehiculo => vehiculo.Modelos)
                .Include(vehiculo => vehiculo.Marcas)
                .Include(vehiculo => vehiculo.TiposVehiculos)
                .Include(vehiculo => vehiculo.TiposCombustibles).
                ToListAsync();
        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculos>> GetVehiculos(int id)
        {
           
          if (_context.Vehiculos == null)
          {
              return NotFound();
          }
            var vehiculos = await _context.Vehiculos.FindAsync(id);

            if (vehiculos == null)
            {
                return NotFound();
            }

            return vehiculos;
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculos(int id, Vehiculos vehiculos)
        {
            if (id != vehiculos.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehiculos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculosExists(id))
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

        // POST: api/Vehiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehiculos>> PostVehiculos(Vehiculos vehiculos)
        {
          if (_context.Vehiculos == null)
          {
              return Problem("Entity set 'CarsContext.Vehiculos'  is null.");
          }
            _context.Vehiculos.Add(vehiculos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculos", new { id = vehiculos.Id }, vehiculos);
        }

        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculos(int id)
        {
            if (_context.Vehiculos == null)
            {
                return NotFound();
            }
            var vehiculos = await _context.Vehiculos.FindAsync(id);
            if (vehiculos == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(vehiculos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehiculosExists(int id)
        {
            return (_context.Vehiculos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        

    }
}
