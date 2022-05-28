namespace Cars.Models
{
    public class Vehiculos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string NChasis { get; set; }
        public string NMotor { get; set; }
        public string NPlaca { get; set; }

        public int? TiposVehiculosId { get; set; }
        public TiposVehiculos TiposVehiculos { get; set; }

        public int? MarcasId { get; set; }
        public Marcas Marcas { get; set; }

        public int? ModelosId { get; set; }
        public Modelos Modelos { get; set; }
        public int? TiposCombustiblesId { get; set; }
        public TiposCombustibles TiposCombustibles { get; set; }
        public bool Estado { get; set; }




    }
}
