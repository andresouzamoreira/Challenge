USE [master]
GO

/****** Object:  Database [BD_CHALENGE]    Script Date: 21/10/2020 21:55:08 ******/
CREATE DATABASE [BD_CHALENGE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_CHALENGE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_CHALENGE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_CHALENGE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_CHALENGE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_CHALENGE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BD_CHALENGE] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET ARITHABORT OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BD_CHALENGE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BD_CHALENGE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BD_CHALENGE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BD_CHALENGE] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET RECOVERY FULL 
GO

ALTER DATABASE [BD_CHALENGE] SET  MULTI_USER 
GO

ALTER DATABASE [BD_CHALENGE] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BD_CHALENGE] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BD_CHALENGE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BD_CHALENGE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BD_CHALENGE] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BD_CHALENGE] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BD_CHALENGE] SET  READ_WRITE 
GO

