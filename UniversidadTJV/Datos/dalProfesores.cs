using System;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalProfesores
    {
        entProfesores profesorEnt = new entProfesores();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();
        string mensaje;

        //Métodos
        public DataTable ListarProfesores()
        {
            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_profesores");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entProfesores ConsultarProfesores(int idProfesor)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_profesor", idProfesor.ToString() } };
                conexion.sqlQuery("sp_consultar_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del profesor, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.profesorEnt.Cedula = fila["cedula"].ToString();
                    this.profesorEnt.Nombre = fila["nombre"].ToString();
                    this.profesorEnt.PrimerApellido = fila["primer_apellido"].ToString();
                    this.profesorEnt.SegundoApellido = fila["segundo_apellido"].ToString();
                    //this.profesorEnt.FechaNacimiento = fila["fecha_nacimiento"].ToString();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.profesorEnt;
        }

        public string EliminarProfesor(int idProfesor)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_profesor", idProfesor.ToString() } };
                conexion.sqlQuery("sp_eliminar_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El profesor fue eliminado";
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

        public string AgregarProfesor(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[7, 2] {{  "@cedula", cedula},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido},
                                                         {  "@fecha_nacimiento", fecha_nacimiento.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El profesor fue ingresado";
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

        public string ModificarProfesor(string cedula, string nombre, string primer_apellido, string segundo_apellido, string fecha_nacimiento, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[6, 2] {{  "@cedula", cedula},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido},
                                                         {  "@fecha_nacimiento", fecha_nacimiento.ToString()},
                                                         {  "@profesor_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El profesor fue modificado";
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

        public DataTable BuscarProfesores(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public string AgregarTiposXProfesor(string descripcion, int id_profesor, int id_tipo, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[5, 2] {{  "@descripcion", descripcion},
                                                         {  "@id_profesor", id_profesor.ToString()},
                                                         {  "@id_tipo", id_tipo.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_tipo_x_profesor", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La información fue ingresada";
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

        public DataTable ListarTiposXProfesor(int idProfesor)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_profesor", idProfesor.ToString() } };
                conexion.sqlQuery("sp_listado_tipos_x_profseor", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public string EliminarTiposXProfesor(int id)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id", id.ToString() } };
                conexion.sqlQuery("sp_eliminar_tipo_x_profesor", parametros);
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

        public string AgregarProfesorXLugar(int id_profesor, int id_lugar, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@id_profesor", id_profesor.ToString()},
                                                         {  "@id_lugar", id_lugar.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_profesor_x_lugar", parametros);
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

        public DataTable ListarProfesoresXLugar(int idProfesor)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_profesor", idProfesor.ToString() } };
                conexion.sqlQuery("sp_listado_profesores_x_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }
    }
}
