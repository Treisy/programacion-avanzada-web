-------------------------------------------------------------------------------------------------------
--Script para la creación de los SP para Agregar
-------------------------------------------------------------------------------------------------------
USE [UniversidadTJV]
GO

CREATE PROCEDURE [dbo].[sp_agregar_usuario]
	@cedula VARCHAR(30),
	@nombre_usuario VARCHAR(150),
	@contrasena VARCHAR(300),
	@nombre VARCHAR(50),
	@primer_apellido VARCHAR(50),
	@segundo_apellido VARCHAR(50),
	@usuario_ingresa INT ,
	@usuario_modifica INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_usuarios]
           ([cedula]
           ,[nombre_usuario]
           ,[contrasena]
           ,[nombre]
           ,[primer_apellido]
           ,[segundo_apellido]
           ,[usuario_ingresa]
           ,[fecha_imgresa]
           ,[usuario_modifica]
           ,[fecha_modifica])
     VALUES
           (@cedula,
			@nombre_usuario,
			HASHBYTES('SHA2_512', @contrasena),
			@nombre,
			@primer_apellido,
			@segundo_apellido,
			@usuario_ingresa,
			GETDATE(),
			@usuario_modifica,
			GETDATE())
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_profesor]
	@cedula VARCHAR(30),
	@nombre VARCHAR(50),
	@primer_apellido VARCHAR(50),
	@segundo_apellido VARCHAR(50),
	@fecha_nacimiento DATE,
	@usuario_ingresa INT,
	@usuario_modifica INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_profesores]
           ([cedula]
           ,[nombre]
           ,[primer_apellido]
           ,[segundo_apellido]
           ,[fecha_nacimiento]
           ,[usuario_ingresa]
           ,[fecha_ingresa]
           ,[usuario_modifica]
           ,[fecha_modifica])
     VALUES
           (@cedula,
			@nombre,
			@primer_apellido,
			@segundo_apellido,
			@fecha_nacimiento,
			@usuario_ingresa,
			GETDATE(),
			@usuario_modifica,
			GETDATE())
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_tipo]
	@nombre VARCHAR(150),
	@tipo VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_tipos]
			   ([nombre]
			   ,[tipo]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica])
		 VALUES
			   (@nombre,
				@tipo,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE())
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_lugar]
	@nombre VARCHAR(50),
	@padre_id INT,
	@usuario_ingresa INT,
	@usuario_modifica INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_lugares]
			   ([nombre]
			   ,[padre_id]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica])
		 VALUES
			   (@nombre,
				@padre_id,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE())
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_materia]
	@nombre VARCHAR(150),
	@codigo VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_materias]
			   ([nombre]
			   ,[codigo]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usaurio_modifica]
			   ,[fecha_modifica])
		 VALUES
			   (@nombre,
				@codigo,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE())
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_carrera]
	@nombre VARCHAR(50),
	@descripcion  VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_profesor INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_carreras]
           ([nombre]
           ,[descripcion]
           ,[usuario_ingresa]
           ,[fecha_ingresa]
           ,[usuario_modifica]
           ,[fecha_modifica]
           ,[id_profesor])
     VALUES
           (@nombre,
			@descripcion,
			@usuario_ingresa,
			GETDATE(),
			@usuario_modifica,
			GETDATE(),
			@id_profesor)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_alumno]
	@cedula				VARCHAR(30),
	@nombre				VARCHAR(50),
	@primer_apellido	VARCHAR(50),
	@segundo_apellido	VARCHAR(50),
	@fecha_nacimiento	DATE,
	@usuario_ingresa	INT,
	@usuario_modifica	INT,
	@id_carrera			INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_alumnos]
			   ([cedula]
			   ,[nombre]
			   ,[primer_apellido]
			   ,[segundo_apellido]
			   ,[fecha_nacimiento]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_carrera])
		 VALUES(
			    @cedula,
				@nombre,
				@primer_apellido,
				@segundo_apellido,
				@fecha_nacimiento,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_carrera
		)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_materia_x_carrera]
	@costo FLOAT,
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_carrera INT,
	@id_materia INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_materias_x_carrera]
			   ([costo]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_carrera]
			   ,[id_materia])
		 VALUES
			   (@costo,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_carrera,
				@id_materia)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_alumno_x_lugar]
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_alumno INT,
	@id_lugar INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_alumnos_x_lugar]
			   ([usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_alumno]
			   ,[id_lugar])
		 VALUES
			   (@usuario_ingresa,
			    GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_alumno,
				@id_lugar)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_matricula]
	@cuatrimestre VARCHAR(50),
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_alumno INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_matriculas]
			   ([cuatrimestre]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_alumno])
		 VALUES
			   (@cuatrimestre,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_alumno )
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_materia_x_matricula]
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_matricula INT,
	@id_materia INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_materias_x_matricula]
			   ([usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_matricula]
			   ,[id_materia])
		 VALUES
			   (@usuario_ingresa,
			   	GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_matricula,
				@id_materia)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_profesor_x_lugar]
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_profesor INT,
	@id_lugar INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_profesores_x_lugar]
			   ([usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_profesor]
			   ,[id_lugar])
		 VALUES
			   (@usuario_ingresa,
			    GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_profesor,
				@id_lugar)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_tipo_x_alumno]
	@descripcion VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_alumno INT,
	@id_tipo INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_tipos_x_alumno]
			   ([descripcion]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_alumno]
			   ,[id_tipo])
		 VALUES
			   (@descripcion,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_alumno,
				@id_tipo)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_tipo_x_institucion]
	@descripcion VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_configuracion INT,
	@id_tipo INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_tipos_x_institucion]
			   ([descripcion]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_configuracion]
			   ,[id_tipo])
		 VALUES
			   (@descripcion,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_configuracion,
				@id_tipo)
END;
GO

CREATE PROCEDURE [dbo].[sp_agregar_tipo_x_profesor]
	@descripcion VARCHAR(150),
	@usuario_ingresa INT,
	@usuario_modifica INT,
	@id_profesor INT,
	@id_tipo INT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[tb_tipos_x_profesor]
			   ([descripcion]
			   ,[usuario_ingresa]
			   ,[fecha_ingresa]
			   ,[usuario_modifica]
			   ,[fecha_modifica]
			   ,[id_profesor]
			   ,[id_tipo])
		 VALUES
			   (@descripcion,
				@usuario_ingresa,
				GETDATE(),
				@usuario_modifica,
				GETDATE(),
				@id_profesor,
				@id_tipo)
END;
GO
