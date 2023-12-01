using LibreriaTp;
using Newtonsoft.Json;
using ReportesCine.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCine.Formularios
{

    public partial class PagosForm : Form
    {
        public List<Pagos> PagosList { get; set; }
        List<Pagos> PagosTemp;
        public double monto { get; set; }
        public double restante { get; set; }
        double restanteTemp;
        public ComprobanteVenta comprobanteVenta { get; set; }
        public PagosForm(double monto, List<Pagos> PagosList)
        {
            this.monto = monto;
            this.PagosList = PagosList;
            PagosTemp = new List<Pagos>();
            foreach (Pagos p in PagosList)
            {
                PagosTemp.Add(p);
            }
            InitializeComponent();
            CargarFormasPago();
            cargarDGV();
            lbl_total.Text = monto.ToString();
            restante = Restante();
        }
        private void cargarDGV()
        {
            dgv_lista.Rows.Clear();
            foreach (Pagos pagos in PagosTemp)
            {
                dgv_lista.Rows.Add(pagos.FormaPago.Nombre, pagos.Monto,"X");
            }
        }
        private double Restante()
        {
            double resta = monto;
            foreach (Pagos pagos in PagosList)
            {
                resta = resta - pagos.Monto;
            }
            lbl_restante.Text = resta.ToString();
            restante = resta;
            return resta;
        }
        private double RestanteTemp()
        {
            double resta = monto;
            foreach (Pagos pagos in PagosTemp)
            {
                resta = resta - pagos.Monto;
            }
            lbl_restante.Text =  resta.ToString("0.##");
            restanteTemp = resta;
            return resta;
        }

        private async void CargarFormasPago()
        {
            cb_fp.DataSource = await recuperarFormasPago();
            cb_fp.ValueMember = "Id";
            cb_fp.DisplayMember = "Nombre";
        }

        public async Task<List<FormaPago>> recuperarFormasPago()
        {
            string url = "https://localhost:7259/api/Comprobantes/FormasPago";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<FormaPago> lst = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            return lst;
        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RestanteTemp() - Convert.ToDouble(tb_monto.Text) >= 0)
                {
                    FormaPago fp = new FormaPago();
                    fp.Id = Convert.ToInt32(cb_fp.SelectedValue);
                    fp.Nombre = cb_fp.Text;
                    Pagos pagos = new Pagos();
                    pagos.FormaPago = fp;
                    pagos.Monto = Convert.ToDouble(tb_monto.Text);
                    dgv_lista.Rows.Add(fp.Nombre, pagos.Monto, "X");
                    PagosTemp.Add(pagos);
                    RestanteTemp();
                }
                else
                    MessageBox.Show("No se puede insertar ese monto");
            }
            catch
            {
                MessageBox.Show("No se puede insertar ese monto");
            }
        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            RestanteTemp();
            if (restanteTemp == 0)
            {
                PagosList.Clear();
                foreach (Pagos p in PagosTemp)
                {
                    PagosList.Add(p);
                }
                this.comprobanteVenta.habilitarTerminar();
                MessageBox.Show("Se completó correctamente el pago");
                this.Close();
            }
            else
                MessageBox.Show("No se completó el monto");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar?", "",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgv_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_lista.Columns["eliminar"].Index)
            {
                PagosTemp.RemoveAt(e.RowIndex);
                RestanteTemp();
                dgv_lista.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
