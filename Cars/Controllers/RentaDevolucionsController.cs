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
    public class RentaDevolucionsController : ControllerBase
    {
        private readonly CarsContext _context;

        public RentaDevolucionsController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/RentaDevolucions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentaDevolucion>>> GetRentaDevolucion()
        {
          if (_context.RentaDevolucion == null)
          {
              return NotFound();
          }
            return await _context.RentaDevolucion.
                Include(Renta=>Renta.Empleados)
                .Include(Renta=>Renta.Vehiculos)
                .Include(Renta=>Renta.Clientes)     
                .ToListAsync();
        }

        // GET: api/RentaDevolucions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentaDevolucion>> GetRentaDevolucion(int id)
        {
          if (_context.RentaDevolucion == null)
          {
              return NotFound();
          }
            var rentaDevolucion = await _context.RentaDevolucion.FindAsync(id);

            if (rentaDevolucion == null)
            {
                return NotFound();
            }

            return rentaDevolucion;
        }

        // PUT: api/RentaDevolucions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentaDevolucion(int id, RentaDevolucion rentaDevolucion)
        {
            if (id != rentaDevolucion.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentaDevolucion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentaDevolucionExists(id))
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

        // POST: api/RentaDevolucions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RentaDevolucion>> PostRentaDevolucion(RentaDevolucion rentaDevolucion)
        {
          if (_context.RentaDevolucion == null)
          {
              return Problem("Entity set 'CarsContext.RentaDevolucion'  is null.");
          }
            _context.RentaDevolucion.Add(rentaDevolucion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentaDevolucion", new { id = rentaDevolucion.Id }, rentaDevolucion);
        }

        // DELETE: api/RentaDevolucions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentaDevolucion(int id)
        {
            if (_context.RentaDevolucion == null)
            {
                return NotFound();
            }
            var rentaDevolucion = await _context.RentaDevolucion.FindAsync(id);
            if (rentaDevolucion == null)
            {
                return NotFound();
            }

            _context.RentaDevolucion.Remove(rentaDevolucion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RentaDevolucionExists(int id)
        {
            return (_context.RentaDevolucion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
