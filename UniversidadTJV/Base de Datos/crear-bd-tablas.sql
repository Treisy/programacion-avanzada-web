-------------------------------------------------------------------------------------------------------
--Script para la creación de la BD y las tablas
-------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------
-- Creación de la BD
-------------------------------------------------------------------------------------------------------
USE master

GO
IF EXISTS(SELECT name FROM sys.databases WHERE name = 'UniversidadTJV')
BEGIN
DROP DATABASE [UniversidadTJV]
END

CREATE DATABASE [UniversidadTJV]
GO
PRINT 'La base de datos se ha creado satisfactoriamente.'
GO

USE [UniversidadTJV]
GO

-------------------------------------------------------------------------------------------------------
-- Creación de las tablas
-------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[tb_configuraciones](
	[id_configuracion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_institucion] [varchar](200) NULL,
	[logo] [varchar](300) NULL,
	[cuatrimestre] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_configuraciones] PRIMARY KEY CLUSTERED 
(
	[id_configuracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_tipos](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[tipo] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_tipos] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_profesores](
	[id_profesor] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[fecha_nacimiento] [datetime] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_profesores] PRIMARY KEY CLUSTERED 
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usaurio_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_materias] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_carreras](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_profesor] [int] NULL,
 CONSTRAINT [PK_tb_carreras] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_carreras]  WITH CHECK ADD  CONSTRAINT [FK_tb_carreras_tb_profesores] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[tb_profesores] ([id_profesor])
GO

ALTER TABLE [dbo].[tb_carreras] CHECK CONSTRAINT [FK_tb_carreras_tb_profesores]
GO

CREATE TABLE [dbo].[tb_alumnos](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_carrera] [int] NULL,
 CONSTRAINT [PK_tb_alumnos] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_alumnos]  WITH CHECK ADD  CONSTRAINT [FK_tb_alumnos_tb_carreras] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[tb_carreras] ([id_carrera])
GO

ALTER TABLE [dbo].[tb_alumnos] CHECK CONSTRAINT [FK_tb_alumnos_tb_carreras]
GO

CREATE TABLE [dbo].[tb_usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NULL,
	[nombre_usuario] [varchar](150) NOT NULL,
	[comtrasena] [varchar](300) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_imgresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_lugares](
	[id_lugar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[padre_id] [int] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
 CONSTRAINT [PK_tb_lugares] PRIMARY KEY CLUSTERED 
(
	[id_lugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_alumnos_x_lugar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_alumno] [int] NULL,
	[id_lugar] [int] NULL,
 CONSTRAINT [PK_tb_alumnos_x_lugar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_alumnos_x_lugar]  WITH CHECK ADD  CONSTRAINT [FK_tb_alumnos_x_lugar_tb_alumnos] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[tb_alumnos] ([id_alumno])
GO

ALTER TABLE [dbo].[tb_alumnos_x_lugar] CHECK CONSTRAINT [FK_tb_alumnos_x_lugar_tb_alumnos]
GO

ALTER TABLE [dbo].[tb_alumnos_x_lugar]  WITH CHECK ADD  CONSTRAINT [FK_tb_alumnos_x_lugar_tb_lugares] FOREIGN KEY([id_lugar])
REFERENCES [dbo].[tb_lugares] ([id_lugar])
GO

ALTER TABLE [dbo].[tb_alumnos_x_lugar] CHECK CONSTRAINT [FK_tb_alumnos_x_lugar_tb_lugares]
GO

CREATE TABLE [dbo].[tb_materias_x_carrera](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[costo] [float] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_carrera] [int] NULL,
	[id_materia] [int] NULL,
 CONSTRAINT [PK_tb_materias_x_carrera] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_materias_x_carrera]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_carrera_tb_carreras1] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[tb_carreras] ([id_carrera])
GO

ALTER TABLE [dbo].[tb_materias_x_carrera] CHECK CONSTRAINT [FK_tb_materias_x_carrera_tb_carreras1]
GO

ALTER TABLE [dbo].[tb_materias_x_carrera]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_carrera_tb_materias] FOREIGN KEY([id_materia])
REFERENCES [dbo].[tb_materias] ([id_materia])
GO

ALTER TABLE [dbo].[tb_materias_x_carrera] CHECK CONSTRAINT [FK_tb_materias_x_carrera_tb_materias]
GO

CREATE TABLE [dbo].[tb_matriculas](
	[id_matricula] [int] IDENTITY(1,1) NOT NULL,
	[cuatrimestre] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_alumno] [int] NULL,
 CONSTRAINT [PK_tb_matriculas] PRIMARY KEY CLUSTERED 
(
	[id_matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_matriculas]  WITH CHECK ADD  CONSTRAINT [FK_tb_matriculas_tb_alumnos] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[tb_alumnos] ([id_alumno])
GO

ALTER TABLE [dbo].[tb_matriculas] CHECK CONSTRAINT [FK_tb_matriculas_tb_alumnos]
GO

ALTER TABLE [dbo].[tb_materias_x_carrera]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_carrera_tb_carreras1] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[tb_carreras] ([id_carrera])
GO

