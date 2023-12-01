using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Interfaces
{
    public interface IPeliculasService
    {
        List<Pais> ObtenerPaises();
        List<Clasificacion> ObtenerClasificaciones();
        List<Distribuidora> ObtenerDistribuidora();
        List<Genero> ObtenerGeneros();
        List<Director> ObtenerDirectores();
        List<Pelicula> ObtenerPeliculas();
        List<Pelicula> FiltrarPeliculas(string titulo);
        bool CargarPelicula(Pelicula oPelicula);
        bool AccionesPeliculas(int id,int baja);
        bool ModificarPelicula(Pelicula oPelicula);


    }
}
