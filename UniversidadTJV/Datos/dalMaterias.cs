using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalMaterias
    {
        entMaterias materiaEnt = new entMaterias();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;

        //Métodos
        public DataTable ListarMaterias()
        {
            DataTable datos = new DataTable();
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_materias");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entMaterias ConsultarMaterias(int idMateria)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_materia", idMateria.ToString() } };
                conexion.sqlQuery("sp_consultar_materia", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos de la materia, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.materiaEnt.Nombre = fila["nombre"].ToString();
                    this.materiaEnt.Codigo = fila["codigo"].ToString();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.materiaEnt;
        }

        public string EliminarMateria(int idMateria)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_materia", idMateria.ToString() } };
                conexion.sqlQuery("sp_eliminar_materia", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La materia fue eliminada";
            }
            catch (SqlException ex)
            {
                mensaje = "La materia no pudo ser eliminada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string AgregarMateria(string nombre, string codigo, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[4, 2] {{  "@nombre", nombre},
                                                         {  "@codigo", codigo},
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_materia", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "La materia fue ingresada";
            }
            catch (SqlException ex)
            {
                mensaje = "La materia no pudo ser ingresada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string ModificarMateria(string nombre, string codigo, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[3, 2] {{  "@nombre", nombre},
                                                         {  "@codigo", codigo},
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_codigo", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "la materia fue modificada";
            }
            catch (SqlException ex)
            {
                mensaje = "la materia no pudo ser modificada";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable BuscarMaterias(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_materia", parametros);
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
