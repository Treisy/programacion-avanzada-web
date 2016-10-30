-------------------------------------------------------------------------------------------------------
--Script para la creación de los SP de Consulta
-------------------------------------------------------------------------------------------------------

USE [UniversidadTJV]
GO

CREATE PROCEDURE [dbo].[sp_consultar_usuario]
	@id_usuario INT
AS
BEGIN
	SELECT [id_usuario]
		  ,[cedula]
		  ,[nombre_usuario]
		  ,[contrasena]
		  ,[nombre]
		  ,[primer_apellido]
		  ,[segundo_apellido]
	  FROM [dbo].[tb_usuarios]
	 WHERE id_usuario = @id_usuario	
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_tipo]
	@id_tipo INT
AS
BEGIN
	SELECT [id_tipo]
		  ,[nombre]
		  ,[tipo]
	  FROM [dbo].[tb_tipos]
	 WHERE id_tipo = @id_tipo
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_profesor]
	@id_profesor INT
AS
BEGIN
	SELECT [id_profesor]
		  ,[cedula]
		  ,[nombre]
		  ,[primer_apellido]
		  ,[segundo_apellido]
		  ,[fecha_nacimiento]
	  FROM [dbo].[tb_profesores]
	 WHERE id_profesor = @id_profesor
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_alumno]
	@id_alumno INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_alumno]
		  ,[cedula]
		  ,[nombre]
		  ,[primer_apellido]
		  ,[segundo_apellido]
		  ,[fecha_nacimiento]
		  ,[id_carrera]
	  FROM [dbo].[tb_alumnos]
	 WHERE id_alumno = @id_alumno
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_carrera]
	@id_carrera INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_carrera]
		  ,[nombre]
		  ,[descripcion]
		  ,[id_profesor]
	  FROM [dbo].[tb_carreras]
	 WHERE id_carrera = @id_carrera
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_materia]
	@id_materia INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_materia]
		  ,[nombre]
		  ,[codigo]
		  ,[usuario_ingresa]
		  ,[fecha_ingresa]
		  ,[usaurio_modifica]
		  ,[fecha_modifica]
	  FROM [dbo].[tb_materias]
	 WHERE id_materia = @id_materia
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_lugar]
	@id_lugar INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_lugar]
		  ,[nombre]
		  ,[padre_id]
	  FROM [dbo].[tb_lugares]
	 WHERE id_lugar = @id_lugar
END;
GO

CREATE PROCEDURE [dbo].[sp_consultar_lugar_padre_id]
	@padre_id INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_lugar]
		  ,[nombre]
		  ,[padre_id]
	  FROM [dbo].[tb_lugares]
	 WHERE padre_id = @padre_id
END;
GO