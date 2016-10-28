using System;
using System.Linq;
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
        string mensaje;

        //Métodos
        public DataTable ListarProfesores()
        {
            DataTable datos = new DataTable();
            entProfesores profesores = new entProfesores();
            ConexionBD conexion = new ConexionBD();

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
                mensaje = "El profesor no pudo ser eliminado";
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
                mensaje = "El profesor no pudo ser ingresado";
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
                mensaje = "El profesor no pudo ser modificado";
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
    }
}
