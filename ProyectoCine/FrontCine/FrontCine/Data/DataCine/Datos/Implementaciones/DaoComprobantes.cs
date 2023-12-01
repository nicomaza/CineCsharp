using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    public class DaoComprobantes : IDaoComprobantes
    {
        bool IDaoComprobantes.CargarComprobante(Comprobante comprobante)
        {
            return HelperDAO.getinstancia().altaComprobante(comprobante);
        }

        List<TipoGenerico> IDaoComprobantes.ConsultarButacas(int funcionID)
        {
            List<TipoGenerico> butacasOcupadas = new List<TipoGenerico>();
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@id_funcion", funcionID));
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_FUNCION", lista_parametros);
            foreach (DataRow row in dt.Rows)
            {
                TipoGenerico tipoGenerico = new TipoGenerico();
                tipoGenerico.ID = Convert.ToInt32(row["id_butaca"]).ToString();
                tipoGenerico.Nombre = row["nro_ticket"].ToString();
                butacasOcupadas.Add(tipoGenerico);
            }
            return butacasOcupadas;
        }

        List<FormaPago> IDaoComprobantes.ConsultarFormasPago()
        {
            List<FormaPago> formaPagos = new List<FormaPago>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_FORMAS_PAGO");
            foreach (DataRow row in dt.Rows)
            {
                FormaPago formaPago = new FormaPago();
                formaPago.Id=Convert.ToInt32(row["id_forma_pago"]);
                formaPago.Nombre = row["descripcion"].ToString();
                formaPagos.Add(formaPago);
            }
                return formaPagos;
        }

        List<FormaVenta> IDaoComprobantes.ConsultarFormasVenta()
        {
            List<FormaVenta> formaVentas = new List<FormaVenta>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_FORMAS_VENTA");
            foreach (DataRow row in dt.Rows)
            {
                FormaVenta formaVenta = new FormaVenta();
                formaVenta.Id = Convert.ToInt32(row["id_forma_venta"]);
                formaVenta.Nombre = row["descripcion"].ToString();
                formaVentas.Add(formaVenta);
            }
            return formaVentas;
        }

        List<Funcion> IDaoComprobantes.ConsultarFunciones(DateTime fecha)
        {
            List<Funcion> funciones = new List<Funcion>();
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@fecha", fecha.ToString("yyyy-MM-dd")));
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_FUNCIONES_FECHA", lista_parametros);

            foreach (DataRow row in dt.Rows)
            {
                Funcion funcion_nueva = new Funcion();
                funcion_nueva.Id = Convert.ToInt32(row["id_funcion"]);
                funcion_nueva.Pelicula.Id = Convert.ToInt32(row["id_pelicula"]);
                funcion_nueva.Pelicula.Titulo_local = row["nombre_pelicula"].ToString();
                funcion_nueva.Horario.Id = Convert.ToInt32(row["id_horario"]);
                funcion_nueva.Horario.Nombre = row["horario"].ToString();
                funcion_nueva.Audio.Id = Convert.ToInt32(row["id_audio"]);
                funcion_nueva.Audio.Nombre = row["audio"].ToString();
                funcion_nueva.Sala.Id = Convert.ToInt32(row["id_sala"]);
                funcion_nueva.Sala.Nombre = row["sala"].ToString();
                funcion_nueva.Precio = Convert.ToInt32(row["precio"]);
                funcion_nueva.fecha = Convert.ToDateTime(row["fecha"]);
                funciones.Add(funcion_nueva);
            }
            return funciones;
        }

        List<Promo> IDaoComprobantes.ConsultarPromos()
        {
            List<Promo> promoList = new List<Promo>();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_PROMOS");
            foreach (DataRow row in dt.Rows)
            {
                Promo promo = new Promo();
                promo.Id = Convert.ToInt32(row["id_promo"]);
                promo.Descripcion = row["descripcion"].ToString();
                promo.Porcentaje = Convert.ToInt32(row["porcentaje"]);
                promoList.Add(promo);
            }
            return promoList;
        }
        Comprobante IDaoComprobantes.UltimoComprobante()
        {
            Comprobante comprobante = new Comprobante();
            DataTable dt = HelperDAO.getinstancia().ConsultarDB("SP_ULTIMO_COMPROBANTE");
            foreach (DataRow row in dt.Rows)
            {
                comprobante.Id = Convert.ToInt32(row["id_promo"]);
            }
            return comprobante;
        }
    }
}
