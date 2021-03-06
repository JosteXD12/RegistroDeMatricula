USE [master]
GO
/****** Object:  Database [Registro_de_Matricula]    Script Date: 24/9/2021 15:19:50 ******/
Create database Registro_de_Matricula;
GO
ALTER DATABASE [Registro_de_Matricula] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Registro_de_Matricula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Registro_de_Matricula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET ARITHABORT OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Registro_de_Matricula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Registro_de_Matricula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Registro_de_Matricula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Registro_de_Matricula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET RECOVERY FULL 
GO
ALTER DATABASE [Registro_de_Matricula] SET  MULTI_USER 
GO
ALTER DATABASE [Registro_de_Matricula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Registro_de_Matricula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Registro_de_Matricula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Registro_de_Matricula] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Registro_de_Matricula] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Registro_de_Matricula] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Registro_de_Matricula', N'ON'
GO
ALTER DATABASE [Registro_de_Matricula] SET QUERY_STORE = OFF
GO
USE [Registro_de_Matricula]
GO
/****** Object:  Table [dbo].[TAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAula](
	[Aula_id] [int] IDENTITY(1,1) NOT NULL,
	[Aula_descripcion] [varchar](20) NULL,
	[Aula_capacidad] [varchar](20) NULL,
	[Aula_estado] [varchar](1) NULL,
 CONSTRAINT [TAula_PK] PRIMARY KEY CLUSTERED 
(
	[Aula_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TCurso](
	[Curso_id] [int] IDENTITY(1,1) NOT NULL,
	[Curso_nombre] [varchar](50) NULL,
	[Curso_creditos] [varchar](20) NULL,
	[Curso_cupo] [varchar](20) NULL,
	[Curso_estado] [varchar](1) NULL,
 CONSTRAINT [TCurso_PK] PRIMARY KEY CLUSTERED 
(
	[Curso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEstudiante](
	[Estudiante_id] [int] IDENTITY(1,1) NOT NULL,
	[Grupo_id] [int] NULL,
	[Estudiante_cedula] [varchar](50) NULL,
	[Estudiante_nombre] [varchar](50) NULL,
	[Estudiante_primerApellido] [varchar](50) NULL,
	[Estudiante_segundoApellido] [varchar](50) NULL,
	[Estudiante_telefono] [varchar](20) NULL,
	[Estudiante_correoElectronico] [varchar](50) NULL,
	[Estudiante_direccion] [varchar](50) NULL,
	[Estudiante_estado] [varchar](1) NULL,
 CONSTRAINT [TEstudiante_PK] PRIMARY KEY CLUSTERED 
(
	[Estudiante_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TGrupo](
	[Grupo_id] [int] IDENTITY(1,1) NOT NULL,
	[Grupo_descripcion] [varchar](20) NULL,
	[Grupo_estado] [varchar](1) NULL,
 CONSTRAINT [TGrupo_PK] PRIMARY KEY CLUSTERED 
(
	[Grupo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THorario](
	[Horario_id] [int] IDENTITY(1,1) NOT NULL,
	[Horario_descripcion] [varchar](20) NULL,
	[Horario_dia] [varchar](15) NULL,
	[Horario_horaInicio] [varchar](30) NULL,
	[Horario_horaFin] [varchar](30) NULL,
	[Horario_estado] [varchar](1) NULL,
 CONSTRAINT [THorario_PK] PRIMARY KEY CLUSTERED 
(
	[Horario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMatricula](
	[Matricula_id] [int] IDENTITY(1,1) NOT NULL,
	[Estudiante_id] [int] NULL,
	[Grupo_id] [int] NULL,
	[Curso_id] [int] NULL,
	[Profesor_id] [int] NULL,
	[Horario_id] [int] NULL,
	[Aula_id] [int] NULL,
	[Matricula_comprobante] [varchar](20) NULL,
	[Matricula_estado] [varchar](1) NULL,
 CONSTRAINT [TMatricula_PK] PRIMARY KEY CLUSTERED 
(
	[Matricula_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProfesor](
	[Profesor_id] [int] IDENTITY(1,1) NOT NULL,
	[Profesor_cedula] [varchar](50) NULL,
	[Profesor_nombre] [varchar](50) NULL,
	[Profesor_primerApellido] [varchar](50) NULL,
	[Profesor_segundoApellido] [varchar](50) NULL,
	[Profesor_Telefono] [varchar](20) NULL,
	[Profesor_correoElectronico] [varchar](50) NULL,
	[Profesor_direccion] [varchar](50) NULL,
	[Profesor_estado] [varchar](1) NULL,
 CONSTRAINT [TProfesor_PK] PRIMARY KEY CLUSTERED 
(
	[Profesor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUsuario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUsuario](
	[Usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario_area] [varchar](5) NULL,
	[Usuario_nombre] [varchar](50) NULL,
	[Usuario_nick] [varchar](10) NULL,
	[Usuario_contrasenia] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TEstudiante]  WITH CHECK ADD  CONSTRAINT [TEstudiante_FK] FOREIGN KEY([Grupo_id])
REFERENCES [dbo].[TGrupo] ([Grupo_id])
GO
ALTER TABLE [dbo].[TEstudiante] CHECK CONSTRAINT [TEstudiante_FK]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK1] FOREIGN KEY([Estudiante_id])
REFERENCES [dbo].[TEstudiante] ([Estudiante_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK1]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK2] FOREIGN KEY([Grupo_id])
REFERENCES [dbo].[TGrupo] ([Grupo_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK2]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK3] FOREIGN KEY([Curso_id])
REFERENCES [dbo].[TCurso] ([Curso_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK3]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK4] FOREIGN KEY([Profesor_id])
REFERENCES [dbo].[TProfesor] ([Profesor_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK4]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK5] FOREIGN KEY([Horario_id])
REFERENCES [dbo].[THorario] ([Horario_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK5]
GO
ALTER TABLE [dbo].[TMatricula]  WITH CHECK ADD  CONSTRAINT [TMatricula_FK6] FOREIGN KEY([Aula_id])
REFERENCES [dbo].[TAula] ([Aula_id])
GO
ALTER TABLE [dbo].[TMatricula] CHECK CONSTRAINT [TMatricula_FK6]
GO
/****** Object:  StoredProcedure [dbo].[ActivarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarAula] @Aula_id int
AS
	BEGIN
		UPDATE TAula
		SET Aula_estado = 'A'
		WHERE Aula_id = @Aula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarCurso] @Curso_id int
AS
	BEGIN
		UPDATE TCurso
		SET Curso_estado = 'A'
		WHERE Curso_id = @Curso_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarEstudiante] @Estudiante_id int
AS
	BEGIN
		UPDATE TEstudiante
		SET Estudiante_estado = 'A'
		WHERE Estudiante_id = @Estudiante_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActivarGrupo] @Grupo_id int
AS
	BEGIN
		UPDATE TGrupo
		SET Grupo_estado = 'A'
		WHERE Grupo_id = @Grupo_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarHorario] @Horario_id int
AS
	BEGIN
		UPDATE THorario
		SET Horario_estado = 'A'
		WHERE Horario_id = @Horario_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarMatricula] @Matricula_id int
AS
	BEGIN
		UPDATE TMatricula
		SET Matricula_estado = 'A'
		WHERE Matricula_id = @Matricula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ActivarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarProfesor] @Profesor_id int
AS
	BEGIN
		UPDATE TProfesor
		SET Profesor_estado = 'A'
		WHERE Profesor_id = @Profesor_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarAula] @Aula_id INT
AS
BEGIN
	 SELECT Aula_id,
			Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			Aula_capacidad,
			Aula_estado
		   
	 FROM TAula
	 WHERE Aula_id = @Aula_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN CURSO=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarCurso] @Curso_id INT
AS
BEGIN
	 SELECT Curso_id,
			Curso_nombre,					
			Curso_creditos,
			Curso_cupo,
			Curso_estado
			
		   
	 FROM TCurso
	 WHERE Curso_id = @Curso_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN ESTUDIANTE=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarEstudiante] @Estudiante_id INT
AS
BEGIN
	 SELECT Estudiante_id,
		   Grupo_id,
		   Estudiante_cedula,
		   Estudiante_nombre,
		   Estudiante_primerApellido,
		   Estudiante_segundoApellido,
		   Estudiante_telefono,
		   Estudiante_correoElectronico, 
		   Estudiante_direccion,
		   Estudiante_estado
	 FROM TEstudiante
	 WHERE Estudiante_id = @Estudiante_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UNA GRUPO=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarGrupo] @Grupo_id int 
AS
BEGIN
	 SELECT Grupo_id ,                     
			Grupo_descripcion ,
			Grupo_estado
			

	 FROM TGrupo
	 WHERE Grupo_id = @Grupo_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarHorario] @Horario_id INT
AS
BEGIN
	 SELECT Horario_id
			Horario_descripcion,
			Horario_dia,
			Horario_horaInicio,
			Horario_horaFin,
			Horario_estado
		   
	 FROM THorario
	 WHERE Horario_id = @Horario_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UNA MATRICULA=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarMatricula] @Matricula_id int
AS
BEGIN
	 SELECT Matricula_id,                     
			Estudiante_id,
			Grupo_id,
			Curso_id,
			Profesor_id,
			Horario_id,
			Aula_id,
			Matricula_comprobante,
			Matricula_estado

	 FROM TMatricula
	 WHERE Matricula_id = @Matricula_id
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ConsultarProfesor] @Profesor_id INT
AS
BEGIN
	 SELECT Profesor_id,
		   Profesor_cedula,
		   Profesor_nombre,
		   Profesor_primerApellido,
		  Profesor_segundoApellido,
		   Profesor_telefono,
		   Profesor_correoElectronico, 
		   Profesor_direccion,
		   Profesor_estado
	 FROM TProfesor
	 WHERE Profesor_id = @Profesor_id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR AULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarAula] @Aula_id INT 								
AS
BEGIN 
	DELETE FROM TAula
	WHERE Aula_id = @Aula_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR CURSO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarCurso] @Curso_id INT 								
AS
BEGIN 
	DELETE FROM TCurso
	WHERE Curso_id = @Curso_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR ESTUDIANTE ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarEstudiante] @Estudiante_id INT 								
AS
BEGIN 
	DELETE FROM TEstudiante
	WHERE Estudiante_id = @Estudiante_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR GRUPO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarGrupo] @Grupo_id int 								
AS
BEGIN 
	DELETE FROM TGrupo
	WHERE Grupo_id = @Grupo_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR AULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarHorario] @Horario_id INT 								
AS
BEGIN 
	DELETE FROM THorario
	WHERE Horario_id = @Horario_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR MATRICULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarMatricula] @Matricula_id int 								
AS
BEGIN 
	DELETE FROM TMatricula
	WHERE Matricula_id = @Matricula_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================ELIMINAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[EliminarProfesor] @Profesor_id INT 								
AS
BEGIN 
	DELETE FROM TProfesor
	WHERE Profesor_id = @Profesor_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
/****** Object:  StoredProcedure [dbo].[InactivarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarAula] @Aula_id INT
AS
	BEGIN
		UPDATE TAula
		SET Aula_estado = 'I'
		WHERE Aula_id = @Aula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR CURSO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarCurso] @Curso_id INT
AS
	BEGIN
		UPDATE TCurso
		SET Curso_estado = 'I'
		WHERE Curso_id = @Curso_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR ESTUDIANTE ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarEstudiante] @Estudiante_id INT
AS
	BEGIN
		UPDATE TEstudiante
		SET Estudiante_estado = 'I'
		WHERE Estudiante_id = @Estudiante_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR GRUPO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarGrupo] @Grupo_id int
AS
	BEGIN
		UPDATE TGrupo
		SET Grupo_estado = 'I'
		WHERE Grupo_id = @Grupo_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR HORARIO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarHorario] @Horario_id INT
AS
	BEGIN
		UPDATE THorario
		SET Horario_estado = 'I'
		WHERE Horario_id = @Horario_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR MATRIUCLA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarMatricula] @Matricula_id int
AS
	BEGIN
		UPDATE TMatricula
		SET Matricula_estado = 'I'
		WHERE Matricula_id = @Matricula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InactivarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================INACTIVAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InactivarProfesor] @Profesor_id INT
AS
	BEGIN
		UPDATE TProfesor
		SET Profesor_estado = 'I'
		WHERE Profesor_id = @Profesor_id
	END
GO
/****** Object:  StoredProcedure [dbo].[InsertaHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR HORARIO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertaHorario]                    
											
									@Horario_descripcion VARCHAR(20),
									@Horario_dia VARCHAR(15),
									@Horario_horaInicio VARCHAR (30),
									@Horario_horaFin VARCHAR(30),
									@Horario_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO THorario(Horario_descripcion,
							Horario_dia,
							Horario_horaInicio,
							Horario_horaFin,
							Horario_estado)
	SELECT                                   
			@Horario_descripcion,
			@Horario_dia,
			@Horario_horaInicio,
			@Horario_horaFin,
			@Horario_estado  
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarAula]                    
								    @Aula_descripcion VARCHAR(20),				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Aula_capacidad VARCHAR(20),
									@Aula_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TAula(                  /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
							Aula_capacidad,
							Aula_estado )
	SELECT                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			@Aula_capacidad,
			@Aula_estado 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR CURSO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarCurso]                   
								    @Curso_nombre VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Curso_creditos VARCHAR(20),
									@Curso_cupo VARCHAR(20),
									@Curso_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TCurso(                  /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Curso_nombre,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
							Curso_creditos,
							Curso_cupo,
							Curso_estado)		/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
							
							
	SELECT                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Curso_nombre,			/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			@Curso_creditos,
			@Curso_cupo ,
			@Curso_estado
			
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR ESTUDIANTE ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarEstudiante] @Grupo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								    @Estudiante_cedula VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Estdiante_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Estudiante_nombre VARCHAR(50),
									@Estudiante_primerApellido VARCHAR(50),
									@Estudiante_segundoApellido VARCHAR(50),
									@Estudiante_telefono VARCHAR(20),
									@Estudiante_correoElectronico VARCHAR(50),
									@Estudiante_direccion VARCHAR(50),
									@Estudiante_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TEstudiante(Grupo_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Estudiante_cedula,
							Estudiante_nombre,
							Estudiante_primerApellido,
							Estudiante_segundoApellido,
							Estudiante_telefono,
							Estudiante_correoElectronico,
							Estudiante_direccion,
							Estudiante_estado) 
	SELECT  @Grupo_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Estudiante_cedula,
			@Estudiante_nombre,
			@Estudiante_primerApellido,
			@Estudiante_segundoApellido,
			@Estudiante_telefono,
			@Estudiante_correoElectronico,
			@Estudiante_direccion,
			@Estudiante_estado
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR GRUPO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarGrupo]                      
								@Grupo_descripcion varchar(20),
								@Grupo_estado varchar(1)
AS
BEGIN
	INSERT INTO TGrupo(                     
							Grupo_descripcion ,
							Grupo_estado) 

	SELECT                                    
			@Grupo_descripcion,
			@Grupo_estado
			
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR MATRICULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarMatricula]                       /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								    @Estudiante_id int,				/*NOTEN QUE LA LLAVE PRIMARIA (Estdiante_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Grupo_id int,
									@Curso_id int,
									@Profesor_id int,
									@Horario_id int,
									@Aula_id int,
									@Matricula_comprobante varchar (20),
									@Matricula_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TMatricula(                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Estudiante_id,
							Grupo_id,
							Curso_id,
							Profesor_id,
							Horario_id,
							Aula_id,
							Matricula_comprobante,
							Matricula_estado) 
	SELECT                                    /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Estudiante_id,
			@Grupo_id,
			@Curso_id,
			@Profesor_id,
			@Horario_id,
			@Aula_id,
			@Matricula_comprobante,
			@Matricula_estado
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==================================================================================================*/
/*===================INSERTAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[InsertarProfesor]                    
								    @Profesor_cedula VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Profesor_nombre VARCHAR(50),
									@Profesor_primerApellido VARCHAR(50),
									@Profesor_segundoApellido VARCHAR(50),
									@Profesor_telefono VARCHAR(20),
									@Profesor_correoElectronico VARCHAR(50),
									@Profesor_direccion VARCHAR(50),
									@Profesor_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TProfesor(                  /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Profesor_cedula,
							Profesor_nombre,
							Profesor_primerApellido,
							Profesor_segundoApellido,
							Profesor_telefono,
							Profesor_correoElectronico,
							Profesor_direccion,
							Profesor_estado) 
	SELECT                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Profesor_cedula,
			@Profesor_nombre,
			@Profesor_primerApellido,
			@Profesor_segundoApellido,
			@Profesor_telefono,
			@Profesor_correoElectronico,
			@Profesor_direccion,
			@Profesor_estado
END
GO
/****** Object:  StoredProcedure [dbo].[ListarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarAula]
AS
BEGIN
	SELECT Aula_id,
			Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			Aula_capacidad,
			Aula_estado
	FROM TAula
	WHERE Aula_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN CURSO=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarCurso]
AS
BEGIN
	SELECT Curso_id,
			Curso_nombre,					
			Curso_creditos,
			Curso_cupo,
			Curso_estado
	FROM TCurso
	WHERE Curso_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarEstudiantes]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN ESTUDIANTE=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarEstudiantes]
AS
BEGIN
	SELECT Estudiante_id,
		   Grupo_id,
		   Estudiante_cedula,
		   Estudiante_nombre,
		   Estudiante_primerApellido,
		   Estudiante_segundoApellido,
		   Estudiante_telefono,
		   Estudiante_correoElectronico, 
		   Estudiante_direccion,
		   Estudiante_estado
	FROM TEstudiante
	WHERE Estudiante_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN GRUPO=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarGrupo]
as
BEGIN
	SELECT Grupo_id ,                     
			Grupo_descripcion ,
			Grupo_estado
			
	FROM TGrupo
	WHERE Grupo_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarHorario]
AS
BEGIN
	SELECT  Horario_id,
			Horario_descripcion,
			Horario_dia,
			Horario_horaInicio,
			Horario_horaFin,
			Horario_estado
		   
	FROM THorario
	WHERE Horario_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ListarInactivoAula]
AS
BEGIN
	SELECT Aula_id,
			Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			Aula_capacidad,
			Aula_estado
	FROM TAula
	WHERE Aula_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarInactivoCurso]
AS
BEGIN
	SELECT Curso_id,
			Curso_nombre,					
			Curso_creditos,
			Curso_cupo,
			Curso_estado
	FROM TCurso
	WHERE Curso_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoEstudiantes]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarInactivoEstudiantes]
AS
BEGIN
	SELECT Estudiante_id,
		   Grupo_id,
		   Estudiante_cedula,
		   Estudiante_nombre,
		   Estudiante_primerApellido,
		   Estudiante_segundoApellido,
		   Estudiante_telefono,
		   Estudiante_correoElectronico, 
		   Estudiante_direccion,
		   Estudiante_estado
	FROM TEstudiante
	WHERE Estudiante_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarInactivoGrupo]
AS
BEGIN
	SELECT Grupo_id ,                     
			Grupo_descripcion ,
			Grupo_estado
			
	FROM TGrupo
	WHERE Grupo_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ListarInactivoHorario]
AS
BEGIN
	SELECT  Horario_id,
			Horario_descripcion,
			Horario_dia,
			Horario_horaInicio,
			Horario_horaFin,
			Horario_estado
		   
	FROM THorario
	WHERE Horario_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ListarInactivoMatricula]
AS
BEGIN
	SELECT Matricula_id,                     
			Estudiante_id,
			Grupo_id,
			Curso_id,
			Profesor_id,
			Horario_id,
			Aula_id,
			Matricula_comprobante,
			Matricula_estado
	FROM TMatricula
	WHERE Matricula_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarInactivoProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarInactivoProfesor]
AS
BEGIN
	SELECT Profesor_id,
		   Profesor_cedula,
		   Profesor_nombre,
		   Profesor_primerApellido,
		   Profesor_segundoApellido,
		   Profesor_telefono,
		   Profesor_correoElectronico, 
		  Profesor_direccion,
		   Profesor_estado
	FROM TProfesor
	WHERE Profesor_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UNA MATRICULA=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarMatricula]
as
BEGIN
	SELECT Matricula_id,                     
			Estudiante_id,
			Grupo_id,
			Curso_id,
			Profesor_id,
			Horario_id,
			Aula_id,
			Matricula_comprobante,
			Matricula_estado
	FROM TMatricula
	WHERE Matricula_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACIÓN DE UN PROFESOR=================================*/
