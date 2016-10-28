using Entidades;
using Datos;
using System.Data;

namespace Negocios
{
    public class negProfesores
    {
        dalProfesores _ProfesoresDatos = new dalProfesores();

        public DataTable ListarProfesores()
        {
            return _ProfesoresDatos.ListarProfesores();
        }

        public entProfesores ConsultarProfesores(int idProfesor)
        {
            return _ProfesoresDatos.ConsultarProfesores(idProfesor);
        }

        public string EliminarProfesor(int idProfesor)
        {
            return _ProfesoresDatos.EliminarProfesor(idProfesor);
        }

        public string AgregarProfesor(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int usuario_ingresa, int usuario_modifica)
        {
            return _ProfesoresDatos.AgregarProfesor(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, usuario_ingresa, usuario_modifica);
        }

        public string ModificarProfesor(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int usuario_modifica)
        {
            return _ProfesoresDatos.ModificarProfesor(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, usuario_modifica);
        }

        public DataTable BuscarProfesor(string valor)
        {
            return _ProfesoresDatos.BuscarProfesores(valor);
        }
    }
}
