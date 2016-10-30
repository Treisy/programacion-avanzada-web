using Datos;
using Entidades;
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
        public entLugares ConsultarLugar(int idLugar)
        {
            return _LugaresDatos.ConsultarLugar(idLugar);
        }
        public entLugares ConsultarLugarPadreId(int padreId)
        {
            return _LugaresDatos.ConsultarLugarPadreId(padreId);
        }

        public string EliminarLugar(int idLugar)
        {
            return _LugaresDatos.EliminarLugar(idLugar);
        }

        public string AgregarLugar(string nombre, int padre_id, int usuario_ingresa, int usuario_modifica)
        {
            return _LugaresDatos.AgregarLugar(nombre, padre_id, usuario_ingresa, usuario_modifica);
        }

        public string ModificarLugar(string nombre, int padre_id, int usuario_modifica)
        {
            return _LugaresDatos.ModificarLugar(nombre, padre_id, usuario_modifica);
        }

        public DataTable BuscarLugar(string valor)
        {
            return _LugaresDatos.BuscarLugares(valor);
        }
    }
}
