using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class negAlumnos
    {
        dalAlumnos _AlumnosDatos = new dalAlumnos();

        public DataTable ListarAlumnos()
        {
            return _AlumnosDatos.ListarAlumnos();
        }

        public entAlumnos ConsultarAlumnos(int idAlumno)
        {
            return _AlumnosDatos.ConsultarAlumnos(idAlumno);
        }

        public string EliminarAlumno(int idAlumno)
        {
            return _AlumnosDatos.EliminarAlumno(idAlumno);
        }

        public string AgregarAlumno(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int id_carrera, int usuario_ingresa, int usuario_modifica)
        {
            return _AlumnosDatos.AgregarAlumno(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, id_carrera, usuario_ingresa, usuario_modifica);
        }

        public string ModificarAlumno(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int id_carrera, int usuario_modifica)
        {
            return _AlumnosDatos.ModificarAlumno(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, id_carrera, usuario_modifica);
        }

        public DataTable BuscarAlumnos(string valor)
        {
            return _AlumnosDatos.BuscarAlumnos(valor);
        }
    }
}
