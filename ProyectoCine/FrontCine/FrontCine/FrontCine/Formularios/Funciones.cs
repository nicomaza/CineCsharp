using DataCine.Dominio;
using LibreriaTp;

using Newtonsoft.Json;
using ReportesCine.Cliente;
using ReportesCine.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FrontCine.Formularios
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private async void Funciones_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await cargarPeliculas();
            await cargarHorarios();
            await cargarAudios();
            await cargarSalas();
            await cargarFunciones();
            CBpeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            CBpeliculas.SelectedIndex = -1;
            this.Enabled = true;

        }
        private async Task cargarFunciones()
        {
            List<Funcion> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Funciones";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Funcion>>(respuesta);

            foreach (Funcion f in tabla)
            {
                string id_funcion = f.Id.ToString();
                string nombre_pelicula = f.Pelicula.Titulo_local;
                string horario_funcion = f.Horario.Nombre.ToString();
                string audio = f.Audio.Nombre.ToString();
                string sala = f.Sala.Nombre.ToString();
                string precio = f.Precio.ToString();
                string fecha = f.fecha.ToString();
                dataGridView1.Rows.Add(id_funcion, nombre_pelicula, horario_funcion, audio, sala, precio, fecha);

            }

        }

        private async Task cargarHorarios()
        {
            List<Horario> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Horarios";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Horario>>(respuesta);


            //CBhorarios.DataSource = tabla;
            //CBhorarios.DisplayMember = "Nombre";
            //CBhorarios.ValueMember = "Id";
            //CBhorarios.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async Task cargarAudios()
        {
            List<Audio> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Audios";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Audio>>(respuesta);


            //CBaudios.DataSource = tabla;
            //CBaudios.DisplayMember = "Nombre";
            //CBaudios.ValueMember = "Id";
            //CBaudios.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async Task cargarSalas()
        {
            List<Sala> tabla = null;
            string url = "https://localhost:7259/api/Funciones/Salas";

            var respuesta = await ClienteSingleton.getinstancia().GetAsync(url);
            tabla = JsonConvert.DeserializeObject<List<Sala>>(respuesta);


            //CBsalas.DataSource = tabla;
            //CBsalas.DisplayMember = "Nombre";
            //CBsalas.ValueMember = "Id";
            //CBsalas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private async void BTNconsultarFuncion_Click(object sender, EventArgs e)
        {

            BTNconsultarFuncion.Enabled = false;
            await ConsultarFuncionFiltro();
            CBpeliculas.SelectedIndex = -1;
            BTNconsultarFuncion.Enabled = true;

        }
        private async Task ConsultarFuncionFiltro()
        {
            if (ValidarDatos())
            {
                int id_pelicula = (int)CBpeliculas.SelectedValue;
                //int id_horario = (int)CBhorarios.SelectedValue;
                //int id_audio = (int)CBaudios.SelectedValue;
                //int id_sala = (int)CBsalas.SelectedValue;
                //int precio = Convert.ToInt32(TXTprecio.Text);
                DateTime fecha = DTPfecha.Value;


                List<Funcion> lista = new List<Funcion>();
                ParametroFuncion parametro = new ParametroFuncion();
                parametro.id_pelicula = id_pelicula;
                //parametro.id_horario = id_horario;
                //parametro.id_audio = id_audio;
                //parametro.id_sala = id_sala;
                //parametro.precio = precio;
                parametro.fecha = fecha;

                string url = "https://localhost:7259/api/Funciones/FuncionesFiltro";
                string funcionJSON = JsonConvert.SerializeObject(parametro);
                var data = await ClienteSingleton.getinstancia().PostAsync(url, funcionJSON);

                List<Funcion> lst = JsonConvert.DeserializeObject<List<Funcion>>(data);
                dataGridView1.Rows.Clear();


                if (lst.Count > 0)
                {

                    foreach (Funcion f in lst)
                    {
                        string id_funcion_ = f.Id.ToString();
                        string nombre_pelicula_ = f.Pelicula.Titulo_local;
                        string horario_funcion_ = f.Horario.Nombre.ToString();
                        string audio_ = f.Audio.Nombre.ToString();
                        string sala_ = f.Sala.Nombre.ToString();
                        string precio_ = f.Precio.ToString();
                        string fecha_ = f.fecha.ToString();
                        dataGridView1.Rows.Add(id_funcion_, nombre_pelicula_, horario_funcion_, audio_, sala_, precio_, fecha_);
                    }
                }
                else
                {
                    MessageBox.Show("No existen funciones con esos parametros");
                }
            }

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?", "saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
        }
        public async Task<bool> bajaFuncion(int id_funcion)
        {
            string url = "https://localhost:7259/api/Funciones/" + id_funcion;
            string funcionJSON = JsonConvert.SerializeObject(id_funcion);
            var data = await ClienteSingleton.getinstancia().PatchAsync(url, funcionJSON);
            return data == "true";

        }
        public async Task DesabilitarFuncion()
        {
            //https://localhost:7259/api/Funciones/BajaLogica?id_funcion=2
            if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                var filaSeleccionada = dataGridView1.CurrentRow;

                int id_funcion = Convert.ToInt32(filaSeleccionada.Cells["Column1"].Value);

                if (MessageBox.Show("Desea dar de baja la funcion?", "ELIMINANDO FUNCION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    this.Enabled = false;
                    if (await bajaFuncion(id_funcion) != null)
                    {
                        MessageBox.Show("Funcion dada de baja correctamente");
                        dataGridView1.Rows.Clear();
                        await cargarFunciones();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL DAR DE BAJA LA FUNCION");
                    }
                    this.Enabled = true;
                }
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Enabled = false;
            await DesabilitarFuncion();
            this.Enabled = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            dataGridView1.Rows.Clear();
            await cargarFunciones();
            button1.Enabled = true;
        }

        private void BTNagregarFuncion_Click(object sender, EventArgs e)
        {
           
            AgregarFuncion agregarFuncion = new AgregarFuncion();
            
            agregarFuncion.ShowDialog();
            
           

        }

        public bool ValidarDatos()
        {
            if(CBpeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una pelicula para consultar su funcion", "ADVERTENCIA");
                return false;
            }
            return true;
        }

    }
}

