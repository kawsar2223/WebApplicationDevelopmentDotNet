USE [master]
GO
/****** Object:  Database [StudentResultManagementDB]    Script Date: 1/26/2016 5:16:36 PM ******/
CREATE DATABASE [StudentResultManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentResultManagementDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentResultManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentResultManagementDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentResultManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StudentResultManagementDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentResultManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentResultManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StudentResultManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentResultManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentResultManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentResultManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentResultManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentResultManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentResultManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentResultManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentResultManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentResultManagementDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StudentResultManagementDB]
GO
/****** Object:  StoredProcedure [dbo].[spVieStudentResult]    Script Date: 1/26/2016 5:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[spVieStudentResult]

 
    AS
  BEGIN
   
  SELECT r.RegNo,s.Name,r.Score FROM t_StudentResult r INNER JOIN t_Subject s ON r.SubjectId=s.Id
  END
GO
/****** Object:  Table [dbo].[t_StudentResult]    Script Date: 1/26/2016 5:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_StudentResult](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [nvarchar](6) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[Score] [float] NOT NULL,
 CONSTRAINT [PK_t_StudentResult] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_Subject]    Script Date: 1/26/2016 5:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[t_StudentResult]  WITH CHECK ADD  CONSTRAINT [FK_t_StudentResult_t_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[t_Subject] ([Id])
GO
ALTER TABLE [dbo].[t_StudentResult] CHECK CONSTRAINT [FK_t_StudentResult_t_Subject]
GO
USE [master]
GO
ALTER DATABASE [StudentResultManagementDB] SET  READ_WRITE 
GO
