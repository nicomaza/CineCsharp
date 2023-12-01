using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpLab.Presentacion;
using System.Windows.Forms;

namespace TpLab.Salva
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            lblNoValido.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                this.Hide();
                Inicio f1 = new Inicio();
                f1.Show();
                
            }
            else if (lblNoValido.Visible==false)
            {
                lblNoValido.Visible=true;
                
            }
        }

        private bool Validation()
        {
            if (txtUser.Text.ToLower() != "cinelabadmin" || TxtPass.Text != "cinelab123")
            {

                return false;
            }

            return true;
        }
    }
}
