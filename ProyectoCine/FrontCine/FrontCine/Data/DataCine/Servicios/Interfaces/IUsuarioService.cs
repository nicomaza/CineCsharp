using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        bool getUsers(string username, string pass);
    }
}
