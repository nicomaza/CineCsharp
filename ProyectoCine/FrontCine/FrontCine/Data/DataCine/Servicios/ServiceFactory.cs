using DataCine.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios
{
    public abstract class ServiceFactory
    { 
        public abstract IService crearservicio();
    }
}
