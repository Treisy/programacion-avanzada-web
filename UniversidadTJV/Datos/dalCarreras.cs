using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dalCarreras
    {
        entCarreras carreraEnt = new entCarreras();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;

        //Métodos
        public DataTable ListarCarreras()
        {
            DataTable datos = new DataTable();
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_carreras");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entCarreras ConsultarCarreras(int idCarrera)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_carrera", idCarrera.ToString() } };
                conexion.sqlQuery("sp_consultar_carrera", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos de la carrera, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.carreraEnt.Nombre = fila["nombre"].ToString();
                    this.carreraEnt.Descripcion = fila["descripcion"].ToString();
                    this.carreraEnt.IdProfesor = Convert.ToInt32(fila["id_profesor"]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.carreraEnt;
        }

        public string EliminarCarrera(int idCarrera)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_carrera", idCarrera.ToString() } };
                conexion.sqlQuery("sp_eliminar_carrera", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La Carrera fue eliminada";
            }
            catch (SqlException ex)
            {
                mensaje = "La Carrera no pudo ser eliminada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string AgregarCarrera(string nombre, string descripcion, int id_profesor, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[5, 2] {{  "@nombre", nombre},
                                                         {  "@descripcion", descripcion},
                                                         {  "@id_profesor", id_profesor.ToString() },
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_carrera", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La carrera fue ingresada";
            }
            catch (SqlException ex)
            {
                mensaje = "La carrera no pudo ser ingresada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string ModificarCarrera(string nombre, string descripcion, int id_profesor, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@nombre", nombre},
                                                         {  "@descripcion", descripcion},
                                                         {  "@id_profesor", id_profesor.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_carrera", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La carrera fue modificada";
            }
            catch (SqlException ex)
            {
                mensaje = "La carrera no pudo ser modificada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable BuscarCarreras(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_carrera", parametros);
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
