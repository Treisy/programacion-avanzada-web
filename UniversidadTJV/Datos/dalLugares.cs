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
        bool mensaje;

        //Métodos
        public DataTable ListarLugares()
        {
            DataTable datos = new DataTable();
            entLugares lugares = new entLugares();
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_Usuarios");
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
