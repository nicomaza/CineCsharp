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
    public partial class EditarPeliculas : Form
    {
        ConsultarPeliculas form = new ConsultarPeliculas();
        private int id;

        public EditarPeliculas(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void EditarPeliculas_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            txtTitulo.Enabled = false;
            await CargarCombos(cboDistribuidoras, "distribuidora");
            await CargarCombos(cboPaises, "paises");
            await CargarCombos(cboDirectores, "directores");
            await CargarCombos(cboClasificaciones, "clasificacion");
            await CargarCombos(cboGeneros, "generos");

            await CargarCampos();
            this.Enabled = true;
        }



        public async Task CargarCampos()
        {
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

            foreach(Pelicula p in lst)
            {
                if(p.Id == id)
                {
                    txtTitulo.Text = p.Titulo_original.ToString();
                    txtDuracion.Text = p.duracion.ToString();
                    txtTitulo.Text = p.Titulo_local.ToString();
                    int index = cboDistribuidoras.FindString(p.distribuidora.Nombre);
                    cboDistribuidoras.SelectedIndex = index;
                    index = cboClasificaciones.FindString(p.clasificacion.Nombre);
                    cboClasificaciones.SelectedIndex = index;
                    index = cboDirectores.FindString(p.director.Nombre);
                    cboDirectores.SelectedIndex = index;
                    index = cboGeneros.FindString(p.genero.Nombre);
                    cboGeneros.SelectedIndex = index;
                    index = cboPaises.FindString(p.pais.Nombre);
                    cboPaises.SelectedIndex = index;
                    dtpEstreno.Value = p.Fecha_Estreno;
                    
                }    
            }

        }
        

        //Carga de combos
        public async Task CargarCombos(ComboBox cbo, string nombre)
        {
            string url = "https://localhost:7259/api/Peliculas/" + nombre;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<object> lst = JsonConvert.DeserializeObject<List<object>>(data);

            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
        }

        public async Task ModificarPelicula()
        {
            if (ValidarDatos())
            {
                string url = "https://localhost:7259/api/Peliculas/Peliculas";
                var data = await ClienteSingleton.getinstancia().GetAsync(url);
                List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);

                foreach (Pelicula p in lst)
                {
                    if (p.Id == id)
                    {
                        p.clasificacion.Id = Convert.ToInt32(cboClasificaciones.SelectedValue);
                        p.clasificacion.Nombre = cboClasificaciones.SelectedText;
                        p.director.Id = Convert.ToInt32(cboDirectores.SelectedValue);
                        p.director.Nombre = p.director.Nombre;
                        p.pais.Id = Convert.ToInt32(cboPaises.SelectedValue);
                        p.pais.Nombre = cboPaises.SelectedText;
                        p.Titulo_local = txtTitulo.Text;
                        p.Fecha_Estreno = dtpEstreno.Value;
                        p.duracion = Convert.ToInt32(txtDuracion.Text);
                        p.distribuidora.Id = Convert.ToInt32(cboDistribuidoras.SelectedValue);
                        p.distribuidora.Nombre = cboDistribuidoras.SelectedText;
                        p.genero.Nombre = cboGeneros.SelectedText;
                        p.genero.Id = Convert.ToInt32(cboGeneros.SelectedValue);
                        p.Titulo_local = txtTitulo.Text;
                        p.Descripcion = "-";

                        string url2 = "https://localhost:7259/pelicula";
                        string peliculaJason = JsonConvert.SerializeObject(p);
                        var data2 = await ClienteSingleton.getinstancia().PutAsync(url2, peliculaJason);

                    }
                }
            }

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                await ModificarPelicula();
                await form.CargarDGVAsync();
                MessageBox.Show("Pelicula modificada con exito");
                this.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public bool ValidarDatos()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Debe Insertar un titulo", "ADVERTENCIA");
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
