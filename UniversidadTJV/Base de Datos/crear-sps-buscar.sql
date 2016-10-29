-------------------------------------------------------------------------------------------------------
--Script para la creación de los SP de Búsqueda
-------------------------------------------------------------------------------------------------------
USE [UniversidadTJV]
GO

CREATE PROCEDURE [dbo].[sp_buscar_usuario]
	@valor VARCHAR(150)
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
	 WHERE cedula LIKE @valor
	    OR nombre_usuario LIKE @valor
	 	OR nombre LIKE @valor
	 	OR primer_apellido LIKE @valor
	 	OR segundo_apellido LIKE @valor
END;
GO

CREATE PROCEDURE [dbo].[sp_buscar_tipo]
	@valor VARCHAR(150)
AS
BEGIN
	SELECT [id_tipo]
		  ,[nombre]
		  ,[tipo]
	  FROM [dbo].[tb_tipos]
	 WHERE nombre LIKE @valor
	    OR tipo LIKE @valor
END;
GO

CREATE PROCEDURE [dbo].[sp_buscar_profesor]
	@valor VARCHAR(150)
AS
BEGIN
	SELECT [id_profesor]
		  ,[cedula]
		  ,[nombre]
		  ,[primer_apellido]
		  ,[segundo_apellido]
		  ,[fecha_nacimiento]
	  FROM [dbo].[tb_profesores]
	 WHERE cedula LIKE @valor
	    OR nombre LIKE @valor
		OR primer_apellido LIKE @valor
		OR segundo_apellido LIKE @valor
END;
GO

CREATE PROCEDURE [dbo].[sp_buscar_alumno]
	@valor VARCHAR(150)
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
	 WHERE cedula LIKE @valor
	 	OR nombre LIKE @valor
	 	OR primer_apellido LIKE @valor
	 	OR segundo_apellido LIKE @valor
END;
GO

CREATE PROCEDURE [dbo].[sp_buscar_carrera]
	@valor VARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON
	SELECT [id_carrera]
		  ,[nombre]
		  ,[descripcion]
		  ,[id_profesor]
	  FROM [dbo].[tb_carreras]
	 WHERE nombre LIKE @valor
		OR descripcion LIKE @valor
END;
GO