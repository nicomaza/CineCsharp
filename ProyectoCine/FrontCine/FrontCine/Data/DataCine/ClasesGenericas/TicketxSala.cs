using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.ClasesGenericas
{
    public class TIcketxSala
    {
        public int tickets { get; set; }
        public string sala { get; set; }

        public TIcketxSala(int tickets, string sala)
        {
            this.tickets = tickets;
            this.sala = sala;
        }
    }
}
