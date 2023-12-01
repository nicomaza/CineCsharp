using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.Formularios
{
    public partial class Login : Form
    {
        IUsuarioService servicio;

        public Login()
        {
            InitializeComponent();
            servicio = new UsuarioService();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtcontrase.PasswordChar = '*';
            btnlogin.Focus();
        }

        private void picmostrar_Click(object sender, EventArgs e)
        {
            picocultar.BringToFront();
            txtcontrase.PasswordChar= '\0';
        }

        private void picocultar_Click(object sender, EventArgs e)
        {
            picmostrar.BringToFront();
            txtcontrase.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (servicio.getUsers(txtusuario.Text, txtcontrase.Text))
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else MessageBox.Show("Usuario o contraseña incorrectos, por favor revise sus credenciales");

            //this.Hide();
            //Inicio inicio = new Inicio();
            //inicio.Show();

        }
    }
}
