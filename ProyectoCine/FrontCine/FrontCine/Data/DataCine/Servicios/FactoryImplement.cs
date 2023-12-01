using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios
{
    public class FactoryImplement : ServiceFactory
    {
        public override IService crearservicio()
        {
            return new Servicio();
        }
    }
}
