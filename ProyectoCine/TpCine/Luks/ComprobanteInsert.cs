using LibreriaTp;
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

namespace TpLab.Luks
{
    public partial class ComprobanteInsert : Form
    {
        DateTime fecha;
        Pelicula peli;
        Audio audio;
        Horario horario;
        Sala sala;
        Funcion Funcion;
        int cant;
        int ncant_ant;
        List<Ticket> tickets;
        public List<Pagos> PagosList { get; set; }
        Ticket ticket;
        DataTable butacas;
        DataTable promos;
        double monto;

        public ComprobanteInsert()
        {
            InitializeComponent();
            DeshabilitarTodo();
            CargarPromos();
            CargarFormasVenta();
            dtp_fecha.Value = DateTime.Now;
            tickets = new List<Ticket>();
            PagosList = new List<Pagos>();
            cant = 1;
            monto = 0;
            Funcion = new Funcion();
            peli = new Pelicula();
            horario = new Horario();
            sala = new Sala();
            Funcion.Pelicula = peli;
            Funcion.Horario = horario;
            Funcion.Sala = sala;
            cant = 1;
            ncant_ant = 1;
        }


        private void CargarComboPeli()//********************************
        {
            DataTable dt = new DataTable();
            dt = Consultas.consultarTabla(@"select distinct p.titulo_local,p.id_pelicula
                                                        from Funciones f
                                                        join Peliculas p on f.id_pelicula = p.id_pelicula
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") + "'");
            cbo_peli.DataSource = dt;
            cbo_peli.ValueMember = "id_pelicula";
            cbo_peli.DisplayMember = "titulo_local";
        }
        private void CargarComboIdioma()
        {
          
            cbo_audio.DataSource = Consultas.consultarTabla(@"select distinct f.id_audio,descripcion
                                                        from Funciones f
                                                        join Audios a on f.id_audio=a.id_audio
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue);
            cbo_audio.ValueMember = "id_audio";
            cbo_audio.DisplayMember = "descripcion";
            
        }
        private void CargarComboHorario()
        {

                cbo_horario.DataSource = Consultas.consultarTabla(@"select distinct f.id_horario,horario
                                                        from Funciones f
                                                        join horarios h on f.id_horario=h.id_horario
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and f.id_audio = " + cbo_audio.SelectedValue);
                cbo_horario.ValueMember = "id_horario";
                cbo_horario.DisplayMember = "horario";
            
        }
        private void CargarComboSala()
        {

                cbo_sala.DataSource = Consultas.consultarTabla(@"select f.id_sala,descripcion
                                                        from Funciones f
                                                        join Salas s on f.id_sala=s.id_sala
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and f.id_audio = " + cbo_audio.SelectedValue +
                                                        " and f.id_horario = " + cbo_horario.SelectedValue);
                cbo_sala.ValueMember = "id_sala";
                cbo_sala.DisplayMember = "descripcion";
            
        }
        private void CargarPromos()
        {
            promos = Consultas.consultarTabla(@"select id_promo,descripcion,porcentaje 
                                                                from promos");
            cbo_promos.DataSource = promos;
            cbo_promos.ValueMember = "id_promo";
            cbo_promos.DisplayMember = "descripcion";
        }
        private void CargarFormasVenta()
        {
            cbo_FormasVenta.DataSource = Consultas.consultarTabla(@"select id_forma_venta,descripcion
                                                from formas_venta");
            cbo_FormasVenta.ValueMember = "id_forma_venta";
            cbo_FormasVenta.DisplayMember = "descripcion";
        }
        private void CargarDgvButacas()
        {
            DataTable tab = Consultas.consultarTabla(@"select f.id_funcion, titulo_local, precio
                                                        from Funciones f
                                                        join peliculas p on f.id_pelicula = p.id_pelicula
                                                        where fecha = '" + dtp_fecha.Value.ToString("yyyy-MM-dd") +
                                                        "' and f.id_pelicula = " + cbo_peli.SelectedValue +
                                                        " and id_audio = " + cbo_audio.SelectedValue +
                                                        " and id_horario = " + cbo_horario.SelectedValue +
                                                        " and id_sala = " + cbo_sala.SelectedValue );
            Funcion.Id = tab.Rows[0].Field<int>(0);
            Funcion.Pelicula.Titulo_Local = tab.Rows[0].Field<string>(1);
            Funcion.Precio = tab.Rows[0].Field<int>(2);
            butacas = Consultas.funcion(Funcion.Id.ToString());
            dgv_Butacas.Rows.Clear();
            int row = 0;

            for (int i = 0; i < dgv_Butacas.ColumnCount; i++)
            {
                dgv_Butacas.Columns[i].CellTemplate = new DataGridViewCheckBoxCell();
            }
            List<bool> ListaOcupada = new List<bool>();
            List <string > ListaNombre = new List<string>();
            ListaOcupada.Clear();
            for (int i = 0; i < butacas.Rows.Count; i = i + 5)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) < butacas.Rows.Count) {
                        string a = butacas.Rows[i + j]["nro_ticket"].ToString();
                        ListaOcupada.Add(butacas.Rows[i + j]["nro_ticket"].ToString() != "");
                    }
                }
                if (ListaOcupada.Count > 4)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[i], ListaOcupada[i+1], ListaOcupada[i+2], ListaOcupada[i+3], ListaOcupada[i+4]);
                }
                else if (ListaOcupada.Count > 3)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[i], ListaOcupada[i + 1], ListaOcupada[i + 2], ListaOcupada[i + 3]);
                }
                else if (ListaOcupada.Count > 2)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[i], ListaOcupada[i + 1], ListaOcupada[i + 2]);
                }
                else if (ListaOcupada.Count > 1)
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[i], ListaOcupada[i + 1]);
                }
                else
                {
                    dgv_Butacas.Rows.Add(ListaOcupada[i]);
                }
                row++;
            }
            Fijar_butacas();
        }
        private void DeshabilitarTodo()
        {
            cbo_peli.Enabled = false;
            cbo_audio.Enabled = false;
            cbo_horario.Enabled = false;
            cbo_sala.Enabled = false;
            n_cant.Enabled = false;
        }

        private int MaxButacas()
        {

            return 1;
        }

        private void Fijar_butacas()
        {
            for(int i=0;i<dgv_Butacas.Rows.Count;i++)
            {
                for (int j=0;j<dgv_Butacas.Rows[i].Cells.Count;j++)
                {
                    if ((Boolean)dgv_Butacas.Rows[i].Cells[j].Value)
                        dgv_Butacas.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea cancelar la venta?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            CargarComboPeli();
            DeshabilitarTodo();
            cbo_sala.SelectedIndex = -1;
            cbo_horario.SelectedIndex = -1;
            cbo_audio.SelectedIndex = -1;
            cbo_peli.SelectedIndex = -1;
            cbo_peli.Enabled = true;
            dgv_Butacas.Rows.Clear();
        }

        private void cbo_peli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_peli.Enabled)
            {
                cbo_sala.SelectedIndex = -1;
                CargarComboIdioma();
                DeshabilitarTodo();
                cbo_horario.SelectedIndex = -1;
                cbo_peli.Enabled = true;
                cbo_audio.SelectedIndex = -1;
                cbo_audio.Enabled = true;
                if (cbo_peli.Text != "")
                    Funcion.Pelicula.Titulo_Local = cbo_peli.Text.ToString();
                dgv_Butacas.Rows.Clear();
            }
        }

        private void cbo_horario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_horario.Enabled)
            {
                CargarComboSala();
                cbo_sala.Enabled = true;
                cbo_sala.SelectedIndex = -1;
                n_cant.Enabled = false;
                if (cbo_horario.Text != "")
                    Funcion.Horario.Nombre=cbo_horario.Text.ToString();
                dgv_Butacas.Rows.Clear();
            }
        }

        private void cbo_audio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_audio.Enabled)
            {
                CargarComboHorario();
                DeshabilitarTodo();
                cbo_peli.Enabled = true;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_horario.Enabled = true;
                cbo_sala.SelectedIndex = -1;
                dgv_Butacas.Rows.Clear();
            }
        }

        private void cbo_sala_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_sala.Enabled)
            {
                //n_cant.Maximum = Convert.ToDecimal(MaxButacas());
                n_cant.Enabled = true;
                n_cant.Value = 1;
                cant = Convert.ToInt32(n_cant.Value);
                if (cbo_sala.SelectedValue != null)
                {
                    CargarDgvButacas();
                    Funcion.Sala.Id = Convert.ToInt32(cbo_sala.SelectedValue);
                    Funcion.Sala.Nombre = cbo_sala.Text.ToString();
                }
            }
        }

        private void n_cant_ValueChanged(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(n_cant.Value) - ncant_ant)>0)
                cant += Convert.ToInt32(n_cant.Value) - ncant_ant;
            else
                cant -= Convert.ToInt32(n_cant.Value) - ncant_ant;
            ncant_ant = Convert.ToInt32(n_cant.Value);
        }

        private void dgv_Butacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //contador y quitar ticket
            if ((Boolean)dgv_Butacas.SelectedCells[0].Value!=true && cant>0)
            {
                dgv_Butacas.SelectedCells[0].Value = true;
                ticket = new Ticket();
                ticket.Butaca = new Butaca();
                ticket.Butaca.Id = Convert.ToInt32(butacas.Rows[dgv_Butacas.SelectedCells[0].RowIndex * 5 + dgv_Butacas.SelectedCells[0].ColumnIndex][0].ToString());
                ticket.Funcion = Funcion;
                ticket.Promo = new Promo();
                ticket.Promo.Id = Convert.ToInt32(cbo_promos.SelectedValue.ToString());
                ticket.Promo.Porcentaje = float.Parse(promos.Rows[cbo_promos.SelectedIndex]["porcentaje"].ToString());
                ticket.Promo.Descripcion = promos.Rows[cbo_promos.SelectedIndex]["descripcion"].ToString();
                tickets.Add(ticket);
                dgv_tickets.Rows.Add( ticket.Butaca.Id,Funcion.Sala.Nombre,Funcion.Horario.Nombre, Funcion.Pelicula.Titulo_Local, Funcion.Precio,(100-ticket.Promo.Porcentaje).ToString()+"%",ticket.Promo.Descripcion,ticket.Promo.Porcentaje*ticket.Funcion.Precio/100);
                cant--;
            }
            else if ((Boolean)dgv_Butacas.SelectedCells[0].Value == true && dgv_Butacas.SelectedCells[0].Style.BackColor != Color.LightGray)
            {
                dgv_Butacas.SelectedCells[0].Value = false;   
                
                foreach (DataGridViewRow row in dgv_tickets.Rows)
                {
                    if (row.Cells[0].Value.ToString() == butacas.Rows[dgv_Butacas.SelectedCells[0].RowIndex * 5 + dgv_Butacas.SelectedCells[0].ColumnIndex][0].ToString())
                    {
                        dgv_tickets.Rows.Remove(row);
                    }
                }                
                     tickets.Remove(ticket);
                if((cant)<Convert.ToInt32(n_cant.Value))
                cant++;
            }
        }

        private void cbo_promos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            monto = 0;
            foreach (DataGridViewRow r in dgv_tickets.Rows)
            {
                monto = Convert.ToDouble(r.Cells["PrecioTicket"].Value.ToString()) + monto;
            }
            PagosForm pagos = new PagosForm(monto,PagosList);
            pagos.Show();
            
        }

        private void dgv_tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            int nroC = Consultas.insertar_comprobante(cbo_FormasVenta.SelectedValue.ToString());

            foreach(Pagos p in PagosList)
            {
                Consultas.insertar_fp(p.FormaPago.Id.ToString(), nroC.ToString(), p.Monto.ToString());
            }

            foreach (Ticket t in tickets)
            {
                Consultas.insertar_ticket(t.Funcion.Id.ToString(),t.Butaca.Id.ToString(), nroC.ToString(), t.Promo.Id.ToString());
            }
            MessageBox.Show("Se ingresó el comprobante: "+nroC+" al sistema");
            this.Close();
        }

        private void ComprobanteInsert_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
