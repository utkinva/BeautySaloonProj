USE [master]
GO
/****** Object:  Database [BSDB]    Script Date: 13.05.2022 0:12:41 ******/
CREATE DATABASE [BSDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BSDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BSDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BSDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BSDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BSDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BSDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BSDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BSDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BSDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BSDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BSDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BSDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BSDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BSDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BSDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BSDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BSDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BSDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BSDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BSDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BSDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BSDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BSDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BSDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BSDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BSDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BSDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BSDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BSDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BSDB] SET  MULTI_USER 
GO
ALTER DATABASE [BSDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BSDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BSDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BSDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BSDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BSDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BSDB] SET QUERY_STORE = OFF
GO
USE [BSDB]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CurrentOrders]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentOrders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[MasterID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_CurrentOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masters]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Specialization] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Masters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHistory]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[MasterID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_OrderHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MasterID] [int] NOT NULL,
	[StartTime] [nvarchar](50) NULL,
	[EndTime] [nvarchar](50) NULL,
	[Weekdays] [nvarchar](50) NOT NULL,
	[Weekend] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[UserTypeID] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTypes]    Script Date: 13.05.2022 0:12:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([ID], [Name], [Phone], [Email]) VALUES (1, N'Лаврова Светлана Александровна', N'89223823485', NULL)
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[CurrentOrders] ON 
GO
INSERT [dbo].[CurrentOrders] ([ID], [ServiceID], [ClientID], [MasterID], [Date]) VALUES (1, 1, 1, 1, CAST(N'2022-05-12' AS Date))
GO
SET IDENTITY_INSERT [dbo].[CurrentOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[Masters] ON 
GO
INSERT [dbo].[Masters] ([ID], [Name], [Phone], [Specialization]) VALUES (1, N'Асминкина Алеся Андреевна', N'89056687795', N'Мастер ногтевого сервиса')
GO
INSERT [dbo].[Masters] ([ID], [Name], [Phone], [Specialization]) VALUES (4, N'Дорофеева Алина Георгиевна', N'89664516298', N'Мастер ногтевого сервиса')
GO
INSERT [dbo].[Masters] ([ID], [Name], [Phone], [Specialization]) VALUES (5, N'Макаров Вячеслав Сергеевич', N'89669546641', N'Парикмахер')
GO
SET IDENTITY_INSERT [dbo].[Masters] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 
GO
INSERT [dbo].[Schedule] ([ID], [MasterID], [StartTime], [EndTime], [Weekdays], [Weekend]) VALUES (1, 1, N'11:45', N'18:00', N'ПН, ВТ, СР. ЧТ', N'ПТ, СБ, ВС')
GO
INSERT [dbo].[Schedule] ([ID], [MasterID], [StartTime], [EndTime], [Weekdays], [Weekend]) VALUES (2, 4, N'14:00', N'22:00', N'ПН, ВТ, СР, ЧТ, ПТ', N'СБ, ВС')
GO
INSERT [dbo].[Schedule] ([ID], [MasterID], [StartTime], [EndTime], [Weekdays], [Weekend]) VALUES (3, 5, N'09:00', N'17:00', N'ПН, ВТ, СР, ЧТ, ПТ', N'СБ, ВС')
GO
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 
GO
INSERT [dbo].[Services] ([ID], [Title], [Cost], [Description]) VALUES (1, N'Окраска волос', CAST(2500 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[Services] ([ID], [Title], [Cost], [Description]) VALUES (2, N'Наращивание ногтей', CAST(5000 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID], [Name]) VALUES (N'admin', N'admin', 1, N'Шевченко Алексей Сергеевич')
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID], [Name]) VALUES (N'seregamaster', N'seregamaster', 2, N'Шпак Сергей Сергеевич')
GO
SET IDENTITY_INSERT [dbo].[UserTypes] ON 
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (1, N'Администратор', NULL)
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (2, N'Мастер', NULL)
GO
SET IDENTITY_INSERT [dbo].[UserTypes] OFF
GO
ALTER TABLE [dbo].[CurrentOrders]  WITH CHECK ADD  CONSTRAINT [FK_CurrentOrders_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurrentOrders] CHECK CONSTRAINT [FK_CurrentOrders_Clients]
GO
ALTER TABLE [dbo].[CurrentOrders]  WITH CHECK ADD  CONSTRAINT [FK_CurrentOrders_Masters] FOREIGN KEY([MasterID])
REFERENCES [dbo].[Masters] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurrentOrders] CHECK CONSTRAINT [FK_CurrentOrders_Masters]
GO
ALTER TABLE [dbo].[CurrentOrders]  WITH CHECK ADD  CONSTRAINT [FK_CurrentOrders_Services] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CurrentOrders] CHECK CONSTRAINT [FK_CurrentOrders_Services]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Masters] FOREIGN KEY([MasterID])
REFERENCES [dbo].[Masters] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Masters]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[UserTypes] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
USE [master]
GO
ALTER DATABASE [BSDB] SET  READ_WRITE 
GO
