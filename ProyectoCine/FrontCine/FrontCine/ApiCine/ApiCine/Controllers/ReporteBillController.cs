using DataCine.Dominio;
using DataCine.Servicios.Implementacion;
using Microsoft.AspNetCore.Mvc;
using DataCine.Servicios.Interfaces;
using DataCine.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteBillController : ControllerBase
    {
        private IService oservicio;
        
        public ReporteBillController()
        {
            oservicio = new FactoryImplement().crearservicio();
        }
        //// GET: api/<ReporteBillController>
        //[HttpPost("bills")]
        //public IActionResult Postfacturas([FromBody]List<Parametro> param)
        //{
        //    if (param == null)
        //        return BadRequest("Ingrese fechas o forma venta");
        //    return Ok(oservicio.traertablabill(param));
        //}
        [HttpPost("bills")]
        public IActionResult Postfacturasprueba([FromBody] ParametroConsultaBill parame)
        {
            if (parame == null)
                return BadRequest("Ingrese fechas o forma venta");
            return Ok(oservicio.traertablabill(parame));
        }

        // GET api/<ReporteBillController>/5
        [HttpGet("formadepagos")]
        public IActionResult GetFormaspago()
        {
          
            return Ok(oservicio.traerformaspago());
        }

        // POST api/<ReporteBillController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReporteBillController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReporteBillController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
