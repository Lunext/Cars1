using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models
{
    public class RentaDevolucion
    {
       public int Id { get; set;}
       public int Renta { get; set;}

       public int EmpleadosId { get; set;}
       
       public Empleados? Empleados { get; set;}

        
       public int? VehiculosId { get; set; }
       
       public Vehiculos Vehiculos { get; set;}
        
       public int? ClientesId { get; set;}

       
       public Clientes Clientes { get; set;}

        [DataType(DataType.Date)]
        public DateTime FechaRenta { get; set;}


        [DataType(DataType.Date)]
        public DateTime FechaDevolucion { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal MontoDia { get; set;}

        public int CantidadDias { get; set;}

        public string Comentario { get; set;}

        public bool Estado { get; set; }



    }
}
