using DataCine.Datos.Interfaces;
using DataCine.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DataCine.Datos.Implementaciones
{
    public class DaoUsuarios : IDaoUsuarios
    {
        public bool getUsers(string username, string pass)
        {
            List<Parametro> lparam = new List<Parametro>();
            lparam.Add(new Parametro("@nombre",username));
            lparam.Add(new Parametro("@contra", pass));

            if (HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_USUARIO", lparam).Rows.Count > 0)
            {

                return true;
            }
            //int a = (HelperDAO.getinstancia().ConsultarDB("SP_CONSULTAR_USUARIO", lparam).Rows.Count);
            return false;
        }
    }
}