ALTER TABLE [dbo].[tb_materias_x_carrera] CHECK CONSTRAINT [FK_tb_materias_x_carrera_tb_carreras1]
GO

ALTER TABLE [dbo].[tb_materias_x_carrera]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_carrera_tb_materias] FOREIGN KEY([id_materia])
REFERENCES [dbo].[tb_materias] ([id_materia])
GO

ALTER TABLE [dbo].[tb_materias_x_carrera] CHECK CONSTRAINT [FK_tb_materias_x_carrera_tb_materias]
GO

CREATE TABLE [dbo].[tb_materias_x_matricula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_matricula] [int] NULL,
	[id_materia] [int] NULL,
 CONSTRAINT [PK_tb_materias_x_matricula] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_materias_x_matricula]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_matricula_tb_materias] FOREIGN KEY([id_materia])
REFERENCES [dbo].[tb_materias] ([id_materia])
GO

ALTER TABLE [dbo].[tb_materias_x_matricula] CHECK CONSTRAINT [FK_tb_materias_x_matricula_tb_materias]
GO

ALTER TABLE [dbo].[tb_materias_x_matricula]  WITH CHECK ADD  CONSTRAINT [FK_tb_materias_x_matricula_tb_matriculas] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[tb_matriculas] ([id_matricula])
GO

ALTER TABLE [dbo].[tb_materias_x_matricula] CHECK CONSTRAINT [FK_tb_materias_x_matricula_tb_matriculas]
GO

CREATE TABLE [dbo].[tb_profesores_x_lugar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_profesor] [int] NULL,
	[id_lugar] [int] NULL,
 CONSTRAINT [PK_tb_profesores_x_lugar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_profesores_x_lugar]  WITH CHECK ADD  CONSTRAINT [FK_tb_profesores_x_lugar_tb_lugares] FOREIGN KEY([id_lugar])
REFERENCES [dbo].[tb_lugares] ([id_lugar])
GO

ALTER TABLE [dbo].[tb_profesores_x_lugar] CHECK CONSTRAINT [FK_tb_profesores_x_lugar_tb_lugares]
GO

ALTER TABLE [dbo].[tb_profesores_x_lugar]  WITH CHECK ADD  CONSTRAINT [FK_tb_profesores_x_lugar_tb_profesores] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[tb_profesores] ([id_profesor])
GO

ALTER TABLE [dbo].[tb_profesores_x_lugar] CHECK CONSTRAINT [FK_tb_profesores_x_lugar_tb_profesores]
GO

CREATE TABLE [dbo].[tb_tipos_x_alumno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_alumno] [int] NULL,
	[id_tipo] [int] NULL,
 CONSTRAINT [PK_tb_tipos_x_alumno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_tipos_x_alumno]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_alumno_tb_alumnos] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[tb_alumnos] ([id_alumno])
GO

ALTER TABLE [dbo].[tb_tipos_x_alumno] CHECK CONSTRAINT [FK_tb_tipos_x_alumno_tb_alumnos]
GO

ALTER TABLE [dbo].[tb_tipos_x_alumno]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_alumno_tb_tipos] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tb_tipos] ([id_tipo])
GO

ALTER TABLE [dbo].[tb_tipos_x_alumno] CHECK CONSTRAINT [FK_tb_tipos_x_alumno_tb_tipos]
GO

CREATE TABLE [dbo].[tb_tipos_x_institucion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_configuracion] [int] NULL,
	[id_tipo] [int] NULL,
 CONSTRAINT [PK_tb_tipos_x_institucion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_tipos_x_institucion]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_institucion_tb_configuraciones] FOREIGN KEY([id_configuracion])
REFERENCES [dbo].[tb_configuraciones] ([id_configuracion])
GO

ALTER TABLE [dbo].[tb_tipos_x_institucion] CHECK CONSTRAINT [FK_tb_tipos_x_institucion_tb_configuraciones]
GO

ALTER TABLE [dbo].[tb_tipos_x_institucion]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_institucion_tb_tipos] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tb_tipos] ([id_tipo])
GO

ALTER TABLE [dbo].[tb_tipos_x_institucion] CHECK CONSTRAINT [FK_tb_tipos_x_institucion_tb_tipos]
GO

CREATE TABLE [dbo].[tb_tipos_x_profesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[usuario_modifica] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[id_profesor] [int] NULL,
	[id_tipo] [int] NULL,
 CONSTRAINT [PK_tb_tipos_x_profesor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_tipos_x_profesor]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_profesor_tb_profesores] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[tb_profesores] ([id_profesor])
GO

ALTER TABLE [dbo].[tb_tipos_x_profesor] CHECK CONSTRAINT [FK_tb_tipos_x_profesor_tb_profesores]
GO

ALTER TABLE [dbo].[tb_tipos_x_profesor]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipos_x_profesor_tb_tipos] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tb_tipos] ([id_tipo])
GO

ALTER TABLE [dbo].[tb_tipos_x_profesor] CHECK CONSTRAINT [FK_tb_tipos_x_profesor_tb_tipos]
GO