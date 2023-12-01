using DataCine.ClasesGenericas;
using DataCine.Servicios;
using DataCine.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CineController : ControllerBase
    {
        private IService oservicio;
        public CineController()
        {
            oservicio = new FactoryImplement().crearservicio();
        }
        // GET: api/<Cinereport>
        [HttpGet("traerticketporsala")]
        public IActionResult Getticketxsala()
        {
            return Ok(oservicio.traerticketsxsala());
        }

        // GET api/<CineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
