using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using LibreriaTp;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private IPeliculasService service;

        public PeliculasController()
        {
            service = new PeliculaService();
        }
        // GET: api/<PeliculasController>
        [HttpGet]
        [Route("Generos")]
        public IActionResult GetGeneros()
        {
            return Ok(service.ObtenerGeneros());
        }

        [HttpGet]
        [Route("Directores")]
        public IActionResult GetDirectores()
        {
            return Ok(service.ObtenerDirectores());
        }

        [HttpGet]
        [Route("Paises")]
        public IActionResult GetPaises()
        {
            return Ok(service.ObtenerPaises());
        }

        [HttpGet]
        [Route("Clasificacion")]
        public IActionResult GetClasificacion()
        {
            return Ok(service.ObtenerClasificaciones());
        }

        [HttpGet]
        [Route("Distribuidora")]
        public IActionResult GetDistribuidora()
        {
            return Ok(service.ObtenerDistribuidora());
        }

        [HttpGet]
        [Route("Peliculas")]
        public IActionResult GetPeliculas()
        {
            return Ok(service.ObtenerPeliculas());
        }

        [HttpGet("{titulo}")]   
        public IActionResult GerPeliculasFiltradas(string titulo)
        {
            return Ok(service.FiltrarPeliculas(titulo));
        }


        // POST api/<PeliculasController>
        [HttpPost("/pelicula")]
        public IActionResult PostPeliculas(Pelicula pelicula)
        {
            try
            {
                if (pelicula == null)
                    return BadRequest("Datos de la pelicula Incorrectos");

                return Ok(service.CargarPelicula(pelicula));
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        // PUT api/<PeliculasController>/5
        [HttpPut("/pelicula")]
        public IActionResult PutPelicula(Pelicula oPelicula)
        {
            try
            {
                if (oPelicula == null)
                    BadRequest("Ha ocurrido un error");
                return Ok(service.ModificarPelicula(oPelicula));
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        // DELETE api/<PeliculasController>/5
        [HttpPatch("{id}, {baja}")]
        public IActionResult AccionesPeliculas(int id, int baja)
        {
            try
            {
                if (id == null)
                    return BadRequest("Datos de la pelicula Incorrectos");

                return Ok(service.AccionesPeliculas(id, baja));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

       

    }
}
