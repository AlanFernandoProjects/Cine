USE [master]
GO
/****** Object:  Database [SistemaCine4]    Script Date: 11/01/2018 13:29:15 ******/
CREATE DATABASE [SistemaCine4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaCine4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SistemaCine4.mdf' , SIZE = 5312KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaCine4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SistemaCine4_log.ldf' , SIZE = 1856KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaCine4] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaCine4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaCine4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaCine4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaCine4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaCine4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaCine4] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaCine4] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaCine4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaCine4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaCine4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaCine4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaCine4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaCine4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaCine4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaCine4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaCine4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaCine4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaCine4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaCine4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaCine4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaCine4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaCine4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaCine4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaCine4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaCine4] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaCine4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaCine4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaCine4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaCine4] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SistemaCine4] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SistemaCine4]
GO
/****** Object:  Table [dbo].[Cartelera]    Script Date: 11/01/2018 13:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cartelera](
	[FechayHora] [datetime] NULL,
	[Idioma] [varchar](50) NULL,
	[Titulo] [varchar](50) NULL,
	[Sala] [int] NULL,
	[carteleraID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[carteleraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 11/01/2018 13:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pelicula](
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Actores] [varchar](200) NOT NULL,
	[Estreno] [date] NOT NULL,
	[Duracion] [varchar](4) NOT NULL,
	[Imagen] [image] NOT NULL,
	[peliculaID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED 
(
	[peliculaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 11/01/2018 13:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[NumSala] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[salaID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[salaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Socio]    Script Date: 11/01/2018 13:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socio](
	[NumTarjeta] [int] NULL,
	[ApellidoPaterno] [varchar](50) NOT NULL,
	[ApellidoMaterno] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CURP] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaDeAlta] [datetime] NOT NULL,
	[Puntos] [numeric](10, 2) NULL,
	[socioID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Socio] PRIMARY KEY CLUSTERED 
(
	[socioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/01/2018 13:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[Folio] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Titulo] [varchar](50) NULL,
	[Idioma] [varchar](20) NULL,
	[Sala] [int] NULL,
	[Edad] [varchar](20) NULL,
	[TarjetaSocio] [int] NULL,
	[Cantidad] [int] NULL,
	[PagoCliente] [int] NULL,
	[Cambio] [int] NULL,
	[TotalPagar] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [SistemaCine4] SET  READ_WRITE 
GO
