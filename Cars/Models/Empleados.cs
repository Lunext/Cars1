using Cars.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public TandaLaboral TandaLabor { get; set;}

        public double PorcientoComision { get; set;}

        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }

        public bool  Estado { get; set; }


    }
}
