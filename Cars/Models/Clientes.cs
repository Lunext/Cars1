using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        
        public string Cedula { get; set; }

        public string TarjCredito { get; set; }


        [Column(TypeName = "decimal(7,2)")]
        public decimal LimitCredito { get; set;}

        public string TipoPersona { get; set; }

        public bool Estado { get; set;}




    }
}
