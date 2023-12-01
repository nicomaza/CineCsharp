namespace LibreriaTp
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo_local { get; set; }
        public string Titulo_original { get; set; }
        public string Descripcion { get; set; }
        public Pais pais { get; set; }
        public Clasificacion clasificacion { get; set; }
        public DateTime Fecha_Estreno { get; set; }
        public int duracion { get; set; }
        public Distribuidora distribuidora { get; set; }
        public Genero genero { get; set; }
        public Director director { get; set; }
        public DateTime fecha_baja { get; set; }
        public int Baja { get; set; }
    }
}
