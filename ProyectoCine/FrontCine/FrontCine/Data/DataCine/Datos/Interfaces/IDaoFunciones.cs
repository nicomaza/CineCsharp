
using DataCine.Dominio;
using DataCine.Dominio.FuncionContainer;
using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoFunciones
    {
        int AltaFuncion(FuncionResumida fr);
        int BajaLogicaFuncion(int id_funcion);
        List<Pelicula> consultarPeliculas();
        List<Horario> consutlarHorarios();
        List<Audio> consultarAudios();
        List<Sala> consultarSalas();
        List<Funcion> consultarFunciones();
        List<Funcion> consultarFuncionesParametros(ParametroFuncion parametroFuncion);
        
    }
}
