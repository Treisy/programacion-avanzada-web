using System;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalTipos
    {
        entTipos tipoEnt = new entTipos();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;
        System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();

        //Métodos
        public DataTable ListarTipos()
        {
            DataTable datos = new DataTable();
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_tipos");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entTipos ConsultarTipos(int idTipo)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_tipo", idTipo.ToString() } };
                conexion.sqlQuery("sp_consultar_tipo", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del tipo, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.tipoEnt.Nombre = fila["nombre"].ToString();
                    this.tipoEnt.Tipo = fila["tipo"].ToString();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.tipoEnt;
        }

        public string EliminarTipo(int idTipo)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_tipo", idTipo.ToString() } };
                conexion.sqlQuery("sp_eliminar_tipo", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El tipo fue eliminado";
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

        public string AgregarTipo(string nombre, string tipo, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@nombre", nombre},
                                                         {  "@tipo", tipo},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_tipo", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El tipo fue ingresado";
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

        public string ModificarTipo(string nombre, string tipo, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[3, 2] {{  "@nombre", nombre},
                                                         {  "@tipo", tipo},
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_tipo", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El tipo fue modificado";
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

        public DataTable BuscarTipos(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_tipo", parametros);
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
