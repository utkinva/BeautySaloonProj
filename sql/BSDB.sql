USE [master]
GO
CREATE DATABASE [BSDB]
GO
USE [BSDB]
GO
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

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
	[Time] [time](7) NOT NULL,
 CONSTRAINT [PK_CurrentOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

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
	[Time] [time](7) NOT NULL,
 CONSTRAINT [PK_OrderHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MasterID] [int] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[Weekdays] [nvarchar](50) NULL,
	[Weekend] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12.06.2022 12:30:16 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([ID], [Name], [Phone], [Email]) VALUES (9, N'Иван', N'+7 (955) 065-16-55', NULL)
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[CurrentOrders] ON 
GO
INSERT [dbo].[CurrentOrders] ([ID], [ServiceID], [ClientID], [MasterID], [Date], [Time]) VALUES (13, 3, 9, 9, CAST(N'2020-05-15' AS Date), CAST(N'19:49:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[CurrentOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[Masters] ON 
GO
INSERT [dbo].[Masters] ([ID], [Name], [Phone], [Specialization]) VALUES (9, N'Алексей', N'+7 (951) 515-11-20', N'Парикмахер')
GO
INSERT [dbo].[Masters] ([ID], [Name], [Phone], [Specialization]) VALUES (18, N'Мария', N'+7 (956) 165-15-21', N'Мастер маникюра')
GO
SET IDENTITY_INSERT [dbo].[Masters] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderHistory] ON 
GO
INSERT [dbo].[OrderHistory] ([ID], [ServiceID], [ClientID], [MasterID], [Date], [Time]) VALUES (1, 3, 9, 9, CAST(N'2022-05-18' AS Date), CAST(N'20:55:00' AS Time))
GO
INSERT [dbo].[OrderHistory] ([ID], [ServiceID], [ClientID], [MasterID], [Date], [Time]) VALUES (2, 3, 9, 9, CAST(N'2022-12-12' AS Date), CAST(N'12:12:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[OrderHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 
GO
INSERT [dbo].[Schedule] ([ID], [MasterID], [StartTime], [EndTime], [Weekdays], [Weekend]) VALUES (34, 9, CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), N'asdasd', N'ПН, СР, ПТ')
GO
INSERT [dbo].[Schedule] ([ID], [MasterID], [StartTime], [EndTime], [Weekdays], [Weekend]) VALUES (42, 18, CAST(N'14:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, N'СР, СБ, ВС')
GO
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 
GO
INSERT [dbo].[Services] ([ID], [Title], [Cost], [Description]) VALUES (3, N'Стрижка', CAST(500 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID], [Name]) VALUES (N'admin', N'admin', 3, N'Алексеев С. А.')
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID], [Name]) VALUES (N'master', N'master', 2, N'Шпак Сергей Сергеевич')
GO
SET IDENTITY_INSERT [dbo].[UserTypes] ON 
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (2, N'Мастер', NULL)
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (3, N'Администратор', NULL)
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
ALTER TABLE [dbo].[OrderHistory]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistory_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderHistory] CHECK CONSTRAINT [FK_OrderHistory_Clients]
GO
ALTER TABLE [dbo].[OrderHistory]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistory_Masters] FOREIGN KEY([MasterID])
REFERENCES [dbo].[Masters] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderHistory] CHECK CONSTRAINT [FK_OrderHistory_Masters]
GO
ALTER TABLE [dbo].[OrderHistory]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistory_Services] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderHistory] CHECK CONSTRAINT [FK_OrderHistory_Services]
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
