-------------------------------------------------------------------------------------------------------
--Script para la creación de las tablas de historial
-------------------------------------------------------------------------------------------------------
USE [UniversidadTJV]
GO

CREATE TABLE [dbo].[tb_historial_lugares](
	[id_lugar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[padre_id] [int] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_lugares] PRIMARY KEY CLUSTERED
(
	[id_lugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_profesores](
	[id_profesor] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[fecha_nacimiento] [datetime] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_profesores] PRIMARY KEY CLUSTERED
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_configuraciones](
	[id_configuracion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_institucion] [varchar](200) NULL,
	[logo] [varchar](300) NULL,
	[cuatrimestre] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_configuraciones] PRIMARY KEY CLUSTERED
(
	[id_configuracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_alumnos](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_caarrera] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_alumnos] PRIMARY KEY CLUSTERED
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_alumnos_x_lugar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_alumno] [int] NULL,
	[id_lugar] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_alumnos_x_lugar] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_carreras](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[id_profesor] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_carreras] PRIMARY KEY CLUSTERED
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[codigo] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_materias] PRIMARY KEY CLUSTERED
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_materias_x_carrera](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[costo] [float] NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[id_carrera] [int] NULL,
	[id_materia] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_materias_x_carrera] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_materias_x_matricula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_matricula] [int] NULL,
	[id_materia] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_materias_x_matricula] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_matriculas](
	[id_matricula] [int] IDENTITY(1,1) NOT NULL,
	[cuatrimestre] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[id_alumno] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_matriculas] PRIMARY KEY CLUSTERED
(
	[id_matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_profesores_x_lugar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_profesor] [int] NULL,
	[id_lugar] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_profesores_x_lugar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_tipos](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[tipo] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_modifica] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_tipos] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_tipos_x_alumno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_alumno] [int] NULL,
	[id_tipo] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_tipos_x_alumno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_tipos_x_institucion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_configuracion] [int] NULL,
	[id_tipo] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_tipos_x_institucion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_tipos_x_profesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_ingresa] [datetime] NULL,
	[id_profesor] [int] NULL,
	[id_tipo] [int] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_tipos_x_profesor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tb_historial_usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NULL,
	[nombre_usuario] [varchar](150) NOT NULL,
	[comtrasena] [varchar](300) NOT NULL,
	[nombre] [varchar](50) NULL,
	[primer_apellido] [varchar](50) NULL,
	[segundo_apellido] [varchar](50) NULL,
	[usuario_ingresa] [int] NULL,
	[fecha_imgreso] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_tb_historial_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO