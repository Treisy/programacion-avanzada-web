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

        public DataTable BuscarProfesores(string valor)
        {
            return _ProfesoresDatos.BuscarProfesores(valor);
        }

        public string AgregarTiposXProfesor(string descripcion, int id_profesor, int id_tipo, int usuario_ingresa, int usuario_modifica)
        {
            return _ProfesoresDatos.AgregarTiposXProfesor(descripcion, id_profesor, id_tipo, usuario_ingresa, usuario_modifica);
        }

        public DataTable ListarTiposXProfesor(int idProfesor)
        {
            return _ProfesoresDatos.ListarTiposXProfesor(idProfesor);
        }

        public string EliminarTiposXProfesor(int id)
        {
            return _ProfesoresDatos.EliminarTiposXProfesor(id);
        }

        public string AgregarProfesorXLugar(int id_profesor, int id_lugar, int usuario_ingresa, int usuario_modifica)
        {
            return _ProfesoresDatos.AgregarProfesorXLugar(id_profesor, id_lugar, 1, 1);
        }

        public DataTable ListarProfesoresXLugar(int idProfesor)
        {
            return _ProfesoresDatos.ListarProfesoresXLugar(idProfesor);
        }
    }
}
