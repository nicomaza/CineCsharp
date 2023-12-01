using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Dominio
{
    public class Parametro
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public Parametro()
        {
            Name = "";
            Value = null;
        }

        public Parametro(string nombre, object value)
        {
            this.Value = value;
            this.Name = nombre;
        }

       
    }
}
