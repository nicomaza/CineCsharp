using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Dominio.FuncionContainer
{
    public class FuncionResumida
    {
        public int id_pelicula { get; set; }
        public int id_horario { get; set; }
        public int id_audio { get; set; }
        public int id_sala { get; set; }
        public int precio { get; set; }
        public DateTime fecha { get; set; }
        public FuncionResumida()
        {

        }
    }
}
