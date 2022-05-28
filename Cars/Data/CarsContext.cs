using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cars.Models;
using Cars.Entities;

namespace Cars.Data
{
    public class CarsContext : DbContext
    {
        public CarsContext (DbContextOptions<CarsContext> options)
            : base(options)
        {
        }

        public DbSet<Cars.Models.TiposVehiculos>? TiposVehiculos { get; set; }

        public DbSet<Cars.Models.Marcas>? Marcas { get; set; }

        public DbSet<Cars.Models.Modelos>? Modelos { get; set; }

        public DbSet<Cars.Models.TiposCombustibles>? TiposCombustibles { get; set; }

        public DbSet<Cars.Models.Vehiculos>? Vehiculos { get; set; }

        public DbSet<Cars.Models.Clientes>? Clientes { get; set; }

        public DbSet<Cars.Models.Empleados>? Empleados { get; set; }

        public DbSet<Cars.Models.Inspeccion>? Inspeccion { get; set; }

        public DbSet<Cars.Models.RentaDevolucion>? RentaDevolucion { get; set; }

      //  public DbSet<Cars.Entities.User>? User { get; set; }
       public DbSet<User> Users { get; set; }
    }
}
