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
