USE [master]
GO
/****** Object:  Database [dream_housing]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE DATABASE [dream_housing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dream_housing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dream_housing.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dream_housing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dream_housing_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dream_housing] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dream_housing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dream_housing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dream_housing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dream_housing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dream_housing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dream_housing] SET ARITHABORT OFF 
GO
ALTER DATABASE [dream_housing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dream_housing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dream_housing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dream_housing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dream_housing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dream_housing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dream_housing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dream_housing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dream_housing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dream_housing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dream_housing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dream_housing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dream_housing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dream_housing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dream_housing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dream_housing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dream_housing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dream_housing] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dream_housing] SET  MULTI_USER 
GO
ALTER DATABASE [dream_housing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dream_housing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dream_housing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dream_housing] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dream_housing] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dream_housing] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dream_housing] SET QUERY_STORE = ON
GO
ALTER DATABASE [dream_housing] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dream_housing]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agents]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ContactInfo] [nvarchar](max) NOT NULL,
	[CreatedAt] [nvarchar](max) NOT NULL,
	[UpdatedAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Agents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
	[Time] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[CreatedAt] [nvarchar](max) NOT NULL,
	[UpdatedAt] [nvarchar](max) NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Property_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ContactInfo] [nvarchar](max) NOT NULL,
	[Preferences] [nvarchar](max) NOT NULL,
	[CreatedAt] [nvarchar](max) NOT NULL,
	[UpdatedAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Property_ID] [int] NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Rating] [nvarchar](max) NOT NULL,
	[Comments] [nvarchar](max) NOT NULL,
	[SubmittedAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Feedbacks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Properties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[Price] [float] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[CreatedAt] [nvarchar](max) NOT NULL,
	[UpdatedAt] [nvarchar](max) NOT NULL,
	[Agent_ID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Properties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/31/2024 5:08:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](max) NOT NULL,
	[CreatedAt] [nvarchar](max) NOT NULL,
	[UpdatedAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Id]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Id] ON [dbo].[Agents]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Client_ID]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Client_ID] ON [dbo].[Appointments]
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Property_ID]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Property_ID] ON [dbo].[Appointments]
(
	[Property_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Id]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Id] ON [dbo].[Clients]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Property_ID]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Property_ID] ON [dbo].[Feedbacks]
(
	[Property_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Agent_ID]    Script Date: 7/31/2024 5:08:18 PM ******/
CREATE NONCLUSTERED INDEX [IX_Agent_ID] ON [dbo].[Properties]
(
	[Agent_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments] ADD  DEFAULT ((0)) FOR [Client_ID]
GO
ALTER TABLE [dbo].[Appointments] ADD  DEFAULT ((0)) FOR [Property_ID]
GO
ALTER TABLE [dbo].[Properties] ADD  DEFAULT ((0)) FOR [Agent_ID]
GO
ALTER TABLE [dbo].[Agents]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Agents_dbo.Users_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Agents] CHECK CONSTRAINT [FK_dbo.Agents_dbo.Users_Id]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Appointments_dbo.Clients_Client_ID] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_dbo.Appointments_dbo.Clients_Client_ID]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Appointments_dbo.Properties_Property_ID] FOREIGN KEY([Property_ID])
REFERENCES [dbo].[Properties] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_dbo.Appointments_dbo.Properties_Property_ID]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Clients_dbo.Users_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_dbo.Clients_dbo.Users_Id]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Feedbacks_dbo.Properties_Property_ID] FOREIGN KEY([Property_ID])
REFERENCES [dbo].[Properties] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_dbo.Feedbacks_dbo.Properties_Property_ID]
GO
ALTER TABLE [dbo].[Properties]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Properties_dbo.Agents_Agent_ID] FOREIGN KEY([Agent_ID])
REFERENCES [dbo].[Agents] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Properties] CHECK CONSTRAINT [FK_dbo.Properties_dbo.Agents_Agent_ID]
GO
USE [master]
GO
ALTER DATABASE [dream_housing] SET  READ_WRITE 
GO
