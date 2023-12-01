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

namespace TpLab.Genagamer
{
    public partial class consulta_funciones_mas_vendidas : Form
    {
        public consulta_funciones_mas_vendidas()
        {
            InitializeComponent();
        }

        private void consulta_funciones_mas_vendidas_Load(object sender, EventArgs e)
        {
            CBgeneros.SelectedIndex = -1;
            CBgeneros.DropDownStyle = ComboBoxStyle.DropDownList;

            CBmes.SelectedIndex = -1;
            CBmes.DropDownStyle = ComboBoxStyle.DropDownList;

            cargarGeneros();
            cargarMeses();


            txtCantidadTickets.Enabled = false;




        }
        private void cargarMeses()
        {

             
            CBmes.Items.Add("Enero");
            CBmes.Items.Add("Febrero");
            CBmes.Items.Add("Marzo");
            CBmes.Items.Add("Abril");
            CBmes.Items.Add("Mayo");
            CBmes.Items.Add("Junio");
            CBmes.Items.Add("Julio");
            CBmes.Items.Add("Agosto");
            CBmes.Items.Add("Septiembre");
            CBmes.Items.Add("Octubre");
            CBmes.Items.Add("Noviembre");
            

            CBmes.Items.Add("Diciembre");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool ValidarDatos()
        {
            bool estado = true;
            if (CBgeneros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un genero");
                estado = false;
            }else if(CBmes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un mes");
                estado = false;
            }
            return estado;
                

        }

        private void DTPmes_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cargarGeneros()
        {
            CBgeneros.DataSource = Consultas.consultarTabla(@"select * from generos");
            CBgeneros.DisplayMember = "genero";
            CBgeneros.ValueMember = "id_genero";
        }

        private void CBgeneros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea volver al menú anterior?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (ValidarDatos())
            {
                string genero = "'"+CBgeneros.Text+"'" ;
                int mes = CBmes.SelectedIndex + 1;



                DataTable TablaPeliculas = Consultas.consultarTabla(@"  select top 5 count(t.nro_ticket) as 'cantidad de ventas',f.id_pelicula,p.titulo_original,g.genero
from peliculas p join funciones f on p.id_pelicula = f.id_pelicula
join peliculas_generos pg on p.id_pelicula = pg.id_pelicula
join generos g on pg.id_genero = g.id_genero
join salas s on f.id_sala = s.id_sala
join tickets t on f.id_funcion = t.id_funcion
where month(f.fecha) =" + mes+ @"and year(f.fecha) = year(getdate())
and "+ genero+@" in (select genero
				from peliculas_generos pg1
				join generos g1 on pg1.id_genero = g1.id_genero
				where f.id_pelicula = pg1.id_pelicula
				and g1.id_genero = g.id_genero)
group by f.id_pelicula,p.titulo_original,g.genero
order by 1 desc  ");

               

                foreach ( DataRow row in TablaPeliculas.Rows)
                {
                    int id_funcion = Convert.ToInt32(row["id_pelicula"]);

                    
                    string tituloPelicula = row["titulo_original"].ToString();
                   
              






                    dataGridView1.Rows.Add(id_funcion.ToString(), tituloPelicula, genero);
                    

                }




                //select top 5 count(t.nro_ticket),f.id_funcion,p.fecha_estreno,p.titulo_original,g.genero,s.id_sala
                //                                                        from funciones f join peliculas p on f.id_pelicula = p.id_pelicula
                //                                                         join tickets t on f.id_funcion = t.id_funcion
                //                                                          join salas s on f.id_sala = s.id_sala
                //                                                            join peliculas_generos pg on p.id_pelicula = pg.id_pelicula
                //                                                              join generos g on pg.id_genero = g.id_genero
                //group by f.id_funcion,p.fecha_estreno,p.titulo_original,g.genero,s.id_sala order by 1 desc
                //                                                      where exists(select top 5 count(tickets.nro_ticket),id_funcion from tickets where f.id_funcion = tickets.id_funcion group by id_funcion order by 1 desc ) and month(p.fecha_estreno) = " + mes + " and g.id_genero = " + id_genero + " group by f.id_funcion,p.fecha_estreno,p.titulo_original,g.genero,s.id_sala order by 1 desc

                //for (int i = 0; i < TablaPeliculas.Rows.Count; i++)
                //{
                //    int id_funcion = Convert.ToInt32(TablaPeliculas.Rows[i]["id_funcion"]);
                //    string fecha = TablaPeliculas.Rows[i]["fecha_estreno"].ToString();
                //    string tituloPelicula = TablaPeliculas.Rows[i]["titulo_original"].ToString();
                //    string generoPelicula = TablaPeliculas.Rows[i]["genero"].ToString();
                //    int sala = Convert.ToInt32(TablaPeliculas.Rows[i]["id_sala"]);







                //    dataGridView1.Rows.Add(id_funcion.ToString(), fecha, tituloPelicula, generoPelicula, sala.ToString());

                //}


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarTickets_Click(object sender, EventArgs e)
        {
            DataTable tabla = Consultas.consultarTabla(@" SELECT COUNT(nro_ticket) 'Cantidad de Entradas Vendidas'
                                FROM Tickets t join Funciones f on t.id_funcion = f.id_funcion
                                join Peliculas p on f.id_pelicula = p.id_pelicula
                                join Peliculas_Generos pg on pg.id_pelicula = p.id_pelicula
                                join Generos g on g.id_genero = pg.id_genero
                                WHERE nro_ticket in (SELECT nro_ticket
                                FROM Comprobantes c join tickets t1 on
                                c.id_comprobante = t1.id_comprobante
                                WHERE year(fecha) = year(GETDATE()) - 1) and
                                genero like 'Accion%'");

            foreach( DataRow row in tabla.Rows)
            {
                int cantidad = Convert.ToInt32( row["Cantidad de Entradas Vendidas"].ToString());
                txtCantidadTickets.Text = cantidad.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
