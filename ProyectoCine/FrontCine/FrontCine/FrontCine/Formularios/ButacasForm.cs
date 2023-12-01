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
    public partial class ButacasForm : Form
    {
        List<TipoGenerico> butacaslista;
        List<PictureBox> butacasImagenes;
        Funcion funcion;
        List<Ticket> tickets;
        List<Ticket> ticketstemp;
        public ComprobanteVenta comprobanteVenta { get; set; }
        Promo promo;
        public ButacasForm(List<Ticket> ticket, Funcion funcion, Promo promo)
        {
            InitializeComponent();
            this.funcion = funcion;
            this.promo = promo;
            tickets = ticket;
            ticketstemp = new List<Ticket>();
            foreach (Ticket ticket1 in tickets)
            {
                ticketstemp.Add(ticket1);
            }
            butacasImagenes = new List<PictureBox> { blanco1,blanco2, blanco3, blanco4, blanco5, blanco6, blanco7, blanco8, blanco9, blanco10, blanco11, blanco12, blanco13, blanco14
            , blanco15, blanco16, blanco17, blanco18, blanco19, blanco20, blanco21, blanco22, blanco23, blanco24, blanco25, blanco26, blanco27, blanco28, blanco29, blanco30, blanco31
            , blanco32, blanco33, blanco34, blanco35};
            cargarButacas(funcion);
        }

        private async void cargarButacas(Funcion funcion)
        {
            await recuperarButacas(funcion.Id.ToString());
            int count = 0;
            foreach (TipoGenerico t in butacaslista)
            {
                if (t.Nombre != "")
                { 
                    butacasImagenes[count].Image = Properties.Resources.asientoRojo;
                    butacasImagenes[count].AccessibleName = "ocupada";
                }
                count++;
            }
            foreach (Ticket t in tickets)
            {
                if (t.Funcion.Id == funcion.Id)
                {
                    butacasImagenes[t.Butaca.NroButaca - 1].Image = Properties.Resources.asiento;
                    butacasImagenes[t.Butaca.NroButaca - 1].AccessibleName = "seleccionada";
                }
            }
        }
        public async Task recuperarButacas(string id)
        {
            string url = "https://localhost:7259/api/Comprobantes/Butacas?ID=" + id;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<TipoGenerico> lst = JsonConvert.DeserializeObject<List<TipoGenerico>>(data);
            butacaslista = lst;
        }

        private void ButacaClick(PictureBox pictureBox, int nro)
        {
            if (pictureBox.AccessibleName==null)
            {
                Ticket ticket = new Ticket();
                ticket.Funcion = funcion;
                ticket.Butaca.Id = Convert.ToInt32(butacaslista[nro - 1].ID);
                ticket.Butaca.NroButaca = nro;
                ticket.Butaca.Nombre = nro.ToString();
                ticket.Promo = promo;

                pictureBox.Image = Properties.Resources.asiento;
                pictureBox.AccessibleName = "seleccionada";
                ticketstemp.Add(ticket);
            }
            else if (pictureBox.AccessibleName=="seleccionada")
            {
                foreach (Ticket t in ticketstemp.ToList<Ticket>())
                {
                    if (t.Funcion.Id == funcion.Id && t.Butaca.NroButaca == nro)
                    {
                        ticketstemp.Remove(t);
                        pictureBox.Image = Properties.Resources.asientoblanco;
                        pictureBox.AccessibleName = null;
                    }
                }
            }
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco31, 31);
        }

        private void blanco1_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco1, 1);
        }

        private void blanco2_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco2, 2);
        }

        private void blanco7_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco7, 7);
        }

        private void blanco3_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco3, 3);
        }

        private void blanco4_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco4, 4);
        }

        private void blanco5_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco5, 5);
        }

        private void blanco6_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco6, 6);
        }

        private void blanco8_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco8, 8);
        }

        private void blanco9_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco9, 9);
        }

        private void blanco10_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco10, 10);
        }

        private void blanco11_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco11, 11);
        }

        private void blanco12_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco12, 12);
        }

        private void blanco13_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco13, 13);
        }

        private void blanco14_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco14, 14);
        }

        private void blanco15_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco15, 15);
        }

        private void blanco16_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco16, 16);
        }

        private void blanco17_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco17, 17);
        }

        private void blanco18_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco18, 18);
        }

        private void blanco19_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco19, 19);
        }

        private void blanco20_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco20, 20);
        }

        private void blanco21_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco21, 21);
        }

        private void blanco22_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco22, 22);
        }

        private void blanco23_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco23, 23);
        }

        private void blanco24_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco24, 24);
        }

        private void blanco25_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco25, 25);
        }

        private void blanco26_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco26, 26);
        }

        private void blanco27_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco27, 27);
        }

        private void blanco28_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco28, 28);
        }

        private void blanco29_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco29, 29);
        }

        private void blanco30_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco30, 30);
        }

        private void blanco32_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco32, 32);
        }

        private void blanco33_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco33, 33);
        }

        private void blanco34_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco34, 34);
        }

        private void blanco35_Click(object sender, EventArgs e)
        {
            ButacaClick(blanco35, 35);
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            tickets.Clear();
            foreach (Ticket ticket1 in ticketstemp)
            {
                tickets.Add(ticket1);
            }
            this.comprobanteVenta.recargarTickets();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
