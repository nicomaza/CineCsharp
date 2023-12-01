using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLab.datos;

namespace TpLab.Salva
{
    public partial class ConsultaComprobante : Form
    {

        string query; 

        public ConsultaComprobante()
        {
            InitializeComponent();
            query = string.Empty;
        }

        private void ConsultaComprobante_Load(object sender, EventArgs e)
        {
            Inicializar();            
        }

        private void CargarLista()
        {
            dgvComprobante.Rows.Clear();

            DataTable dtG = Consultas.consultarTabla(query);

            foreach (DataRow row in dtG.Rows)
            {
                int cpbNum = Convert.ToInt32(row[0]);
                DateTime Fecha = Convert.ToDateTime( row[1].ToString());
                string fechaFormat = Fecha.Day+"/"+Fecha.Month + "/"+Fecha.Year;
                String f_pago;
                switch (row[2].ToString())
                {
                    case "1":
                        f_pago = "Recepcion";
                        break;
                    case "2":
                        f_pago = "Internet";
                        break;
                    case "3":
                        f_pago = "Sorteo";
                        break;
                    default:
                        f_pago = "-";
                        break;
                }
                double precio = Convert.ToDouble(row[3]);

                dgvComprobante.Rows.Add(cpbNum.ToString(),fechaFormat,f_pago,precio.ToString());
                
            }


            

        }

        #region MetodosPropios

        private void CargarCombo()
        {
            DataTable dt = Consultas.consultarTabla("select * from Formas_venta");
            cbFormaVenta.DataSource = dt;
            cbFormaVenta.DisplayMember = dt.Columns[1].ColumnName;
            cbFormaVenta.ValueMember = dt.Columns[0].ColumnName;

        }

        private void Inicializar()
        {
            SetQuery();
            CargarCombo();
            CargarLista();
            for (int i = 0; i < dgvComprobante.Columns.Count; i++)
            {
                dgvComprobante.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void Filtrar()
        {
                query = "select c.id_comprobante 'Comprobante Num.',c.fecha 'Fecha',c.id_forma_venta 'Forma Venta',sum(f.precio*p.porcentaje/100) 'Precio' " +
                                "from tickets t join Comprobantes c on t.id_comprobante = c.id_comprobante " +
                                "join Promos p on t.id_promo=p.id_promo " +
                                "join Funciones f on t.id_funcion = f.id_funcion " +
                                "WHERE c.fecha between '" + dtpDesde.Value.ToString("yyyy/MM/dd") + "' and '" + dtpHasta.Value.ToString("yyyy/MM/dd") + "' "+
                                "and c.id_forma_venta = " + cbFormaVenta.SelectedValue.ToString()+
                                " group by c.id_comprobante,c.fecha,c.id_forma_venta order by 1";
      
            CargarLista();
        }

        private void SetQuery()
        {
            query = "select c.id_comprobante 'Comprobante Num.',c.fecha 'Fecha',c.id_forma_venta 'Forma Venta',sum(f.precio*p.porcentaje/100) 'Precio' " +
                                "from tickets t join Comprobantes c on t.id_comprobante = c.id_comprobante " +
                                "join Promos p on t.id_promo=p.id_promo " +
                                "join Funciones f on t.id_funcion = f.id_funcion group by c.id_comprobante,c.fecha,c.id_forma_venta order by 1";
        }

        #endregion




        #region botones

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
            SetQuery();
        }

        #endregion

        private void dgvComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea volver al menú anterior?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
