namespace Cars.Models
{
    public class Modelos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } 
        public bool Estado { get; set; }

        public int? MarcasId { get; set; }
        public Marcas Marcas { get; set; }



    }
}