/*==================================================================================================*/
CREATE PROCEDURE [dbo].[ListarProfesor]
AS
BEGIN
	SELECT Profesor_id,
		   Profesor_cedula,
		   Profesor_nombre,
		   Profesor_primerApellido,
		   Profesor_segundoApellido,
		   Profesor_telefono,
		   Profesor_correoElectronico, 
		  Profesor_direccion,
		   Profesor_estado
	FROM TProfesor
	WHERE Profesor_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarAula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'

/*==================================================================================================*/
/*===================MODIFICAR AULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarAula] @Aula_id INT,
								                       /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								@Aula_descripcion VARCHAR(20),				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
								@Aula_capacidad VARCHAR(20),
								@Aula_estado VARCHAR(1)  
AS
	BEGIN
		UPDATE TAula
		SET 
			Aula_descripcion =	@Aula_descripcion,				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
			Aula_capacidad = @Aula_capacidad,
			Aula_estado =@Aula_estado  
		WHERE Aula_id = @Aula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarCurso]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'

/*==================================================================================================*/
/*===================MODIFICAR CURSO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarCurso] @Curso_id INT,
								                       /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								 @Curso_nombre VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Profesor_id), NO SE RECIBE COMO PARÁMETRO*/	
								 @Curso_creditos VARCHAR(20),
								 @Curso_cupo VARCHAR(20),
								 @Curso_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TCurso
		SET 
				Curso_nombre=@Curso_nombre,			/*NOTEN QUE LA LLAVE PRIMARIA (Curso_id), NO SE RECIBE COMO PARÁMETRO*/	
				Curso_creditos= @Curso_creditos,
				Curso_cupo= @Curso_cupo,
				Curso_estado= @Curso_estado
		WHERE Curso_id = @Curso_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarEstudiante]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'

