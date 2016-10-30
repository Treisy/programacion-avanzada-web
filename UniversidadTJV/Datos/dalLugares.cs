using System;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalLugares
    {
        entLugares lugarEnt = new entLugares();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;

        //Métodos
        public DataTable ListarLugares()
        {
            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_lugares");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entLugares ConsultarLugar(int idLugar)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_lugar", idLugar.ToString() } };
                conexion.sqlQuery("sp_consultar_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del lugar, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.lugarEnt.Nombre = fila["nombre"].ToString();
                    this.lugarEnt.PadreId = Convert.ToInt32(fila["padre_id"]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.lugarEnt;
        }

        public entLugares ConsultarLugarPadreId(int padreId)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@padre_id", padreId.ToString() } };
                conexion.sqlQuery("sp_consultar_lugar_padre_id", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del lugar, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.lugarEnt.Nombre = fila["nombre"].ToString();
                    this.lugarEnt.PadreId = Convert.ToInt32(fila["padre_id"]);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.lugarEnt;
        }

        public string EliminarLugar(int idLugar)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_lugar", idLugar.ToString() } };
                conexion.sqlQuery("sp_eliminar_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El lugar fue eliminado";
            }
            catch (SqlException ex)
            {
                mensaje = "El lugar no pudo ser eliminado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string AgregarLugar(string nombre, int padre_int, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@nombre", nombre},
                                                         {  "@padre_int", padre_int.ToString()},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El lugar fue ingresado";
            }
            catch (SqlException ex)
            {
                mensaje = "El lugar no pudo ser ingresado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string ModificarLugar(string nombre, int padre_id, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[3, 2] {{  "@nombre", nombre},
                                                         {  "@padre_id", padre_id.ToString()},
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_lugar", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El lugar fue modificado";
            }
            catch (SqlException ex)
            {
                mensaje = "El lugar no pudo ser modificado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable BuscarLugares(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_lugar", parametros);
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
