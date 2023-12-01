using DataCine.Dominio.FuncionContainer;
using LibreriaTp;
using Newtonsoft.Json;
using ReportesCine.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCine.Formularios
{
    public partial class AgregarFuncion : Form
    {
        public AgregarFuncion()
        {
            InitializeComponent();
        }

        private async void AgregarFuncion_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await cargarPeliculas();
            await cargarHorarios();
            await cargarAudios();
            await cargarSalas();
            CBpeliculas.SelectedIndex = -1;
            CBhorarios.SelectedIndex = -1;
            CBaudios.SelectedIndex = -1;
            CBsalas.SelectedIndex = -1;
            this.Enabled = true;
        }

        private void CBpeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task cargarPeliculas()
        {
            List<Pelicula> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Peliculas";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Pelicula>>(respuesta);


            CBpeliculas.DataSource = tabla;
            CBpeliculas.DisplayMember = "titulo_local";
            CBpeliculas.ValueMember = "Id";
            CBpeliculas.DropDownStyle = ComboBoxStyle.DropDownList;



        }
        private async Task cargarHorarios()
        {
            List<Horario> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Horarios";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Horario>>(respuesta);


            CBhorarios.DataSource = tabla;
            CBhorarios.DisplayMember = "Nombre";
            CBhorarios.ValueMember = "Id";
            CBhorarios.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async Task cargarAudios()
        {
            List<Audio> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Audios";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Audio>>(respuesta);


            CBaudios.DataSource = tabla;
            CBaudios.DisplayMember = "Nombre";
            CBaudios.ValueMember = "Id";
            CBaudios.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async Task cargarSalas()
        {
            List<Sala> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Salas";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Sala>>(respuesta);


            CBsalas.DataSource = tabla;
            CBsalas.DisplayMember = "Nombre";
            CBsalas.ValueMember = "Id";
            CBsalas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (!validarPrecio())
                {
                    MessageBox.Show("Solo puede ingresar numeros en el precio");

                }
                else
                {
                    this.Enabled = false;
                    await CrearFuncion();
                    this.Enabled = true;
                }
            }
        }
     

        private bool validarPrecio()
        {
            bool estado = true;
            string Precio = TXTprecio.Text;

            foreach (char c in Precio)
            {
                if (!char.IsDigit(c))
                {
                    estado = false;
                }

            }
            return estado;


        }
        private async Task CrearFuncion()
        {
            dataGridView1.Rows.Clear();
            int id_pelicula = Convert.ToInt32(CBpeliculas.SelectedValue);
            int id_horario = Convert.ToInt32(CBhorarios.SelectedValue);
            int id_audio = Convert.ToInt32(CBaudios.SelectedValue);
            int id_sala = Convert.ToInt32(CBsalas.SelectedValue);
            int precio = Convert.ToInt32(TXTprecio.Text);
            DateTime fecha = dateTimePicker1.Value;

            try
            {
                FuncionResumida fr = new FuncionResumida();
                fr.id_pelicula = id_pelicula;
                fr.id_horario = id_horario;
                fr.id_audio = id_audio;
                fr.id_sala = id_sala;
                fr.precio = precio;
                fr.fecha = fecha;

               
               


                if (await AltaFuncion(fr) != null)
                {
                    MessageBox.Show("Funcion dada de alta correctamente");
                    dataGridView1.Rows.Clear();
                    
                }

                dataGridView1.Rows.Add(CBpeliculas.Text,CBhorarios.Text,CBaudios.Text,CBsalas.Text,precio.ToString(),fecha.ToString());



            }
            catch
            {
                MessageBox.Show("ERROR AL CREAR LA FUNCION");

            }
        }
        public async Task<bool> AltaFuncion(FuncionResumida fr)
        {
            string url = "https://localhost:7259/api/Funciones/funcion";
            string funcionJSON = JsonConvert.SerializeObject(fr);
            var data = await ClienteSingleton.getinstancia().PutAsync(url, funcionJSON);
            return data == "true";

        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir?","saliendo",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
               

            }
        }

        public bool ValidarDatos()
        {
            if(CBpeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una pelicula","ADVERTENCIA");
                return false;
            }
            if (CBhorarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un horario", "ADVERTENCIA");
                return false;
            }
            if (CBaudios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un audio", "ADVERTENCIA");
                return false;
            }
            if (CBsalas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sala", "ADVERTENCIA");
                return false;
            }
            if (TXTprecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio", "ADVERTENCIA");
                return false;
            }
            return true;
        }
    }
}
