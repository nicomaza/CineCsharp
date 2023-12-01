using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCine.ClasesGenericas;
using DataCine.Datos;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using ReportesCine.Cliente;

namespace FrontCine.Formularios.Reportes
{
    public partial class ReporteForm : Form
    {
        public ReporteForm()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        List<TIcketxSala> list = new List<TIcketxSala>();    
        private async void ReporteForm_Load(object sender, EventArgs e)
        {



            await cargardatatable();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",dt));
            reportViewer1.LocalReport.ReportEmbeddedResource = "FrontCine.Report1.rdlc";
            reportViewer1.RefreshReport();
        }

        private async Task cargarticketxsalasync()
        {
            string url = "https://localhost:7259/api/Cine/traerticketporsala";
            var resultado = await ClienteSingleton.getinstancia().GetAsync(url);
            list = await Task.Run(() => JsonConvert.DeserializeObject<List<TIcketxSala>>(resultado));
         
        }

        public async Task cargardatatable()
        {
            await cargarticketxsalasync();
            
            //dt = HelperDAO.getinstancia().traertablacomun("select * from v_cantidadentradathisyear");
            dt.Columns.Add("Tickets", typeof(Int32));
            dt.Columns.Add("Sala", typeof(string));

            foreach (TIcketxSala t in list)
            {
                dt.Rows.Add(t.tickets, t.sala);

            }
        }
    }
}
