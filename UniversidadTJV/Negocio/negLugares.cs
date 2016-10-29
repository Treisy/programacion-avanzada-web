using Datos;
using System.Data;

namespace Negocios
{
    public class negLugares
    {
        dalLugares _LugaresDatos = new dalLugares();

        public DataTable ListarLugares()
        {
            return _LugaresDatos.ListarLugares();
        }
    }
}
