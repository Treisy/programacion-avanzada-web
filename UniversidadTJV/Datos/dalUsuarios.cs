using System;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class dalUsuarios
    {
        entUsuarios usuarioEnt = new entUsuarios();
        ConexionBD conexion = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        DataTable datos = new DataTable();
        string mensaje;

        //Métodos
        public DataTable ListarUsuarios()
        {
            entUsuarios usuarios = new entUsuarios();
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.conectar();
                conexion.sqlQuery("sp_listado_usuarios");
                datos = conexion.ejecutarConsultaSQL();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return datos;
        }

        public entUsuarios ConsultarUsuarios(int idUsuario)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_usuario", idUsuario.ToString() } };
                conexion.sqlQuery("sp_consultar_usuario", parametros);
                datos = conexion.ejecutarConsultaSQL();

                //Se cargan los datos del usuario, de la BD a los atributos de la clase
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    this.usuarioEnt.Nombre = fila["nombre"].ToString();
                    this.usuarioEnt.Nombre = fila["cedula"].ToString();
                    this.usuarioEnt.NombreUsuario = fila["nombre_usuario"].ToString();
                    this.usuarioEnt.PrimerApellido = fila["primer_apellido"].ToString();
                    this.usuarioEnt.SegundoApellido = fila["segundo_apellido"].ToString();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return this.usuarioEnt;
        }

        public string EliminarUsuario(int idUsuario)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[1, 2] { { "@id_usuario", idUsuario.ToString() } };
                conexion.sqlQuery("sp_eliminar_usuario", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El usuario fue eliminado";
            }
            catch (SqlException ex)
            {
                mensaje = "El usuario no pudo ser eliminado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string AgregarUsuario(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, int usuario_ingresa, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[8, 2] {{  "@cedula", cedula},
                                                         {  "@nombre_usuario", nombre_usuario},
                                                         {  "@contrasena", contrasena},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido} ,
                                                         {  "@usuario_ingresa", usuario_ingresa.ToString() },
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_agregar_usuario", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El usuario fue ingresado";
            }
            catch (SqlException ex)
            {
                mensaje = "El usuario no pudo ser ingresado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public string ModificarUsuario(string cedula, string nombre_usuario, string contrasena, string nombre, string primer_apellido, string segundo_apellido, int usuario_modifica)
        {
            try
            {
                conexion.conectar();
                String[,] parametros = new String[7, 2] {{  "@cedula", cedula},
                                                         {  "@nombre_usuario", nombre_usuario},
                                                         {  "@contrasena", contrasena},
                                                         {  "@nombre",nombre},
                                                         {  "@primer_apellido", primer_apellido},
                                                         {  "@segundo_apellido", segundo_apellido} ,
                                                         {  "@usuario_modifica", usuario_modifica.ToString()}};
                conexion.sqlQuery("sp_modificar_usuario", parametros);
                datos = conexion.ejecutarConsultaSQL();
                mensaje = "El usuario fue modificado";
            }
            catch (SqlException ex)
            {
                mensaje = "El usuario no pudo ser modificado";
                Console.WriteLine(ex);
            }
            return mensaje;
        }

        public DataTable BuscarUsuarios(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                conexion.conectar();
                valor = "%" + valor + "%";
                String[,] parametros = new String[1, 2] { { "@valor", valor } };
                conexion.sqlQuery("sp_buscar_usuario", parametros);
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
