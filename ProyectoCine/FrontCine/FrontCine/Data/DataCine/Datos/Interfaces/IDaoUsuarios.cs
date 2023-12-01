using DataCine.Dominio;

namespace DataCine.Datos.Interfaces
{
    public interface IDaoUsuarios
    {
        bool getUsers(string username, string pass); 
    }
}
