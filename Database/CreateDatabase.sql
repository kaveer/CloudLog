USE [master]
GO

/****** Object:  Database [CloudLog]    Script Date: 10/23/2019 8:26:36 PM ******/
CREATE DATABASE [CloudLog]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CloudLog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CloudLog.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CloudLog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CloudLog_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [CloudLog] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CloudLog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CloudLog] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CloudLog] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CloudLog] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CloudLog] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CloudLog] SET ARITHABORT OFF 
GO

ALTER DATABASE [CloudLog] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CloudLog] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CloudLog] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CloudLog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CloudLog] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CloudLog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CloudLog] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CloudLog] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CloudLog] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CloudLog] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CloudLog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CloudLog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CloudLog] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CloudLog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CloudLog] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CloudLog] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CloudLog] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CloudLog] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [CloudLog] SET  MULTI_USER 
GO

ALTER DATABASE [CloudLog] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CloudLog] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CloudLog] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CloudLog] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CloudLog] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CloudLog] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CloudLog] SET  READ_WRITE 
GO


