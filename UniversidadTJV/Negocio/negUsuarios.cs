using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class negUsuarios
    {
        dalUsuarios _UsuariosDatos = new dalUsuarios();

        public DataTable ListarUsuarios()
        {
            return _UsuariosDatos.ListarUsuarios();
        }

        public entUsuarios ConsultarUsuario(int idUsuario)
        {
            return _UsuariosDatos.ConsultarUsuarios(idUsuario);
        }

        public string EliminarUsuario(int idUsuario)
        {
            return _UsuariosDatos.EliminarUsuario(idUsuario);
        }

        public string AgregarUsuario(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, int usuario_ingresa, int usuario_modifica)
        {
            return _UsuariosDatos.AgregarUsuario(cedula, nombre_usuario, contrasena, nombre, primer_apellido, segundo_apellido, usuario_ingresa, usuario_modifica);
        }

        public string ModificarUsuario(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, int usuario_modifica)
        {
            return _UsuariosDatos.ModificarUsuario(cedula, nombre_usuario, contrasena, nombre, primer_apellido, segundo_apellido, usuario_modifica);
        }

        public entUsuarios BuscarUsuario(string valor)
        {
            return _UsuariosDatos.BuscarUsuarios(valor);
        }
    }
}
