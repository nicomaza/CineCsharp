using LibreriaTp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.ClasesGenericas
{
    public class facturabill
    {
        public string Forma_Pago { get; set; }  
        public int Cantidad_Comprobantes { get; set; }
        public int Importes { get; set; }

        public facturabill(string forma_Pago, int cantidad_Comprobantes, int importes)
        {
            Forma_Pago = forma_Pago;
            Cantidad_Comprobantes = cantidad_Comprobantes;
            Importes = importes;
        }
        public facturabill()
        {
            Forma_Pago = "";
            Cantidad_Comprobantes = 0;
            Importes = 0;
        }



    }
}
