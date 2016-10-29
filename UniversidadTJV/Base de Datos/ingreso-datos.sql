-------------------------------------------------------------------------------------------------------
-- Ingreso de datos
-------------------------------------------------------------------------------------------------------

--Ingresar Usuarios
EXECUTE sp_agregar_usuario '000000000', 'astridc', 'admin', 'Astrid', 'Ching', 'Jiménez', 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Configuración
EXECUTE sp_agregar_configuracion 'UniversidadTJV', 'Mis Documentos', 'III Cuatrimestre', 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Lugares

--Agregar provincias
--========================================================================
EXECUTE sp_agregar_lugar 'San José', 0, 1, 1
EXECUTE sp_agregar_lugar 'Alajuela', 0, 1, 1
EXECUTE sp_agregar_lugar 'Heredia', 0, 1, 1
EXECUTE sp_agregar_lugar 'Cartago', 0, 1, 1
EXECUTE sp_agregar_lugar 'Puntarenas', 0, 1, 1
EXECUTE sp_agregar_lugar 'Guanacaste', 0, 1, 1
EXECUTE sp_agregar_lugar 'Limón', 0, 1, 1

--Agregar cantones
--========================================================================
EXECUTE sp_agregar_lugar 'San José', 1, 1, 1
EXECUTE sp_agregar_lugar 'Alajuela', 2, 1, 1
EXECUTE sp_agregar_lugar 'Heredia', 3, 1, 1
EXECUTE sp_agregar_lugar 'Cartago', 4, 1, 1
EXECUTE sp_agregar_lugar 'Puntarenas', 5, 1, 1
EXECUTE sp_agregar_lugar 'Liberia', 6, 1, 1
EXECUTE sp_agregar_lugar 'Limón', 7, 1, 1

--Agregar distritos
--========================================================================

-------------------------------------------------------------------------------------------------------

--Ingresar Tipos
EXECUTE sp_agregar_tipo 'Celular', 'Teléfono', 1, 1
EXECUTE sp_agregar_tipo 'Casa', 'Teléfono', 1, 1
EXECUTE sp_agregar_tipo 'Correo electrónico', 'Dirección', 1, 1
EXECUTE sp_agregar_tipo 'Dirección de la casa', 'Dirección', 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Profesores
EXECUTE sp_agregar_profesor '102340567', 'Juan Carlos', 'Grijalba', 'Chavarria', '1982-03-03', 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Carreras
EXECUTE sp_agregar_carrera 'Licenciatura en Desarrollo de Aplicaciones Web', 'Licenciatura de Ingenieria Informática cuyo énfasis es el Desarrollo de Aplicaciones Web', 1, 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Información de Alumnos
EXECUTE sp_agregar_alumno '205710607', 'Treisy', 'Jiménez', 'Vega', '1982-07-05', 1, 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Materias
EXECUTE sp_agregar_materia 'Programación Avanzada en Web', '00000', 1, 1
-------------------------------------------------------------------------------------------------------

--Ingresar Lugares para los alumnos
EXECUTE sp_agregar_alumno_x_lugar
-------------------------------------------------------------------------------------------------------

--Ingresar Materias a las Carreras
EXECUTE sp_agregar_materia_x_carrera
-------------------------------------------------------------------------------------------------------

--Ingresar Lugares a los Profesores
EXECUTE sp_agregar_profesor_x_lugar
-------------------------------------------------------------------------------------------------------

--Ingresar Tipos a los Alumnos
EXECUTE sp_agregar_tipo_x_alumno
-------------------------------------------------------------------------------------------------------

--Ingresar Tipos a la Institución
EXECUTE sp_agregar_tipo_x_institucion
-------------------------------------------------------------------------------------------------------

--Ingresar Tipos a los Profesores
EXECUTE sp_agregar_tipo_x_profesor
-------------------------------------------------------------------------------------------------------

--Ingresar Matrículas
EXECUTE sp_agregar_matricula
-------------------------------------------------------------------------------------------------------

--Ingresar Materias a las Matrículas
EXECUTE sp_agregar_materia_x_matricula
-------------------------------------------------------------------------------------------------------
