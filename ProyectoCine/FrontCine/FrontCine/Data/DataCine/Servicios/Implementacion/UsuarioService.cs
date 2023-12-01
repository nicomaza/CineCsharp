using DataCine.Datos.Implementaciones;
using DataCine.Datos.Interfaces;
using DataCine.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCine.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        IDaoUsuarios dao;

        public UsuarioService()
        {
            dao = new DaoUsuarios();
        }

        public bool getUsers(string username, string pass)
        {
            return dao.getUsers(username, pass);
        }
    }
}