/*==================================================================================================*/
/*===================MODIFICAR ESTUDIANTE ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarEstudiante] @Estudiante_id INT,
								     @Grupo_id INT,                    /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								     @Estudiante_cedula VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								     @Estudiante_nombre VARCHAR(50),
								     @Estudiante_primerApellido VARCHAR(50),
								     @Estudiante_segundoApellido VARCHAR(50),
								     @Estudiante_telefono VARCHAR(20),
								     @Estudiante_correoElectronico VARCHAR(50),
								     @Estudiante_direccion VARCHAR(50),
								     @Estudiante_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TEstudiante
		SET Grupo_id = @Grupo_id,
			Estudiante_cedula = @Estudiante_cedula,
			Estudiante_nombre = @Estudiante_nombre,
			Estudiante_primerApellido = @Estudiante_primerApellido,
			Estudiante_segundoApellido = @Estudiante_segundoApellido,
			Estudiante_telefono = @Estudiante_telefono,
			Estudiante_correoElectronico = @Estudiante_correoElectronico,
			Estudiante_direccion = @Estudiante_direccion,
			Estudiante_estado = @Estudiante_estado
		WHERE Estudiante_id = @Estudiante_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarGrupo]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'*/

/*==================================================================================================*/
/*===================MODIFICAR GRUPO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarGrupo] @Grupo_id int ,                     
								    @Grupo_descripcion varchar(50),				
									@Grupo_estado varchar(50)				
									
AS
	BEGIN
		UPDATE TGrupo
		SET 
		
			Grupo_descripcion = @Grupo_descripcion,
			Grupo_estado = @Grupo_estado
			
			WHERE Grupo_id = @Grupo_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarHorario]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'

/*==================================================================================================*/
/*===================MODIFICAR HORARIO ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarHorario] @Horario_id INT,
						@Horario_descripcion VARCHAR(20),
						@Horario_dia VARCHAR(15),
						@Horario_horaInicio VARCHAR (30),
						@Horario_horaFin VARCHAR(30),
						@Horario_estado VARCHAR(1)		                       
								 
AS
	BEGIN
		UPDATE THorario
		SET 
			Horario_descripcion =	@Horario_descripcion,					
			Horario_dia = @Horario_dia,
			Horario_horaInicio= @Horario_horaInicio,
			Horario_horaFin= @Horario_horaFin,
			Horario_estado= @Horario_estado
		WHERE Horario_id = @Horario_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarMatricula]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'*/

