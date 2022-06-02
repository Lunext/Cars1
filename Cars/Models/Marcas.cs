namespace Cars.Models
{
    public class Marcas
    {
        public int Id { get; set; } 
        public string Descripcion { get; set; } 
        public bool Estado { get; set; }

        public static implicit operator List<object>(Marcas v)
        {
            throw new NotImplementedException();
        }
    }
}
