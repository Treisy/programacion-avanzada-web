using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionBD
    {
        //Atributos
        private SqlConnectionStringBuilder _conexionStr;
        private SqlConnection _coneccionBD;
        public SqlCommand instruccionSQL;
        private SqlDataAdapter _sqlAdaptador;
        private DataTable _datosConsulta;

       public ConexionBD()
        {
            _conexionStr = new SqlConnectionStringBuilder();
            _conexionStr.DataSource = "(local)";
            _conexionStr.InitialCatalog = "UniversidadTJV";
            _conexionStr.UserID = "sa";
            _conexionStr.Password = "sa";
        }

        public void conectar()
        {
            _coneccionBD = new SqlConnection(_conexionStr.ConnectionString);
            _coneccionBD.Open();
        }

        public void desconectar()
        {
            _coneccionBD.Close();
        }

        //Ejecutar un SP sin parámetros
        public void sqlQuery(string sqlQuery)
        {
            instruccionSQL = new SqlCommand(sqlQuery, _coneccionBD);
        }

        //Ejecutar un SP con parámetros
        public void sqlQuery(string storeProc, String[,] parametros)
        {
            instruccionSQL = new SqlCommand(storeProc, _coneccionBD);
            instruccionSQL.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parametros.GetLength(0); i++)
            {
                instruccionSQL.Parameters.Add(new SqlParameter(parametros[i, 0], parametros[i, 1]));
            }
        }

        public DataTable ejecutarConsultaSQL()
        {
            _sqlAdaptador = new SqlDataAdapter();
            _sqlAdaptador.SelectCommand = instruccionSQL;
            _datosConsulta = new DataTable();
            _sqlAdaptador.Fill(_datosConsulta);
            return _datosConsulta;
        }

    }
}