/*==================================================================================================*/
/*===================MODIFICAR MATRICULA ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarMatricula] @Matricula_id int,                     
								    @Estudiante_id int,				/*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Grupo_id int,				/*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Matricula_id)*/
									@Curso_id int,
									@Profesor_id int,
									@Horario_id int,
									@Aula_id int,
									@Matricula_comprobante varchar (20),
									@Matricula_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TMatricula
		SET 
		Grupo_id = @Grupo_id,
			Curso_id = @Curso_id,
			Profesor_id = @Profesor_id,
			Horario_id = @Horario_id,
			Aula_id = @Aula_id,
			Matricula_comprobante = @Matricula_comprobante,
			Matricula_estado = @Matricula_estado
			WHERE Matricula_id = @Matricula_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarProfesor]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--InsertarEstudiante 1, '123','Gaby','Loaiza','Mora','83','g','CN','A'

/*==================================================================================================*/
/*===================MODIFICAR PROFESOR ==========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE [dbo].[ModificarProfesor] @Profesor_id INT,
								                       /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								     @Profesor_cedula VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								     @Profesor_nombre VARCHAR(50),
								     @Profesor_primerApellido VARCHAR(50),
								     @Profesor_segundoApellido VARCHAR(50),
								     @Profesor_telefono VARCHAR(20),
								     @Profesor_correoElectronico VARCHAR(50),
								     @Profesor_direccion VARCHAR(50),
								     @Profesor_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TProfesor
		SET 
			Profesor_cedula = @Profesor_cedula,
			Profesor_nombre = @Profesor_nombre,
			Profesor_primerApellido = @Profesor_primerApellido,
			Profesor_segundoApellido = @Profesor_segundoApellido,
			Profesor_telefono = @Profesor_telefono,
			Profesor_correoElectronico = @Profesor_correoElectronico,
			Profesor_direccion = @Profesor_direccion,
			Profesor_estado = @Profesor_estado
		WHERE Profesor_id = @Profesor_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ProfesorOcupado]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ProfesorOcupado]
@id as int
as
	select * from TMatricula where Profesor_id=@id;
GO
/****** Object:  StoredProcedure [dbo].[UsuarioLogin]    Script Date: 24/9/2021 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UsuarioLogin]
	@nick varchar(10),
	@contrasenia varchar(10)
as 
	select Usuario_area, Usuario_nombre from TUsuario
	where Usuario_nick = @nick and Usuario_contrasenia = @contrasenia
GO
USE [master]
GO
ALTER DATABASE [Registro_de_Matricula] SET  READ_WRITE 
GO
