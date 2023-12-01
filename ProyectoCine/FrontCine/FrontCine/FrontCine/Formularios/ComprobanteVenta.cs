using FrontCine.Formularios.Reportes;
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
    public partial class ComprobanteVenta : Form
    {
        List<Ticket> tickets = new List<Ticket>();
        List<Funcion> funciones = new List<Funcion>();
        List<Funcion> funciones3 = new List<Funcion>();
        List<Funcion> funciones2 = new List<Funcion>();
        List<Pelicula> pelis = new List<Pelicula>();
        List<Audio> audios = new List<Audio>();
        List<Horario> horarios = new List<Horario>();
        List<Sala> salas = new List<Sala>();
        List<Promo> promos = new List<Promo>();
        List<FormaVenta> fVentas = new List<FormaVenta>();
        Funcion funcion = new Funcion();
        double restante;
        Funcion f = new Funcion();
        public List<Pagos> PagosList { get; set; }
        double monto;
        public ComprobanteVenta()
        {
            InitializeComponent();
            DeshabilitarTodo();
            CargarCombosAsync();

            PagosList = new List<Pagos>();
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            monto = 0;
            foreach (Ticket t in tickets)
            {
                monto = (t.Funcion.Precio * t.Promo.Porcentaje / 100) + monto;
            }
            restante = monto;
            PagosForm pagos = new PagosForm(monto, PagosList);
            pagos.restante = restante;
            pagos.comprobanteVenta = this;
            pagos.Show();
        }
        public async Task recuperarFunciones(string date)
        {
            string url = "https://localhost:7259/api/Comprobantes/Funciones?Fecha=" + date;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Funcion> lst = JsonConvert.DeserializeObject<List<Funcion>>(data);
            funciones = lst;
        }
        public async Task recuperarPromos()
        {
            string url = "https://localhost:7259/api/Comprobantes/Promos";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Promo> lst = JsonConvert.DeserializeObject<List<Promo>>(data);
            promos = lst;
        }
        public async Task recuperarFVentas()
        {
            string url = "https://localhost:7259/api/Comprobantes/FormasVenta";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<FormaVenta> lst = JsonConvert.DeserializeObject<List<FormaVenta>>(data);
            fVentas = lst;
        }
        private async Task CargarCombosAsync()
        {
            dtp_fecha.Enabled = false;
            await recuperarPromos();
            await recuperarFVentas();
            cbo_promos.DataSource = promos;
            cbo_promos.DisplayMember = "Descripcion";
            cbo_promos.ValueMember = "Id";
            cbo_fVenta.DataSource = fVentas;
            cbo_fVenta.ValueMember = "Id";
            cbo_fVenta.DisplayMember = "Nombre";
            dtp_fecha.Enabled = true;
        }
        private async void dtp_fecha_ValueChangedAsync(object sender, EventArgs e)
        {
            dtp_fecha.Enabled = false;
            DeshabilitarTodo();
            await recuperarFunciones(dtp_fecha.Value.ToString("yyyy-MM-dd"));
            CargarComboPeli();
            cbo_peli.SelectedIndex = -1;
            cbo_peli.Enabled = true;
            cbo_audio.SelectedIndex = -1;
            cbo_horario.SelectedIndex = -1;
            cbo_sala.SelectedIndex = -1;
            dtp_fecha.Enabled = true;
        }
        private void DeshabilitarTodo()
        {
            cbo_peli.Enabled = false;
            cbo_audio.Enabled = false;
            cbo_horario.Enabled = false;
            cbo_sala.Enabled = false;
            btn_butacas.Enabled = false;
            btn_comprobante.Enabled = false;
        }
        public void habilitarTerminar()
        {
            btn_comprobante.Enabled = true;
        }
        public void desHabilitarTerminar()
        {
            btn_comprobante.Enabled = false;
        }
        private void CargarComboPeli()
        {
            if (funciones.Count > 0)
            {
                bool flag;
                pelis.Clear();
                foreach (Funcion f in funciones)
                {
                    flag = true;
                    foreach (Pelicula pelicula in pelis)
                    {
                        if (pelicula.Id == f.Pelicula.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        pelis.Add(f.Pelicula);
                }
                cbo_peli.DataSource = null;
                cbo_peli.DataSource = pelis;
                cbo_peli.ValueMember = "Id";
                cbo_peli.DisplayMember = "Titulo_local";
            }
        }
        private void CargarComboIdioma()
        {
            bool flag;
            audios.Clear();
            funciones2.Clear();
            foreach (Funcion f in funciones)
            {
                if (f.Pelicula.Id == (int)cbo_peli.SelectedValue)
                {
                    funciones2.Add(f);
                    flag = true;
                    foreach (Audio audio in audios)
                    {
                        if (audio.Id == f.Audio.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        audios.Add(f.Audio);
                }
            }
            cbo_audio.DataSource = null;
            cbo_audio.DataSource = audios;
            cbo_audio.ValueMember = "Id";
            cbo_audio.DisplayMember = "Nombre";
        }
        private void CargarComboHorario()
        {
            bool flag;
            horarios.Clear();
            funciones3.Clear();
            foreach (Funcion f in funciones2)
            {
                if (f.Audio.Id == (int)cbo_audio.SelectedValue)
                {
                    funciones3.Add(f);
                    flag = true;
                    foreach (Horario horario in horarios)
                    {
                        if (horario.Id == f.Horario.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        horarios.Add(f.Horario);
                }
            }
            cbo_horario.DataSource = null;
            cbo_horario.DataSource = horarios;
            cbo_horario.ValueMember = "Id";
            cbo_horario.DisplayMember = "Nombre";
        }

        private void CargarComboSala()
        {
            bool flag;
            salas.Clear();
            funciones2.Clear();
            foreach (Funcion f in funciones3)
            {
                if (f.Horario.Id == (int)cbo_horario.SelectedValue)
                {
                    funciones2.Add(f);
                    flag = true;
                    foreach (Sala sala in salas)
                    {
                        if (sala.Id == f.Sala.Id)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        salas.Add(f.Sala);
                }
            }
            cbo_sala.DataSource = null;
            cbo_sala.DataSource = salas;
            cbo_sala.ValueMember = "Id";
            cbo_sala.DisplayMember = "Nombre";
        }

        private void cbo_peli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_peli.Enabled)
            {
                DeshabilitarTodo();
                CargarComboIdioma();
                cbo_peli.Enabled = true;
                cbo_audio.SelectedIndex = -1;
                cbo_audio.Enabled = true;
            }
        }

        private void cbo_audio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_audio.Enabled)
            {
                DeshabilitarTodo();
                CargarComboHorario();
                cbo_peli.Enabled = true;
                cbo_audio.Enabled = true;
                cbo_horario.SelectedIndex = -1;
                cbo_horario.Enabled = true;
            }
        }

        private void cbo_horario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbo_horario.Enabled)
            {
                CargarComboSala();
                cbo_sala.SelectedIndex = -1;
                cbo_sala.Enabled = true;
            }
        }

        private void cbo_sala_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cbo_sala.Enabled)
            btn_butacas.Enabled = true;
        }

        private void cbo_promos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void recargarTickets()
        {
            dgv_tickets.Rows.Clear();
            foreach (Ticket ticket in tickets)
            {
                dgv_tickets.Rows.Add(ticket.Butaca.NroButaca,ticket.Funcion.Sala.Nombre,ticket.Funcion.Horario.Nombre,ticket.Funcion.Pelicula.Titulo_local,ticket.Funcion.Precio,
                    (100-ticket.Promo.Porcentaje).ToString()+"%",ticket.Promo.Descripcion, ticket.Promo.Porcentaje* ticket.Funcion.Precio/100);
            }
            desHabilitarTerminar();
        }

        private void btn_butacas_Click(object sender, EventArgs e)
        {
            foreach (Funcion f in funciones2)
            {
                if (f.Sala.Id == (int)cbo_sala.SelectedValue)
                {
                    funcion = f;
                    break;
                }
            }
            funcion.Sala = salas[cbo_sala.SelectedIndex];
            funcion.Pelicula = pelis[cbo_peli.SelectedIndex];
            ButacasForm pagos = new ButacasForm(tickets, funcion,promos[cbo_promos.SelectedIndex]);
            pagos.comprobanteVenta = this;
            pagos.Show();
        }

        private async void btn_comprobante_Click(object sender, EventArgs e)
        {
            Comprobante comprobante = new Comprobante
            {
                Fecha = DateTime.Now,
                ListaPagos = PagosList,
                FormaVenta = (FormaVenta)cbo_fVenta.SelectedItem,
                ltickets = tickets,
                Id = 0
            };
        if(await AltaComprobante(comprobante))
            {
                tickets = new List<Ticket>();
                PagosList = new List<Pagos>();
                recargarTickets();
                ReporteComprobante reporte = new ReporteComprobante(comprobante);
                reporte.Show();
            }
        }
        public async Task<bool> AltaComprobante(Comprobante c)
        {            
            string url = "https://localhost:7259/api/Comprobantes";
            string funcionJSON = JsonConvert.SerializeObject(c);            
            funcionJSON = funcionJSON.Replace("null", @"""""");
            var data = await ClienteSingleton.getinstancia().PutAsync(url, funcionJSON);
            return data == "true";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
