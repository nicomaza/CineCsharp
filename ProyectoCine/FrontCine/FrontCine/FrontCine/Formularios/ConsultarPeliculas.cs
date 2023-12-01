using LibreriaTp;
using Newtonsoft.Json;
using ReportesCine.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontCine.Formularios
{
    public partial class ConsultarPeliculas : Form
    {
        public ConsultarPeliculas()
        {
            InitializeComponent();
        }

        private async void ConsultarPeliculas_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await CargarDGVAsync();
            this.Enabled = true;
        }

        public async Task CargarDGVAsync()
        {         
            string url = "https://localhost:7259/api/Peliculas/Peliculas";
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);          
            

            dgvPeliculasActivas.Rows.Clear();
            dgvPeliculasBajas.Rows.Clear();

            foreach (Pelicula p in lst)
            {
                if (p.Baja == 0)
                    dgvPeliculasActivas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion,p.Fecha_Estreno,p.pais.Nombre,p.director.Nombre,p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });
                if (p.Baja == 1)
                    dgvPeliculasBajas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.Fecha_Estreno, p.pais.Nombre, p.director.Nombre, p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });


            }

        }

        public async Task CargarDGVFiltrada()
        {  
            string titulo = textBox1.Text;
            string url = "https://localhost:7259/api/Peliculas/" + titulo;
            var data = await ClienteSingleton.getinstancia().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);


            dgvPeliculasActivas.Rows.Clear();
            dgvPeliculasBajas.Rows.Clear();

            foreach (Pelicula p in lst)
            {
                if (p.Baja == 0)
                    dgvPeliculasActivas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.Fecha_Estreno, p.pais.Nombre, p.director.Nombre, p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });
                if (p.Baja == 1)
                    dgvPeliculasBajas.Rows.Add(new object[] { p.Id, p.Titulo_local, p.duracion, p.Fecha_Estreno, p.pais.Nombre, p.director.Nombre, p.distribuidora.Nombre, p.clasificacion.Nombre, p.genero.Nombre });


            }
        }

        public async Task<bool> DesabilitarPeliculaAsync(int id, int baja)
        {
            string url = "https://localhost:7259/api/Peliculas/" + id.ToString() + ", " + baja;
            string peliculaJason = JsonConvert.SerializeObject(id);
            var data = await ClienteSingleton.getinstancia().PatchAsync(url,peliculaJason);
            return data == "true";

        }

        private async void dgvPeliculasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPeliculasActivas.CurrentCell.ColumnIndex == 10)
            {
                EditarPeliculas form = new EditarPeliculas(idPelicula());
                form.ShowDialog();
                form.FormClosed += F2_FormClosed;
            }



            if (dgvPeliculasActivas.CurrentCell.ColumnIndex == 9)
            {
                if (MessageBox.Show("¿Estas seguro que quieres desabilitar esta pelicula?", "Desabilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Enabled = false;
                    if (await DesabilitarPeliculaAsync(idPelicula(), 1) != null)
                    {  
                        MessageBox.Show("Se desabilito correctamente");
                        dgvPeliculasActivas.Rows.Clear();
                        await CargarDGVAsync();
                    }
                    else
                    {
                        MessageBox.Show("Ah ocurrido un error");
                    }
                    this.Enabled = true;
                }
            }

        }

        public int idPelicula()
        {
            int id = 0;
            id = Convert.ToInt32(dgvPeliculasActivas.CurrentRow.Cells[0].Value.ToString());
            return id;
        }

        public int idPeliculaDesavilitado()
        {
            int id = 0;
            id = Convert.ToInt32(dgvPeliculasBajas.CurrentRow.Cells[0].Value.ToString());
            return id;
        }


        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox1.Checked == true)
            {
                checkBox1.Enabled = false;
                dgvPeliculasBajas.Visible = true;
                dgvPeliculasActivas.Visible = false;
                dgvPeliculasBajas.Rows.Clear();
                await CargarDGVAsync();
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                dgvPeliculasBajas.Visible = false;
                dgvPeliculasActivas.Visible = true;
                dgvPeliculasActivas.Rows.Clear();
                await CargarDGVAsync();
                checkBox1.Enabled = true;

            }
        }

        private async void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = false;
            await CargarDGVAsync();
            this.Enabled = true;
        }

        private async void dgvPeliculasBajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPeliculasBajas.CurrentCell.ColumnIndex == 9)
            {
                if (MessageBox.Show("¿Estas seguro que quieres habilitar esta pelicula?", "Habilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Enabled = false;
                    if (await DesabilitarPeliculaAsync(idPeliculaDesavilitado(), 0) != null)
                    {
                        MessageBox.Show("Se habilito correctamente");
                        dgvPeliculasBajas.Rows.Clear();
                        await CargarDGVAsync();
                    }
                    else
                    {
                        MessageBox.Show("Ah ocurrido un error");
                    }
                    this.Enabled = true;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                button1.Enabled = false;
                await CargarDGVFiltrada();
                textBox1.Text = "";
                button1.Enabled = true;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;    
            await CargarDGVAsync();
            button2.Enabled = true;
        }

        public bool ValidarCampos()
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Debe consultar un titulo", "Advertencia");
                return false;
            }
            return true;
        }
    }
}
