using LibreriaTp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCine.Formularios.Reportes
{
    public partial class ReporteComprobante : Form
    {
        Comprobante comprobante = new Comprobante();
        public ReporteComprobante(Comprobante comprob)
        {
            InitializeComponent();
            this.comprobante = comprob;
        }
        DataTable pagostabla = new DataTable();
        DataTable comprobantetabla = new DataTable();
        DataTable ticketstabla = new DataTable();


        private void ReporteComprobante_Load(object sender, EventArgs e)
        {
            //CARGA TABLA DE DETALLES DE PAGOS

            pagostabla.Columns.Add("FormaPago", typeof(string));
            pagostabla.Columns.Add("Monto",typeof(double));
            foreach(Pagos c in comprobante.ListaPagos)
            {
                pagostabla.Rows.Add(c.FormaPago.Nombre, c.Monto);
            }

            comprobantetabla.Columns.Add("Id", typeof(int));
            comprobantetabla.Columns.Add("FormaVenta", typeof(string));
            comprobantetabla.Columns.Add("Fecha",typeof(DateTime));

            comprobantetabla.Rows.Add(comprobante.Id,comprobante.FormaVenta.Nombre,comprobante.Fecha);

            //CARGA TABLA DE DETALLE DE TICKETS
            ticketstabla.Columns.Add("Id");
            ticketstabla.Columns.Add("Pelicula");
            ticketstabla.Columns.Add("Horario");
            ticketstabla.Columns.Add("Promo");
            ticketstabla.Columns.Add("Importe",typeof(double));
            ticketstabla.Columns.Add("Porcentaje");

            foreach(Ticket t in comprobante.ltickets)
            {
                ticketstabla.Rows.Add(t.NroTicket,t.Funcion.Pelicula.Titulo_local,t.Funcion.Horario.Nombre,t.Promo.Descripcion,t.Funcion.Precio,t.Promo.Porcentaje);
            }
            


            reportViewercompro.LocalReport.DataSources.Clear();
            reportViewercompro.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",pagostabla));
            reportViewercompro.LocalReport.DataSources.Add(new ReportDataSource("DataSet2",comprobantetabla));
            reportViewercompro.LocalReport.DataSources.Add(new ReportDataSource("DataSet3",ticketstabla));
            reportViewercompro.LocalReport.ReportEmbeddedResource = "FrontCine.Comprobante.rdlc";
            reportViewercompro.RefreshReport();
        }


               private void reportViewercompro_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
