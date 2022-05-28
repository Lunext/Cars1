using Cars.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Models
{
    public class Inspeccion
    {
        public int Id { get; set; }
        public int? VehiculosId { get; set; }
        public Vehiculos Vehiculos { get; set; }

        public int? ClientesId { get; set; }
        public Clientes Clientes { get; set; }

        public bool Ralladuras { get; set; }


        [Column(TypeName = "decimal(7,2)")]
        public CantidadGasolina CantidaCombustible { get; set;}

        public bool GomaRespuesta { get; set; }

        public bool Gato { get; set; }

        public bool RoturaCristal { get; set; }

        public bool GomaDelanteraLeft { get; set; }
        public bool GomaDelanteraRight { get; set; }
        public bool GomaTraseraLeft { get; set; }

        public bool GomaTraseraRight { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public int? EmpleadosId { get; set; }
        public Empleados Empleados { get; set; }

        public bool Estado { get; set; }




       
    }
}
