using System;
using Negocios;
using System.Data;

namespace Ejecutar
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. Usuarios");
            Console.WriteLine("2. Tipos");
            Console.WriteLine("3. Lugares");
            Console.WriteLine("4. Profesores");
            Console.Write("Seleccione el módulo que desea utilizar:  ");
            string seccion;
            seccion = Console.ReadLine();

            switch (seccion)
            {
                case "1":
                    moduloUsuarios();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }


            negLugares lugares = new negLugares();
            negTipos tipos = new negTipos();
            negProfesores profesores = new negProfesores();
        }

        static void moduloUsuarios()
        {
            negUsuarios usuarios = new negUsuarios();
            string id;
            string valor;
            string cedula, nombre_usuario, contrasena, nombre, primer_apellido, segundo_apellido;

            Console.WriteLine("1. Listado");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Agregar");
            Console.WriteLine("5. Modificar");
            Console.WriteLine("6. Buscar");
            Console.Write("Seleccione la opción que desea utilizar:  ");
            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Listado de Usuarios");
                    foreach (DataRow dataRow in usuarios.ListarUsuarios().Rows)
                    {
                        foreach (var item in dataRow.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
                case "2":
                    Console.Write("Ingrese el ID que desea consultar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(usuarios.ConsultarUsuario(Int32.Parse(id)).Nombre);
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(usuarios.EliminarUsuario(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos del usuario que desea ingresar: ");
                    Console.Write("Cedula: ");
                    cedula = Console.ReadLine();
                    Console.Write("Usuario: ");
                    nombre_usuario = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    contrasena = Console.ReadLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Primer Apellido: ");
                    primer_apellido = Console.ReadLine();
                    Console.Write("Seguno Apellido: ");
                    segundo_apellido = Console.ReadLine();
                    Console.WriteLine(usuarios.AgregarUsuario(cedula, nombre_usuario, contrasena, nombre, primer_apellido, segundo_apellido, 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese un usuario que quiera buscar: ");
                    valor = Console.ReadLine();
                    Console.WriteLine(usuarios.BuscarUsuario(valor).NombreUsuario);
                    break;
            }
        }
    }
}
