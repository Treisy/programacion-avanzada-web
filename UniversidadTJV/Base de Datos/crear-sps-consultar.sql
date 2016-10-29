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

