
using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using LibreriaTp;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesController : ControllerBase
    {

        public IComprobanteService cs;

        public ComprobantesController()
        {
            cs = new ComprobanteService();
        }

        // Put api/<ComprobanteController>
        [HttpPut]
        public bool InsertComprobante([FromBody]Comprobante comprobante)
        {
            return cs.CargarComprobante(comprobante);
        }

        // Get api/<ComprobanteController>/Funciones?Fecha=2022-10-23
        [HttpGet]
        [Route("Funciones")]
        public List<Funcion> ConsultarFunciones(string Fecha)
        {
            DateTime fecha = Convert.ToDateTime(Fecha);
            return cs.ConsultarFunciones(fecha);
        }

        // Get api/<ComprobanteController>/Butacas?ID=1
        [HttpGet("Butacas")]
        public List<TipoGenerico> ConsultarButacas(int ID)
        {
            return cs.ConsultarButacas(ID);
        }

        // Get api/<ComprobanteController>/FormasVenta
        [HttpGet]
        [Route("FormasVenta")]
        public List<FormaVenta> ObtenerFormasVenta()
        {
            return cs.ConsultarFormasVenta();
        }

        // Get api/<ComprobanteController>/FormasPago
        [HttpGet]
        [Route("FormasPago")]
        public List<FormaPago> ObtenerFormasPago()
        {
            return cs.ConsultarFormasPago();
        }

        // Get api/<ComprobanteController>/Promos
        [HttpGet]
        [Route("Promos")]
        public List<Promo> ObtenerPromos()
        {
            return cs.ConsultarPromos();
        }
        [HttpGet]
        [Route("UltimoComprobante")]
        public Comprobante UltimoComprobante()
        {
            return cs.UltimoComprobante();
        }
    }
}
