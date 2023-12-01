
namespace LibreriaTp
{
    public class Funcion
    {

        public int Id { get; set; }
        public Pelicula Pelicula { get; set; }
        public Horario Horario { get; set; }
        public Audio Audio { get; set; }
        public Sala Sala {get; set;}
        public double Precio { get; set; }
        public DateTime fecha { get; set; }
        public int Estado { get; set; }
        public DateTime fecha_baja { get; set; }

        public Funcion()
        {
            Pelicula = new Pelicula();  
            Horario = new Horario();        
            Audio = new Audio();
            Sala = new Sala();
        }
    }
}
