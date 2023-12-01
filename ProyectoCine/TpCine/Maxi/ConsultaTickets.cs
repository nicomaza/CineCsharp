using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpLab.datos;

namespace TpLab.Maxi
{
    public partial class ConsultaTickets : Form
    {        
        public ConsultaTickets()
        {
            InitializeComponent();
        }

        private void ConsultaTickets_Load(object sender, EventArgs e)
        {
            
            CargarCombo("select * from Generos",cboGeneros);           
            CargarCombo("select id_sala, descripcion from salas",cboSalas);
            

        }
        public void CargarDGV(string consulta)
        {
            DataTable dt = Consultas.consultarTabla(consulta);
            dgvConsultaTickets.DataSource = dt;            
        }

        public void CargarCombo(string Consulta, ComboBox cbo)
        {
            DataTable dt = Consultas.consultarTabla(Consulta);
            cbo.DataSource = dt;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            dt.Rows.Add(22, "Todos");
            cbo.DisplayMember = dt.Columns[1].ColumnName;
       

           
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string Consulta = "select distinct t.nro_ticket 'TICKET', p.titulo_local 'PELICULA' , s.descripcion 'SALA', t.[Precio] 'PRECIO'\r\n, nro_butaca 'BUTACA', id_comprobante 'COMPROBANTE'\r\nfrom Ticket_Precio t join Funciones as f on f.id_funcion = t.id_funcion\r\njoin Peliculas as p on f.id_pelicula = p.id_pelicula\r\njoin Butacas as b on b.id_butaca = t.id_butaca\r\njoin Salas s on s.id_sala = b.id_sala\r\njoin Peliculas_Generos pg on p.id_pelicula = pg.id_pelicula\r\njoin Generos g on pg.id_genero = g.id_genero ";
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string Sala = cboSalas.Text;
            string Genero = cboGeneros.Text;

            Consulta += "WHERE fecha between '" + desde.ToString("yyyy/MM/dd") + "' and '" + hasta.ToString("yyyy/MM/dd") + "'";
            if (cboGeneros.Text != "Todos") 
            { 
                Consulta += " and genero like '" + Genero + "' ";
            }                            
            if(cboSalas.Text != "Todos")
            {
               Consulta += " and s.descripcion like '" + Sala + "'";
            }

            Consulta += "order by 1";
                
            CargarDGV(Consulta);


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
