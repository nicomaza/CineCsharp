using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoComprobantes
    {
        List<Funcion> ConsultarFunciones(DateTime fecha);
        bool CargarComprobante(Comprobante comprobante);
        List<TipoGenerico> ConsultarButacas(int funcion);
        List<FormaPago> ConsultarFormasPago();
        List<FormaVenta> ConsultarFormasVenta();
        List<Promo> ConsultarPromos();
        Comprobante UltimoComprobante();
    }
}
