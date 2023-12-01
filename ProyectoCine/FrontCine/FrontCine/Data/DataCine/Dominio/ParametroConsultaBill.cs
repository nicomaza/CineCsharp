using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Dominio
{
    public class ParametroConsultaBill
    {
        public string fechainicio { get; set; }
        public string fechafin { get; set; }
  

        public ParametroConsultaBill(string fechainicio, string fechafin)
        {
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
            
        }
    }
}
