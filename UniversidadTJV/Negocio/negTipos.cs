using Entidades;
using Datos;
using System.Data;

namespace Negocios
{
    public class negTipos
    {
        dalTipos _TiposDatos = new dalTipos();
        public DataTable ListarTipos()
        {
            return _TiposDatos.ListarTipos();
        }

        public entTipos ConsultarTipo(int idTipo)
        {
            return _TiposDatos.ConsultarTipos(idTipo);
        }

        public string EliminarTipo(int idTipo)
        {
            return _TiposDatos.EliminarTipo(idTipo);
        }

        public string AgregarTipo(string nombre, string tipo, int usuario_ingresa, int usuario_modifica)
        {
            return _TiposDatos.AgregarUsuario(nombre, tipo, usuario_ingresa, usuario_modifica);
        }

        public string ModificarTipo(string nombre, string tipo, int usuario_modifica)
        {
            return _TiposDatos.ModificarUsuario(nombre, tipo, usuario_modifica);
        }

        public DataTable BuscarTipo(string valor)
        {
            return _TiposDatos.BuscarTipos(valor);
        }
    }
}
