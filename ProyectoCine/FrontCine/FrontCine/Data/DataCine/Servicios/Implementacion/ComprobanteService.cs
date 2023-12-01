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
    public class ComprobanteService : IComprobanteService
    {
        public IDaoComprobantes dao;

        public ComprobanteService()
        {
            dao = new DaoComprobantes();
        }
        bool IComprobanteService.CargarComprobante(Comprobante comprobante)
        {
            return dao.CargarComprobante(comprobante);
        }

        List<TipoGenerico> IComprobanteService.ConsultarButacas(int funcionId)
        {
            return dao.ConsultarButacas(funcionId);
        }

        List<Funcion> IComprobanteService.ConsultarFunciones(DateTime fecha)
        {
            return dao.ConsultarFunciones(fecha);
        }
        List<FormaPago> IComprobanteService.ConsultarFormasPago()
        {
            return dao.ConsultarFormasPago();
        }
        List<FormaVenta> IComprobanteService.ConsultarFormasVenta()
        {
            return dao.ConsultarFormasVenta();
        }
        List<Promo> IComprobanteService.ConsultarPromos()
        {
            return dao.ConsultarPromos();
        }
        Comprobante IComprobanteService.UltimoComprobante()
        {
            return dao.UltimoComprobante();
        }

    }
}
