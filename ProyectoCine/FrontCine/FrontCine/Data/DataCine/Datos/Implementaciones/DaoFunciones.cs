
using DataCine.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataCine.Dominio;
using LibreriaTp;
using System.ComponentModel;
using DataCine.Dominio.FuncionContainer;

namespace DataCine.Datos.Implementaciones
{
    public class DaoFunciones : IDaoFunciones
    {
        public int AltaFuncion(FuncionResumida fr)
        {
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@id_pelicula", fr.id_pelicula));
            lista_parametros.Add(new Parametro("@id_horario", fr.id_horario));
            lista_parametros.Add(new Parametro("@id_audio", fr.id_audio));
            lista_parametros.Add(new Parametro("@id_sala", fr.id_sala));
            lista_parametros.Add(new Parametro("@precio", fr.precio));
            lista_parametros.Add(new Parametro("@fecha", fr.fecha.ToString("yyyy/M/dd")));
            return HelperDAO.getinstancia().UtilizarProcedimiento("SP_CREAR_FUNCION", lista_parametros);
        }
        //ejecutar sp baja_funcion
        public int BajaLogicaFuncion(int id_funcion)
        {
            List<Parametro> lista_parametro = new List<Parametro>();

            lista_parametro.Add(new Parametro("@id_funcion", id_funcion));




          return  HelperDAO.getinstancia().UtilizarProcedimiento("SP_DELETE_FUNCION", lista_parametro);
             

        }

        public List<Audio> consultarAudios()
        {
            List<Audio> lista_audios = new List<Audio>();
            DataTable tabla = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_AUDIOS");
            foreach ( DataRow row in tabla.Rows)
            {
                Audio audio_nuevo = new Audio();
                audio_nuevo.Id = Convert.ToInt32(row["id_audio"]);
                audio_nuevo.Nombre = row["descripcion"].ToString();
                lista_audios.Add(audio_nuevo);
            }
            return lista_audios;
        }

        public List<Funcion> consultarFunciones()
        {
            List<Funcion> lista_funciones = new List<Funcion>();
            DataTable tabla = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_FUNCIONES");
            foreach (DataRow row in tabla.Rows)
            {
                Funcion funcion_nueva = new Funcion();
                funcion_nueva.Id = Convert.ToInt32(row["id_funcion"]);
                funcion_nueva.Pelicula.Titulo_local = row["nombre_pelicula"].ToString();
                funcion_nueva.Horario.Nombre = row["horario"].ToString();
                funcion_nueva.Audio.Nombre = row["audio"].ToString();
                funcion_nueva.Sala.Nombre = row["sala"].ToString();
                funcion_nueva.Precio = Convert.ToInt32(row["precio"]);
                funcion_nueva.fecha = Convert.ToDateTime(row["fecha"]);
               
               
              
                lista_funciones.Add(funcion_nueva);
            }
            return lista_funciones;
        }

        public List<Funcion> consultarFuncionesParametros(ParametroFuncion parametroFuncion)
        {
            List<Funcion> lista_funciones = new List<Funcion>();
            DataTable tabla = new DataTable();

            SqlConnection cnn = HelperDAO.getinstancia().ObtenerConexion();

            try
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "CONSULTAR_FUNCION_PARAMETROS";
                comando.Parameters.AddWithValue("@id_pelicula", parametroFuncion.id_pelicula);
                
                comando.Parameters.AddWithValue("@fecha", parametroFuncion.fecha.ToString("yyyy/M/dd"));
                tabla.Load(comando.ExecuteReader());
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if(cnn != null || cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            

            foreach(DataRow row in tabla.Rows)
            {
                Funcion funcion = new Funcion();
                funcion.Id = Convert.ToInt32(row["id_funcion"]);
                funcion.Pelicula.Titulo_local = row["titulo_local"].ToString();
                funcion.Horario.Nombre = row["horario"].ToString();
                funcion.Audio.Nombre = row["audio"].ToString();
                funcion.Sala.Nombre = row["sala"].ToString();
                funcion.Precio = Convert.ToInt32(row["precio"]);
                funcion.fecha = Convert.ToDateTime(row["fecha"]);
                lista_funciones.Add(funcion);


            }

            return lista_funciones;




        }



        public List<Pelicula> consultarPeliculas()
        {
            List<Pelicula> lista_peliculas = new List<Pelicula>();
            DataTable tabla = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_PELICULAS");
            foreach (DataRow row in tabla.Rows)
            {
                Pelicula pelicula_nueva = new Pelicula();
                pelicula_nueva.Id = Convert.ToInt32(row["id_pelicula"]);
                pelicula_nueva.Titulo_local = row["titulo_local"].ToString();
                pelicula_nueva.Titulo_original = row["titulo_original"].ToString();
                pelicula_nueva.clasificacion.Id = Convert.ToInt32(row["id_calificacion"]);
                pelicula_nueva.pais.Id = Convert.ToInt32(row["id_pais"]);
                
                pelicula_nueva.Fecha_Estreno = Convert.ToDateTime(row["fecha_estreno"]);
                pelicula_nueva.duracion = Convert.ToInt32(row["duracion_min"]);
                pelicula_nueva.distribuidora.Id = Convert.ToInt32(row["id_distribuidora"]);
                pelicula_nueva.genero.Id = Convert.ToInt32(row["id_genero"]);
                pelicula_nueva.director.Id = Convert.ToInt32(row["id_director"]);
              
                pelicula_nueva.Baja = Convert.ToInt32(row["baja"]);
                lista_peliculas.Add(pelicula_nueva);


            }
            return lista_peliculas;
        }
     

        public List<Sala> consultarSalas()
        {
            List<Sala> lista_salas = new List<Sala>();
            DataTable tabla = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_SALAS");
            foreach(DataRow row in tabla.Rows)
            {
                Sala sala_nueva = new Sala();
                sala_nueva.Id = Convert.ToInt32(row["id_sala"]);
                sala_nueva.TipoSala.Id = Convert.ToInt32(row["id_tipo_sala"]);
                sala_nueva.Nombre = row["descripcion"].ToString();
                lista_salas.Add(sala_nueva);
            }
            return lista_salas;
        }

      

        public List<Horario> consutlarHorarios()
        {
            List<Horario> lista_horarios = new List<Horario>();
            DataTable tabla = HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_HORARIOS");
            foreach(DataRow row in tabla.Rows)
            {
                Horario horario_nuevo = new Horario();
                horario_nuevo.Id = Convert.ToInt32(row["id_horario"]);
                horario_nuevo.Nombre = row["horario"].ToString();
                lista_horarios.Add(horario_nuevo);
            }
            return lista_horarios;
        }

        //public Pelicula obtenerPelicula(int id_pelicula)
        //{
        //    SqlConnection cnn = HelperDAO.getinstancia().ObtenerConexion();
        //    DataTable tabla = new DataTable();

        //    try
        //    {
        //        cnn.Open();
        //        SqlCommand comando = new SqlCommand();
        //        comando.Connection = cnn;
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.CommandText = "CONSULTAR_PELICULA";
        //        comando.Parameters.AddWithValue("@id_pelicula",id_pelicula);

                
        //        tabla.Load(comando.ExecuteReader());

        //        Pelicula p = new Pelicula();
        //        p.Id = id_pelicula;
        //        p.Titulo_local = tabla.Columns["titulo_local"].ToString();
        //        p.Titulo_original = tabla.Columns["titulo_original"].ToString();
        //        p.Descripcion = tabla.Columns["descripcion"].ToString();
        //        p.pais.Id = 
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    finally
        //    {
        //        if (cnn != null || cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }
        //}
    }
}
