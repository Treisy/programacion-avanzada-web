using System;
using Negocios;
using System.Data;

namespace Ejecutar
{
    class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();
        }

        static void menuPrincipal()
        {
            Console.WriteLine("1. Usuarios");
            Console.WriteLine("2. Tipos");
            Console.WriteLine("3. Lugares");
            Console.WriteLine("4. Profesores");
            Console.WriteLine("5. Alumnos");
            Console.WriteLine("6. Materias");
            Console.WriteLine("7. Carreras");
            Console.WriteLine("8. Configuraciones");
            Console.WriteLine("9. Matrícula");
            Console.WriteLine("10. Salir");
            Console.Write("Seleccione la opción que desea utilizar:  ");
            string seccion;
            seccion = Console.ReadLine();

            switch (seccion)
            {
                case "1":
                    moduloUsuarios();
                    break;
                case "2":
                    moduloTipos();
                    break;
                case "3":
                    moduloLugares();
                    break;
                case "4":
                    moduloProfesores();
                    break;
                case "5":
                    moduloAlumnos();
                    break;
                case "6":
                    moduloMaterias();
                    break;
                case "7":
                    moduloCarreras();
                    break;
                case "8":
                    //moduloConfiguraciones();
                    break;
                case "9":
                    //moduloMatriculas();
                    break;
                case "10":
                    break;
            }
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
            Console.WriteLine("5. Buscar");
            Console.Write("Seleccione la opción que desea utilizar:  ");
            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\n");
                    Console.WriteLine("Listado de Usuarios");
                    foreach (DataRow dataRow in usuarios.ListarUsuarios().Rows)
                    {
                        foreach (var item in dataRow.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    Console.WriteLine("\n");
                    Console.Write("Ingrese el ID que desea consultar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(usuarios.ConsultarUsuario(Int32.Parse(id)).Nombre);
                    break;
                case "3":
                    Console.WriteLine("\n");
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(usuarios.EliminarUsuario(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("\n");
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
                    Console.WriteLine("\n");
                    Console.Write("Ingrese un usuario que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = usuarios.BuscarUsuario(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        foreach (var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
            Console.WriteLine("\n");
            menuPrincipal();
        }

        static void moduloTipos()
        {
            negTipos tipos = new negTipos();
            string id;
            string valor, nombre, tipo;

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
                    Console.WriteLine("Listado de Tipos");
                    foreach (DataRow dataRow in tipos.ListarTipos().Rows)
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
                    Console.WriteLine(tipos.ConsultarTipo(Int32.Parse(id)).Nombre);
                    Console.Read();
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(tipos.EliminarTipo(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos del tipo que desea ingresar: ");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Tipo: ");
                    tipo = Console.ReadLine();
                    Console.WriteLine(tipos.AgregarTipo(nombre, tipo, 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese un tipo que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = tipos.BuscarTipo(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                       foreach(var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
        }

        static void moduloLugares()
        {
            negLugares lugares = new negLugares();
            string id;
            string valor, nombre, padre_id;

            Console.WriteLine("1. Listado");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Agregar");
            Console.WriteLine("5. Consultar por padre");
            Console.WriteLine("6. Buscar");
            Console.Write("Seleccione la opción que desea utilizar:  ");
            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Listado de Lugares");
                    foreach (DataRow dataRow in lugares.ListarLugares().Rows)
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
                    Console.WriteLine(lugares.ConsultarLugar(Int32.Parse(id)).Nombre);
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(lugares.EliminarLugar(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos del lugar que desea ingresar: ");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Padre Id: ");
                    padre_id = Console.ReadLine();
                    Console.WriteLine(lugares.AgregarLugar(nombre, Convert.ToInt32(padre_id), 1, 1));
                    break;
                case "5":
                    Console.Write("Ingrese el ID que desea consultar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(lugares.ConsultarLugarPadreId(Int32.Parse(id)).Nombre);
                    break;
                case "6":
                    Console.Write("Ingrese un lugar que quiera buscar: ");
                    valor = Console.ReadLine();
                    Console.WriteLine(lugares.BuscarLugar(valor));
                    break;
            }
        }

        static void moduloProfesores()
        {
            negProfesores profesores = new negProfesores();
            string id;
            string valor;
            string cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento;

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
                    foreach (DataRow dataRow in profesores.ListarProfesores().Rows)
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
                    Console.WriteLine(profesores.ConsultarProfesores(Int32.Parse(id)).Nombre);
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(profesores.EliminarProfesor(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos del profesor que desea ingresar: ");
                    Console.Write("Cedula: ");
                    cedula = Console.ReadLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Primer Apellido: ");
                    primer_apellido = Console.ReadLine();
                    Console.Write("Seguno Apellido: ");
                    segundo_apellido = Console.ReadLine();
                    Console.Write("Fecha de Nacimiento: ");
                    fecha_nacimiento = Console.ReadLine();
                    Console.WriteLine(profesores.AgregarProfesor(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese un profesor que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = profesores.BuscarProfesores(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        foreach (var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
        }

        static void moduloAlumnos()
        {
            negAlumnos alumnos = new negAlumnos();
            string id;
            string valor;
            string cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, id_carrera;

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
                    Console.WriteLine("Listado de Alumnos");
                    foreach (DataRow dataRow in alumnos.ListarAlumnos().Rows)
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
                    Console.WriteLine(alumnos.ConsultarAlumnos(Int32.Parse(id)).Nombre);
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(alumnos.EliminarAlumno(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos del alumno que desea ingresar: ");
                    Console.Write("Cedula: ");
                    cedula = Console.ReadLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Primer Apellido: ");
                    primer_apellido = Console.ReadLine();
                    Console.Write("Seguno Apellido: ");
                    segundo_apellido = Console.ReadLine();
                    Console.Write("Fecha de Nacimiento: ");
                    fecha_nacimiento = Console.ReadLine();
                    Console.Write("Código de la carrera: ");
                    id_carrera = Console.ReadLine();
                    Console.WriteLine(alumnos.AgregarAlumno(cedula, nombre, primer_apellido, segundo_apellido, fecha_nacimiento, Convert.ToInt32(id_carrera), 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese un alumno que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = alumnos.BuscarAlumnos(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        foreach (var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
        }

        static void moduloMaterias()
        {
            negMaterias materias = new negMaterias();
            string id;
            string valor, nombre, codigo;

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
                    Console.WriteLine("Listado de Materias");
                    foreach (DataRow dataRow in materias.ListarMaterias().Rows)
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
                    Console.WriteLine(materias.ConsultarMateria(Int32.Parse(id)).Nombre);
                    Console.Read();
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(materias.EliminarMateria(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos de la materia que desea ingresar: ");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Codigo: ");
                    codigo = Console.ReadLine();
                    Console.WriteLine(materias.AgregarMateria(nombre, codigo, 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese una materia que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = materias.BuscarMateria(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        foreach (var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
        }

        static void moduloCarreras()
        {
            negCarreras carreras = new negCarreras();
            string id;
            string valor, nombre, descripcion, id_profesor, costo, id_carrera, id_materia;

            Console.WriteLine("1. Listado");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Agregar");
            Console.WriteLine("5. Modificar");
            Console.WriteLine("6. Buscar");
            Console.WriteLine("7. Agregar materias asignadas");
            Console.WriteLine("8. Listar las materias asignadas");
            Console.Write("Seleccione la opción que desea utilizar:  ");
            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Listado de Carreras");
                    foreach (DataRow dataRow in carreras.ListarCarreras().Rows)
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
                    Console.WriteLine(carreras.ConsultarCarrera(Int32.Parse(id)).Nombre);
                    Console.Read();
                    break;
                case "3":
                    Console.Write("Ingrese el ID que desea eliminar: ");
                    id = Console.ReadLine();
                    Console.WriteLine(carreras.EliminarCarrera(Int32.Parse(id)));
                    break;
                case "4":
                    Console.WriteLine("Ingrese los datos de la carrera que desea ingresar: ");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Descripción: ");
                    descripcion = Console.ReadLine();
                    Console.Write("Id de Profesor: ");
                    id_profesor = Console.ReadLine();
                    Console.WriteLine(carreras.AgregarCarrera(nombre, descripcion, Convert.ToInt32(id_profesor), 1, 1));
                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Ingrese una Carrera que quiera buscar: ");
                    valor = Console.ReadLine();
                    DataTable tabla = carreras.BuscarCarrera(valor);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        foreach (var item in fila.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
                case "7":
                    Console.WriteLine("Ingrese los datos de la materia que desea asociar: ");
                    Console.Write("Costo: ");
                    costo = Console.ReadLine();
                    Console.Write("ID de la carrera: ");
                    id_carrera = Console.ReadLine();
                    Console.Write("Id de la materia: ");
                    id_materia = Console.ReadLine();
                    Console.WriteLine(carreras.AgregarCarrera(costo, id_carrera, Convert.ToInt32(id_materia), 1, 1));
                    break;
                case "8":
                    Console.Write("Ingrese el ID de la carrera que desea ver la materias:  ");
                    id_carrera = Console.ReadLine();
                    Console.WriteLine("Listado de Materias asociadas");
                    foreach (DataRow dataRow in carreras.ListarMateriasXCarrera(Convert.ToInt32(id_carrera)).Rows)
                    {
                        foreach (var item in dataRow.ItemArray)
                        {
                            Console.Write(item + "   ");
                        }
                        Console.WriteLine();
                    }
                    Console.Read();
                    break;
            }
        }
    }
}
