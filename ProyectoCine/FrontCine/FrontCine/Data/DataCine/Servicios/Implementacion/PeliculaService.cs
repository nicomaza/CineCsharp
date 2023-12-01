using DataCine.Datos.Implementaciones;
using DataCine.Datos.Interfaces;
using DataCine.Servicios.Interfaces;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Implementacion
{
    public class PeliculaService : IPeliculasService
    {
        private IDaoPeliculas oDao;

        public PeliculaService()
        {
            oDao = new DaoPeliculas();
        }

        public List<Distribuidora> ObtenerDistribuidora()
        {
            return oDao.CargarDistribuidora();
        }

        public List<Clasificacion> ObtenerClasificaciones()
        {
            return oDao.ObtenerClasificaciones();
        }

        public List<Director> ObtenerDirectores()
        {
            return oDao.ObtenerDirectores();
        }

        public List<Genero> ObtenerGeneros()
        {
            return oDao.ObtenerGeneros();
        }

        public List<Pais> ObtenerPaises()
        {
            return oDao.ObtenerPaises();
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return oDao.ObtenerPeliculas("SP_CONSULTA_PELICULAS_TODO");
        }

        public List<Pelicula> FiltrarPeliculas(string titulo)
        {
            return oDao.FiltrarPeliculas(titulo);
        }

        public bool CargarPelicula(Pelicula oPelicula)
        {
            return oDao.CargarPelicula(oPelicula);
        }

        public bool AccionesPeliculas(int id, int baja)
        {
            return oDao.Acciones(id, baja);
        }

        public bool ModificarPelicula(Pelicula oPelicula)
        {
            return oDao.ModificarPelicula(oPelicula);
        }


    }
}
