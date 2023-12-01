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
using TpLab.Genagamer;

namespace TpLab.Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TpLab.Luks.ComprobanteInsert nuevoComprobante = new TpLab.Luks.ComprobanteInsert();
            nuevoComprobante.Show();
        }

        private void consultaGenaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaMaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TpLab.Genagamer.consulta_funciones_mas_vendidas ConsultaFuncion = new consulta_funciones_mas_vendidas();
            ConsultaFuncion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TpLab.Maxi.ConsultaTickets consulta = new Maxi.ConsultaTickets();
            consulta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TpLab.Salva.ConsultaComprobante frmSalva = new Salva.ConsultaComprobante();
            frmSalva.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TpLab.Nicolas.FormEstadistico frmNicolas = new TpLab.Nicolas.FormEstadistico();
            frmNicolas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TpLab.Luks.ComprobanteInsert frmLucas = new TpLab.Luks.ComprobanteInsert();
            frmLucas.ShowDialog();
        }
    }
}
