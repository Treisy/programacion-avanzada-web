using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalAlumnos
    {
        entAlumnos alumnoEnt = new entAlumnos();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;
        System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();

        //Métodos
        public DataTable ListarAlumnos()
        {
            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_alumnos");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entAlumnos ConsultarAlumnos(int idAlumno)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_alumno", idAlumno.ToString() } };
                conexion.sqlQuery("sp_consultar_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del alumno, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.alumnoEnt.Cedula = fila["cedula"].ToString();
                    this.alumnoEnt.Nombre = fila["nombre"].ToString();
                    this.alumnoEnt.PrimerApellido = fila["primer_apellido"].ToString();
                    this.alumnoEnt.SegundoApellido = fila["segundo_apellido"].ToString();
                    this.alumnoEnt.FechaNacimiento = Convert.ToDateTime(fila["fecha_nacimiento"]);
                    this.alumnoEnt.IdCarrera = Convert.ToInt32(fila["id_carrera"]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.alumnoEnt;
        }

        public string EliminarAlumno(int idAlumno)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_alumno", idAlumno.ToString() } };
                conexion.sqlQuery("sp_eliminar_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El alumno fue eliminado";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString()); ;
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string AgregarAlumno(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int id_carrera, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[8, 2] {{  "@cedula", cedula},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido},
                                                         {  "@fecha_nacimiento", fecha_nacimiento.ToString()},
                                                         {  "@id_carrera", id_carrera.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El alumno fue ingresado";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string ModificarAlumno(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int id_carrera, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[7, 2] {{  "@cedula", cedula},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido},
                                                         {  "@fecha_nacimiento", fecha_nacimiento.ToString()},
                                                         {  "@id_carrera", id_carrera.ToString()},
                                                         {  "@alumno_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El alumno fue modificado";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable BuscarAlumnos(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
                Console.WriteLine(ex);
            }
            return datos;
        }

        public string AgregarAlumnoXLugar(int id_alumno, int id_lugar, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@id_alumno", id_alumno.ToString()},
                                                         {  "@id_lugar", id_lugar.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_alumno_x_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "Los datos fueron almacenados";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            return mensaje;
        }

        public DataTable ListarAlumnosXLugar(int idAlumno)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_alumno", idAlumno.ToString() } };
                conexion.sqlQuery("sp_listado_alumnos_x_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public string AgregarTiposXAlumno(string descripcion, int id_alumno, int id_tipo, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[5, 2] {{  "@descripcion", descripcion},
                                                         {  "@id_alumno", id_alumno.ToString()},
                                                         {  "@id_tipo", id_tipo.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_tipo_x_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La información fue ingresada";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable ListarTiposXAlumno(int idAlumno)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_alumno", idAlumno.ToString() } };
                conexion.sqlQuery("sp_listado_tipos_x_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public string EliminarTiposXAlumno(int id)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id", id.ToString() } };
                conexion.sqlQuery("sp_eliminar_tipo_x_alumno", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La información fue eliminada";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            return mensaje;
        }

    }
}
