using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
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
    public partial class InsertarPeliculas : Form
    {
        private IPeliculasService service;
        Pelicula nueva;

        public InsertarPeliculas()
        {
            InitializeComponent();
            service = new PeliculaService();
            nueva = new Pelicula();
        }

        private async void InsertarPeliculas_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await CargarCBO(cboClasificaciones, "Clasificacion");
            await CargarCBO(cboDirectores, "Directores");
            await CargarCBO(cboGeneros, "Generos");
            await CargarCBO(cboDistribuidoras, "Distribuidora");
            await CargarCBO(cboPaises, "Paises");
            await CargarDGVAsync();
            this.Enabled = true;
        }

        private async Task CargarCBO(ComboBox cbo, string nombre)
        {
            string url = "https://localhost:7259/api/Peliculas/" + nombre;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<object> lst = JsonConvert.DeserializeObject<List<object>>(data);

            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
              
        public async Task ConfirmarPelicula()
        {
            try
            {
                if (ValidarDatos())
                {
                    Pais p = new Pais();
                    p.Id = Convert.ToInt32(cboPaises.SelectedValue);
                    p.Nombre = cboPaises.SelectedText;
                    Clasificacion c = new Clasificacion();
                    c.Id = Convert.ToInt32(cboClasificaciones.SelectedValue);
                    c.Nombre = cboClasificaciones.SelectedText;
                    Genero g = new Genero();
                    g.Id = Convert.ToInt32(cboGeneros.SelectedValue);
                    g.Nombre = cboGeneros.SelectedText;
                    Distribuidora dis = new Distribuidora();
                    dis.Id = Convert.ToInt32(cboDistribuidoras.SelectedValue);
                    dis.Nombre = cboDistribuidoras.SelectedText;
                    Director dir = new Director();
                    dir.Id = Convert.ToInt32(cboDirectores.SelectedValue);
                    dir.Nombre = cboDirectores.SelectedText;

                    nueva.pais = p;
                    nueva.clasificacion = c;
                    nueva.genero = g;
                    nueva.distribuidora = dis;
                    nueva.director = dir;


                    nueva.Titulo_local = txtTitulo.Text;
                    nueva.Titulo_original = " ";
                    nueva.Descripcion = " ";

                    nueva.Fecha_Estreno = dtpEstreno.Value;
                    nueva.duracion = Convert.ToInt32(txtDuracion.Text);


                    if (await CargarPeliculaAsync(nueva))
                    {
                        MessageBox.Show("Se registro correctamente la pelicula");
                        await CargarDGVAsync();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocrrido un error");
                        Limpiar();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Datos invalidos");
            }
            
        }

        public async Task<bool> CargarPeliculaAsync(Pelicula pelicula)
        {
            string url = "https://localhost:7259/pelicula";
            string peliculaJason = JsonConvert.SerializeObject(pelicula);
            var data = await ClienteSingleton.getinstancia().PostAsync(url, peliculaJason);
            return data == "true";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            await ConfirmarPelicula();
            this.Enabled = true;
        }

        public async Task CargarDGVAsync()
        {
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

            dgvPeliculas.Rows.Clear();
            foreach (Pelicula p in lst)
            {
                if(p.Baja == 0)
                     dgvPeliculas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.clasificacion.Nombre, p.genero.Nombre });
            }

        }

        private void barrasuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seleccion_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Limpiar()
        {
            txtTitulo.Text = "";
            txtDuracion.Text = "";
            dtpEstreno.Value = DateTime.Today;
            cboClasificaciones.SelectedIndex = -1;
            cboDirectores.SelectedIndex = -1;
            cboDistribuidoras.SelectedIndex = -1;
            cboGeneros.SelectedIndex = -1;
            cboPaises.SelectedIndex = -1;
        }

        public bool ValidarDatos()
        {
            if(txtTitulo.Text == "")
            {
                MessageBox.Show("Debe Insertar un titulo","ADVERTENCIA");
                return false;
            }
            if (txtDuracion.Text == "")
            {
                MessageBox.Show("Debe Insertar una duracion", "ADVERTENCIA");
                return false;
            }
            if (cboClasificaciones.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Insertar una clasificacion", "ADVERTENCIA");
                return false;
            }
            if (cboDirectores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Insertar un direcror", "ADVERTENCIA");
                return false;
            }
            if (cboDistribuidoras.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Insertar una distribuidora", "ADVERTENCIA");
                return false;
            }
            if (cboGeneros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Insertar un genero", "ADVERTENCIA");
                return false;
            }
            if (cboPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Insertar un Pais", "ADVERTENCIA");
                return false;
            }
            return true;
        }
    }
}
