USE [master]
GO
/****** Object:  Database [Arduino]    Script Date: 21.12.2017 13:41:55 ******/
CREATE DATABASE [Arduino]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Arduino', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Arduino.mdf' , SIZE = 102400KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Arduino_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Arduino_log.ldf' , SIZE = 20480KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Arduino] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Arduino].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Arduino] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Arduino] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Arduino] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Arduino] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Arduino] SET ARITHABORT OFF 
GO
ALTER DATABASE [Arduino] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Arduino] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Arduino] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Arduino] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Arduino] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Arduino] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Arduino] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Arduino] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Arduino] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Arduino] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Arduino] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Arduino] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Arduino] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Arduino] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Arduino] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Arduino] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Arduino] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Arduino] SET RECOVERY FULL 
GO
ALTER DATABASE [Arduino] SET  MULTI_USER 
GO
ALTER DATABASE [Arduino] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Arduino] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Arduino] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Arduino] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Arduino] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Arduino]
GO
/****** Object:  Table [dbo].[login]    Script Date: 21.12.2017 13:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] NOT NULL,
	[kullaniciAdi] [nvarchar](50) NOT NULL,
	[kullaniciSifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nem]    Script Date: 21.12.2017 13:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tarih] [nvarchar](max) NOT NULL,
	[nem] [smallint] NOT NULL,
 CONSTRAINT [PK_nem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sicaklik]    Script Date: 21.12.2017 13:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sicaklik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tarih] [nvarchar](max) NOT NULL,
	[sicaklik] [smallint] NOT NULL,
 CONSTRAINT [PK_sicaklik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[login] ([id], [kullaniciAdi], [kullaniciSifre]) VALUES (1, N'admin', N'pass')
SET IDENTITY_INSERT [dbo].[nem] ON 

INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (1, N'17.12.2017 13:40:49', 52)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (2, N'17.12.2017 13:41:01', 52)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (3, N'17.12.2017 13:41:13', 51)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (4, N'17.12.2017 13:41:25', 50)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (5, N'17.12.2017 13:41:37', 10)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (6, N'17.12.2017 13:41:49', 5)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (7, N'17.12.2017 13:42:01', 5)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (8, N'17.12.2017 13:42:13', 4)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (9, N'17.12.2017 13:42:25', 4)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (10, N'19.12.2017 13:43:44', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (11, N'19.12.2017 13:43:56', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (12, N'19.12.2017 13:44:08', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (13, N'19.12.2017 13:44:20', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (14, N'19.12.2017 13:44:32', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (15, N'19.12.2017 13:44:44', 30)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (16, N'19.12.2017 13:44:56', 29)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (17, N'20.12.2017 00:02:52', 57)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (18, N'20.12.2017 00:03:04', 57)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (19, N'20.12.2017 00:03:16', 57)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (20, N'20.12.2017 00:03:28', 36)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (21, N'20.12.2017 00:03:40', 36)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (22, N'20.12.2017 00:03:52', 36)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (23, N'20.12.2017 01:55:30', 36)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (24, N'20.12.2017 01:55:42', 20)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (25, N'20.12.2017 01:55:54', 19)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (26, N'20.12.2017 01:56:06', 35)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (27, N'20.12.2017 01:56:18', 33)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (28, N'20.12.2017 01:56:30', 33)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (29, N'20.12.2017 01:56:42', 33)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (30, N'20.12.2017 13:54:25', 70)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (31, N'20.12.2017 13:54:36', 69)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (32, N'20.12.2017 13:54:48', 69)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (33, N'20.12.2017 13:55:01', 69)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (34, N'20.12.2017 13:55:13', 69)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (35, N'20.12.2017 13:55:24', 68)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (36, N'20.12.2017 13:55:37', 68)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (37, N'20.12.2017 13:55:49', 68)
INSERT [dbo].[nem] ([id], [tarih], [nem]) VALUES (38, N'20.12.2017 13:56:01', 68)
SET IDENTITY_INSERT [dbo].[nem] OFF
SET IDENTITY_INSERT [dbo].[sicaklik] ON 

INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (1, N'17.12.2017 13:40:43', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (2, N'17.12.2017 13:40:55', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (3, N'17.12.2017 13:41:07', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (4, N'17.12.2017 13:41:19', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (5, N'17.12.2017 13:41:31', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (6, N'17.12.2017 13:41:43', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (7, N'17.12.2017 13:41:55', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (8, N'17.12.2017 13:42:07', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (9, N'17.12.2017 13:42:19', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (10, N'17.12.2017 13:42:31', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (11, N'19.12.2017 13:43:38', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (12, N'19.12.2017 13:43:50', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (13, N'19.12.2017 13:44:02', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (14, N'19.12.2017 13:44:14', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (15, N'19.12.2017 13:44:26', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (16, N'19.12.2017 13:44:38', 25)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (17, N'19.12.2017 13:44:50', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (18, N'20.12.2017 00:02:46', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (19, N'20.12.2017 00:02:58', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (20, N'20.12.2017 00:03:10', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (21, N'20.12.2017 00:03:22', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (22, N'20.12.2017 00:03:34', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (23, N'20.12.2017 00:03:46', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (24, N'20.12.2017 01:55:24', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (25, N'20.12.2017 01:55:36', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (26, N'20.12.2017 01:55:48', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (27, N'20.12.2017 01:56:00', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (28, N'20.12.2017 01:56:12', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (29, N'20.12.2017 01:56:24', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (30, N'20.12.2017 01:56:36', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (31, N'20.12.2017 01:56:48', 24)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (32, N'20.12.2017 13:54:19', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (33, N'20.12.2017 13:54:31', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (34, N'20.12.2017 13:54:42', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (35, N'20.12.2017 13:54:54', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (36, N'20.12.2017 13:55:07', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (37, N'20.12.2017 13:55:18', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (38, N'20.12.2017 13:55:30', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (39, N'20.12.2017 13:55:43', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (40, N'20.12.2017 13:55:55', 23)
INSERT [dbo].[sicaklik] ([id], [tarih], [sicaklik]) VALUES (41, N'20.12.2017 13:56:07', 23)
SET IDENTITY_INSERT [dbo].[sicaklik] OFF
USE [master]
GO
ALTER DATABASE [Arduino] SET  READ_WRITE 
GO
