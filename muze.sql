USE [MuseumDB]
GO
/****** Object:  Table [dbo].[ArtWork]    Script Date: 11.04.2022 13:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtWork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtWorkCode] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[AuthorityId] [int] NULL,
	[Images] [nvarchar](100) NULL,
	[Price] [int] NULL,
	[State] [bit] NULL,
 CONSTRAINT [PK__ArtWork__3214EC07C1CE0B95] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArtWorkBuy]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtWorkBuy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtWorkCode] [nvarchar](50) NULL,
	[ArtWorkId] [int] NULL,
	[StaffId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Images] [nvarchar](100) NULL,
	[Date] [date] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK__ArtWorkB__3214EC077D4A3F27] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArtWorkRestore]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtWorkRestore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtWorkId] [int] NULL,
	[ArtWorkCode] [nvarchar](50) NULL,
	[StaffId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Image] [nvarchar](50) NULL,
	[RestoreDate] [date] NULL,
	[Price] [int] NULL,
	[State] [bit] NULL,
 CONSTRAINT [PK__ArtWorkR__3214EC07B34BB58C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArtWorkSale]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtWorkSale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtWorkCode] [nvarchar](50) NULL,
	[ArtWorkId] [int] NULL,
	[StaffId] [int] NULL,
	[MemberId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[GiveDate] [datetime] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK__ArtWorkS__3214EC0785622ED8] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authority]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authority](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Authority] [nvarchar](20) NOT NULL,
	[State] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GetTicketBack]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GetTicketBack](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StaffId] [int] NULL,
	[AuthorityId] [int] NULL,
	[MemberId] [int] NULL,
	[TicketCategoryId] [int] NULL,
	[TicketSectionId] [int] NULL,
	[BackDate] [date] NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK__GetTicke__3214EC0722A581B9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](11) NOT NULL,
	[EMail] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](1000) NULL,
	[State] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorityId] [int] NULL,
	[StaffId] [int] NULL,
	[Salary] [decimal](8, 2) NULL,
 CONSTRAINT [PK__Salary__3214EC0725DBAEFE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AuthorityId] [int] NOT NULL,
	[Password] [nvarchar](6) NOT NULL,
	[Salary] [int] NOT NULL,
	[State] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketCategory]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketSale]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketSale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuthorityId] [int] NULL,
	[StaffId] [int] NULL,
	[MemberId] [int] NULL,
	[TicketCategoryId] [int] NULL,
	[TicketSectionId] [int] NULL,
	[GiveDate] [date] NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK__TicketSa__3214EC07D026761C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketSection]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketSection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketStock]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketStock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketCategoryId] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ArtWork] ON 

INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (1, N'1-sorguc', N'Sorguç', 3, N'sorguc.png', 500, 1)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (2, N'1-zumrut', N'Zümrüt Küpe', 3, N'zumrut.png', 250, 1)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (3, N'1-taht', N'Taht Askısı', 3, N'taht.png', 600, 1)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (4, N'1-hancer', N'Hançer', 3, N'hancer.png', 390, 0)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (5, N'1-mughal', N'Mughal', 3, N'mughal.png', 400, 0)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (6, N'1-at', N'At Sorgucu Yayı', 3, N'at.png', 350, 0)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (8, N'A100', N'Altın Bilezik', 3, N'bilezik.png', 600, 1)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (10, N'b100', N'küpe', 3, N'küpe.png', 200, 1)
INSERT [dbo].[ArtWork] ([Id], [ArtWorkCode], [Name], [AuthorityId], [Images], [Price], [State]) VALUES (13, N'1-sorguc', N'Sorguç', 3, N'sorguc.png', 300, 1)
SET IDENTITY_INSERT [dbo].[ArtWork] OFF
SET IDENTITY_INSERT [dbo].[ArtWorkBuy] ON 

INSERT [dbo].[ArtWorkBuy] ([Id], [ArtWorkCode], [ArtWorkId], [StaffId], [Name], [Images], [Date], [Price]) VALUES (1, NULL, 2, 3, N'Yay Kesesi', NULL, CAST(N'2022-04-07' AS Date), 250)
SET IDENTITY_INSERT [dbo].[ArtWorkBuy] OFF
SET IDENTITY_INSERT [dbo].[ArtWorkRestore] ON 

INSERT [dbo].[ArtWorkRestore] ([Id], [ArtWorkId], [ArtWorkCode], [StaffId], [Name], [Image], [RestoreDate], [Price], [State]) VALUES (20, 4, N'1-hancer', 3, N'Hançer', N'hancer.png', CAST(N'2022-04-11' AS Date), 390, 0)
INSERT [dbo].[ArtWorkRestore] ([Id], [ArtWorkId], [ArtWorkCode], [StaffId], [Name], [Image], [RestoreDate], [Price], [State]) VALUES (21, 5, N'1-mughal', 3, N'Mughal', N'mughal.png', CAST(N'2022-04-11' AS Date), 400, 0)
INSERT [dbo].[ArtWorkRestore] ([Id], [ArtWorkId], [ArtWorkCode], [StaffId], [Name], [Image], [RestoreDate], [Price], [State]) VALUES (23, 6, N'1-at', 3, N'At Sorgucu Yayı', N'at.png', CAST(N'2022-04-11' AS Date), 350, 0)
SET IDENTITY_INSERT [dbo].[ArtWorkRestore] OFF
SET IDENTITY_INSERT [dbo].[ArtWorkSale] ON 

INSERT [dbo].[ArtWorkSale] ([Id], [ArtWorkCode], [ArtWorkId], [StaffId], [MemberId], [Name], [GiveDate], [Price]) VALUES (16, N'1-sorguc', 1, 3, 2, N'Sorguç', CAST(N'2022-03-05T00:00:00.000' AS DateTime), 500)
INSERT [dbo].[ArtWorkSale] ([Id], [ArtWorkCode], [ArtWorkId], [StaffId], [MemberId], [Name], [GiveDate], [Price]) VALUES (17, N'1-kasıkcı', 1, 3, 2, N'Kaşıkçı Elması', CAST(N'2022-03-05T00:00:00.000' AS DateTime), 5000)
SET IDENTITY_INSERT [dbo].[ArtWorkSale] OFF
SET IDENTITY_INSERT [dbo].[Authority] ON 

INSERT [dbo].[Authority] ([Id], [Authority], [State]) VALUES (1, N'Admin', 1)
INSERT [dbo].[Authority] ([Id], [Authority], [State]) VALUES (2, N'TicketStaff', 1)
INSERT [dbo].[Authority] ([Id], [Authority], [State]) VALUES (3, N'ArtStaff', 1)
INSERT [dbo].[Authority] ([Id], [Authority], [State]) VALUES (4, N'Accounting', 1)
SET IDENTITY_INSERT [dbo].[Authority] OFF
SET IDENTITY_INSERT [dbo].[GetTicketBack] ON 

INSERT [dbo].[GetTicketBack] ([Id], [StaffId], [AuthorityId], [MemberId], [TicketCategoryId], [TicketSectionId], [BackDate], [Quantity], [Price]) VALUES (3, 2, 2, 2, 2, 3, CAST(N'2022-04-09' AS Date), 2, 200)
INSERT [dbo].[GetTicketBack] ([Id], [StaffId], [AuthorityId], [MemberId], [TicketCategoryId], [TicketSectionId], [BackDate], [Quantity], [Price]) VALUES (4, 2, 2, 3, 1, 2, CAST(N'2022-04-10' AS Date), 1, 170)
INSERT [dbo].[GetTicketBack] ([Id], [StaffId], [AuthorityId], [MemberId], [TicketCategoryId], [TicketSectionId], [BackDate], [Quantity], [Price]) VALUES (5, 2, 2, 3, 1, 2, CAST(N'2022-04-10' AS Date), 1, 170)
INSERT [dbo].[GetTicketBack] ([Id], [StaffId], [AuthorityId], [MemberId], [TicketCategoryId], [TicketSectionId], [BackDate], [Quantity], [Price]) VALUES (6, 2, 2, 1, 2, 2, CAST(N'2022-04-10' AS Date), 1, 220)
SET IDENTITY_INSERT [dbo].[GetTicketBack] OFF
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (1, N'Sümeyye', N'Yorulmaz', N'5556663322', N'sumeyye@gmail.com', N'sumeyye.png', 1)
INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (2, N'Barış', N'Alkaya', N'5557774411', N'barıs@gmail.com', N'barıs.png', 1)
INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (3, N'Gökhan', N'Hasbal', N'5558887799', N'gokhan@gmail.com', N'gokhan.png', 1)
INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (4, N'Fatih', N'Dengiz', N'5545557889', N'fatih@gmail.com', N'fatih.png', 1)
INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (5, N'Beste', N'Semiz', N'5556264223', N'beste@gmail.com', N'beste.png', 1)
INSERT [dbo].[Member] ([Id], [Name], [LastName], [Telephone], [EMail], [Image], [State]) VALUES (6, N'Sezer', N'Varol', N'5554447789', N'sezer@gmail.com', N'sezer.png', 1)
SET IDENTITY_INSERT [dbo].[Member] OFF
SET IDENTITY_INSERT [dbo].[Salary] ON 

INSERT [dbo].[Salary] ([Id], [AuthorityId], [StaffId], [Salary]) VALUES (1, 1, 1, CAST(25000.00 AS Decimal(8, 2)))
INSERT [dbo].[Salary] ([Id], [AuthorityId], [StaffId], [Salary]) VALUES (2, 2, 2, CAST(10000.00 AS Decimal(8, 2)))
INSERT [dbo].[Salary] ([Id], [AuthorityId], [StaffId], [Salary]) VALUES (3, 3, 3, CAST(15000.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Salary] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id], [Name], [LastName], [AuthorityId], [Password], [Salary], [State]) VALUES (1, N'Sevde', N'Yorulmaz', 1, N'123123', 25000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [LastName], [AuthorityId], [Password], [Salary], [State]) VALUES (2, N'Nazlı', N'Ertesin', 2, N'123123', 10000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [LastName], [AuthorityId], [Password], [Salary], [State]) VALUES (3, N'Hatice', N'Başkonuş', 3, N'123123', 15000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [LastName], [AuthorityId], [Password], [Salary], [State]) VALUES (4, N'Rümeysa', N'Yorulmaz', 2, N'123123', 10000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [LastName], [AuthorityId], [Password], [Salary], [State]) VALUES (6, N'Ahmet', N'Şekerci', 4, N'123123', 12000, 1)
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[TicketCategory] ON 

INSERT [dbo].[TicketCategory] ([Id], [Name], [Price]) VALUES (1, N'Student', 50)
INSERT [dbo].[TicketCategory] ([Id], [Name], [Price]) VALUES (2, N'Adult', 100)
INSERT [dbo].[TicketCategory] ([Id], [Name], [Price]) VALUES (3, N'MuseumCard', 80)
SET IDENTITY_INSERT [dbo].[TicketCategory] OFF
SET IDENTITY_INSERT [dbo].[TicketSale] ON 

INSERT [dbo].[TicketSale] ([Id], [AuthorityId], [StaffId], [MemberId], [TicketCategoryId], [TicketSectionId], [GiveDate], [Quantity], [Price]) VALUES (17, 2, 2, 2, 3, 1, CAST(N'2022-04-10' AS Date), 1, 230)
INSERT [dbo].[TicketSale] ([Id], [AuthorityId], [StaffId], [MemberId], [TicketCategoryId], [TicketSectionId], [GiveDate], [Quantity], [Price]) VALUES (18, 2, 2, 3, 1, 1, CAST(N'2022-04-11' AS Date), 1, 200)
INSERT [dbo].[TicketSale] ([Id], [AuthorityId], [StaffId], [MemberId], [TicketCategoryId], [TicketSectionId], [GiveDate], [Quantity], [Price]) VALUES (19, 2, 2, 3, 1, 1, CAST(N'2022-04-11' AS Date), 1, 200)
SET IDENTITY_INSERT [dbo].[TicketSale] OFF
SET IDENTITY_INSERT [dbo].[TicketSection] ON 

INSERT [dbo].[TicketSection] ([Id], [Name], [Price]) VALUES (1, N'Harem', 150)
INSERT [dbo].[TicketSection] ([Id], [Name], [Price]) VALUES (2, N'Aya İrini', 120)
INSERT [dbo].[TicketSection] ([Id], [Name], [Price]) VALUES (3, N'Yok', 0)
SET IDENTITY_INSERT [dbo].[TicketSection] OFF
SET IDENTITY_INSERT [dbo].[TicketStock] ON 

INSERT [dbo].[TicketStock] ([Id], [TicketCategoryId], [Quantity]) VALUES (1, 1, 42)
INSERT [dbo].[TicketStock] ([Id], [TicketCategoryId], [Quantity]) VALUES (2, 2, 39)
INSERT [dbo].[TicketStock] ([Id], [TicketCategoryId], [Quantity]) VALUES (3, 3, 46)
SET IDENTITY_INSERT [dbo].[TicketStock] OFF
ALTER TABLE [dbo].[ArtWork]  WITH CHECK ADD  CONSTRAINT [FK_ArtWork_Authority] FOREIGN KEY([AuthorityId])
REFERENCES [dbo].[Authority] ([Id])
GO
ALTER TABLE [dbo].[ArtWork] CHECK CONSTRAINT [FK_ArtWork_Authority]
GO
ALTER TABLE [dbo].[ArtWorkBuy]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorkBuy_ArtWork] FOREIGN KEY([ArtWorkId])
REFERENCES [dbo].[ArtWork] ([Id])
GO
ALTER TABLE [dbo].[ArtWorkBuy] CHECK CONSTRAINT [FK_ArtWorkBuy_ArtWork]
GO
ALTER TABLE [dbo].[ArtWorkRestore]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorkRestore_ArtWork] FOREIGN KEY([ArtWorkId])
REFERENCES [dbo].[ArtWork] ([Id])
GO
ALTER TABLE [dbo].[ArtWorkRestore] CHECK CONSTRAINT [FK_ArtWorkRestore_ArtWork]
GO
ALTER TABLE [dbo].[ArtWorkSale]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorkSale_ArtWork] FOREIGN KEY([ArtWorkId])
REFERENCES [dbo].[ArtWork] ([Id])
GO
ALTER TABLE [dbo].[ArtWorkSale] CHECK CONSTRAINT [FK_ArtWorkSale_ArtWork]
GO
ALTER TABLE [dbo].[ArtWorkSale]  WITH CHECK ADD  CONSTRAINT [FK_ArtWorkSale_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([Id])
GO
ALTER TABLE [dbo].[ArtWorkSale] CHECK CONSTRAINT [FK_ArtWorkSale_Member]
GO
ALTER TABLE [dbo].[GetTicketBack]  WITH CHECK ADD  CONSTRAINT [FK_GetTicketBack_Authority] FOREIGN KEY([AuthorityId])
REFERENCES [dbo].[Authority] ([Id])
GO
ALTER TABLE [dbo].[GetTicketBack] CHECK CONSTRAINT [FK_GetTicketBack_Authority]
GO
ALTER TABLE [dbo].[GetTicketBack]  WITH CHECK ADD  CONSTRAINT [FK_GetTicketBack_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([Id])
GO
ALTER TABLE [dbo].[GetTicketBack] CHECK CONSTRAINT [FK_GetTicketBack_Member]
GO
ALTER TABLE [dbo].[GetTicketBack]  WITH CHECK ADD  CONSTRAINT [FK_GetTicketBack_TicketCategory] FOREIGN KEY([TicketCategoryId])
REFERENCES [dbo].[TicketCategory] ([Id])
GO
ALTER TABLE [dbo].[GetTicketBack] CHECK CONSTRAINT [FK_GetTicketBack_TicketCategory]
GO
ALTER TABLE [dbo].[GetTicketBack]  WITH CHECK ADD  CONSTRAINT [FK_GetTicketBack_TicketSection] FOREIGN KEY([TicketSectionId])
REFERENCES [dbo].[TicketSection] ([Id])
GO
ALTER TABLE [dbo].[GetTicketBack] CHECK CONSTRAINT [FK_GetTicketBack_TicketSection]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Authority] FOREIGN KEY([AuthorityId])
REFERENCES [dbo].[Authority] ([Id])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Authority]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Authority] FOREIGN KEY([AuthorityId])
REFERENCES [dbo].[Authority] ([Id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Authority]
GO
ALTER TABLE [dbo].[TicketSale]  WITH CHECK ADD  CONSTRAINT [FK_TicketSale_Authority] FOREIGN KEY([AuthorityId])
REFERENCES [dbo].[Authority] ([Id])
GO
ALTER TABLE [dbo].[TicketSale] CHECK CONSTRAINT [FK_TicketSale_Authority]
GO
ALTER TABLE [dbo].[TicketSale]  WITH CHECK ADD  CONSTRAINT [FK_TicketSale_TicketCategory] FOREIGN KEY([TicketCategoryId])
REFERENCES [dbo].[TicketCategory] ([Id])
GO
ALTER TABLE [dbo].[TicketSale] CHECK CONSTRAINT [FK_TicketSale_TicketCategory]
GO
ALTER TABLE [dbo].[TicketSale]  WITH CHECK ADD  CONSTRAINT [FK_TicketSale_TicketSection] FOREIGN KEY([TicketSectionId])
REFERENCES [dbo].[TicketSection] ([Id])
GO
ALTER TABLE [dbo].[TicketSale] CHECK CONSTRAINT [FK_TicketSale_TicketSection]
GO
ALTER TABLE [dbo].[TicketStock]  WITH CHECK ADD  CONSTRAINT [FK_TicketStock_TicketCategory] FOREIGN KEY([TicketCategoryId])
REFERENCES [dbo].[TicketCategory] ([Id])
GO
ALTER TABLE [dbo].[TicketStock] CHECK CONSTRAINT [FK_TicketStock_TicketCategory]
GO
/****** Object:  StoredProcedure [dbo].[buyArt]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buyArt]
@artworkcode nvarchar(50),
@artworkId int,
@staffId int,
@name nvarchar(50),
@ımage nvarchar(100),
@date date,
@price int
as
declare @staffstate bit
declare @staffauthorityId int
begin
select @artworkcode=ArtWorkCode from ArtWork where Id=@artworkId
select @staffstate=[State] from Staff where Id=@staffId
select @staffauthorityId=AuthorityId from Staff where Id=@staffId

      if @staffauthorityId=3 and @staffstate=1
	  begin
	        insert into ArtWorkBuy(ArtWorkCode,ArtWorkId,StaffId,[Name],Images,[Date],Price)
			values(@artworkcode,@artworkId,@staffId,@name,@ımage,@date,@price)
      end
end
GO
/****** Object:  StoredProcedure [dbo].[restoreArt]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[restoreArt]
@artworkId int,
@artworkcode nvarchar(50),
@staffId int,
@name nvarchar(50),
@image nvarchar(50),
@date date,
@price int
as
declare @artCode nvarchar(50)
begin
select @artCode=Count(ArtWorkCode) from ArtWorkRestore where ArtWorkCode=@artworkcode
         if @artCode=0
          begin
		      insert into ArtWorkRestore(ArtWorkId,ArtWorkCode,StaffId,[Name],[Image],RestoreDate,Price,[State])
		      values (@artworkId,@artworkcode,@staffId,@name,@image,@date,@price,0)
		      update ArtWork set [State]=0  where ArtWorkCode=@artworkcode
			  print'Restore İşlemi Başarılı'
		  end
		  else
		  begin
		       print'Restorede Aynı Kodlu Eser Bulunmaktadır.'
		  end
end
GO
/****** Object:  StoredProcedure [dbo].[restoreBackArt]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[restoreBackArt]
@artworkcode nvarchar(50),
@staffId int
as
begin         			           
		      update ArtWork set [State]=1  where ArtWorkCode=@artworkcode
			  delete from ArtWorkRestore where ArtWorkCode=@artworkcode
			  print'Eser Restoreden Çıkarılmıştır.'	  
end
GO
/****** Object:  StoredProcedure [dbo].[SaleArt]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  Proc [dbo].[SaleArt]
@artworkcode nvarchar(50),
@staffId int,
@artworkId int,
@memberId int,
@name nvarchar(50),
@date datetime,
@price int
as
declare @MemberState bit
declare @ArtWorkState bit
declare @staffAuthorityId int
begin
	begin try
		begin tran SaleArt			
			select @MemberState=[State] from Member where Id=@memberId
			select @ArtWorkState=[State] from ArtWork where Id=@artworkId
			select @staffAuthorityId=AuthorityId from Staff where Id=@staffId
			select * from ArtWorkSale where MemberId=@memberId and ArtWorkId=@artworkId	and ArtWorkCode=@artworkcode						
			if  @MemberState=1 and @ArtWorkState=1 and @staffAuthorityId=3
			begin				   											
						insert into ArtWorkSale(ArtWorkCode,ArtWorkId,StaffId,MemberId,[Name],GiveDate,Price)
						values (@artworkcode,@artworkId,@staffId,@memberId,@name,@date,@price)
						delete from ArtWork where ArtWorkCode=@artworkcode
						print'Eser Verme Başarılı'						 					
			end			 			
		commit tran SaleArt 
	end try 
	begin catch 
		rollback tran SaleArt 
		print 'Beklenmedik Bir Hata Oluştu.İşlemler Geri ALındı.'
	end catch
end 
GO
/****** Object:  StoredProcedure [dbo].[SaleTicket]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SaleTicket]
@authorityId int,
@staffId int,
@memberId int,
@ticketCategoryId int,
@ticketSectionId int,
@givedate date,
@quantity int,
@price int
as 
declare @staffstate bit
declare @prices int
declare @pricees int
declare @staffAuthorityId int
begin
select @pricees=Price from TicketSection where Id=@ticketSectionId
select @prices=Price from TicketCategory where Id=@ticketCategoryId
select @staffAuthorityId=AuthorityId from Staff where Id=@staffId
select @staffstate=[State] from Staff where Id=@staffId
       if @staffAuthorityId=2 and @staffstate=1 
      begin
            insert into TicketSale(AuthorityId,StaffId,MemberId,TicketCategoryId,TicketSectionId,GiveDate,Quantity,Price)
            values(@authorityId,@staffId,@memberId,@ticketCategoryId,@ticketSectionId,@givedate,@quantity,((@quantity*@prices)+@pricees))
      end
end
GO
/****** Object:  StoredProcedure [dbo].[TicketBack]    Script Date: 11.04.2022 13:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TicketBack]
@staffId int,
@authorityId int,
@memberId int,
@ticketCategoryId int,
@ticketSectionId int,
@backdate date,
@quantity int,
@price int
as
declare @staffstate bit
declare @prices int
declare @pricess int
declare @staffAuthorityId int
begin
select @pricess=Price from TicketSection where Id=@ticketSectionId
select @prices=Price from TicketCategory where Id=@ticketCategoryId
select @staffAuthorityId=AuthorityId from Staff where Id=@staffId
select @staffstate=[State] from Staff where Id=@staffId
      if @staffAuthorityId=2 and @staffstate=1 
     begin
             insert into GetTicketBack(StaffId,AuthorityId,MemberId,TicketCategoryId,TicketSectionId,BackDate,Quantity,Price)
             values(@staffId,@authorityId,@memberId,@ticketCategoryId,@ticketSectionId,@backdate,@quantity,((@quantity*@prices)+(@quantity*@pricess)))
             delete from TicketSale where TicketCategoryId=@ticketCategoryId and TicketSectionId=@ticketSectionId
           print'Bilet Geri Alma İşlemi Başarılı'
      end
end
GO
