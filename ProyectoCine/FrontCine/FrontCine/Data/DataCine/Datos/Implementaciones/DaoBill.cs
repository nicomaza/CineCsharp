using DataCine.ClasesGenericas;
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
    internal class DaoBill : IDaobill
    {
        public List<facturabill> consultarfacturas(ParametroConsultaBill parame)
        {
            List<facturabill> facturas = new List<facturabill>();
            List<Parametro> parametros = new List<Parametro>();

            Parametro inicio = new Parametro();
            inicio.Name = "@fechainicio";
            inicio.Value = parame.fechainicio;

            Parametro fin = new Parametro();
            fin.Name = "@fechafin";
            fin.Value = parame.fechafin;

            parametros.Add(inicio);
            parametros.Add(fin);
           

            DataTable consulta = new DataTable();
            consulta = HelperDAO.getinstancia().ConsultarDB("SP_MontosTotalesComprobantes", parametros);

            foreach (DataRow fila in consulta.Rows)
            {
                facturabill factura = new facturabill();
                factura.Forma_Pago = fila["Forma_Pago"].ToString();
                factura.Cantidad_Comprobantes = Convert.ToInt32(fila["Cantidad_Comprobantes"].ToString());
                factura.Importes = Convert.ToInt32(fila["Importes"].ToString());
                facturas.Add(factura);
            }


            return facturas;
        }

        public List<FormaPago> traerformaPagos()
        {
            
            
                List<FormaPago> lformapagos = new List<FormaPago>();
            DataTable dt = HelperDAO.getinstancia().traertablacomun("select * from Formas_pago");

                foreach (DataRow row in dt.Rows)
                {
                    FormaPago formapago = new FormaPago();
                    formapago.Id = Convert.ToInt32(row[0].ToString());
                    formapago.Nombre = row[1].ToString();
                    lformapagos.Add(formapago);
                }
                return lformapagos;
            
        }
    }
}
