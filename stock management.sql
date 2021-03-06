USE [master]
GO
/****** Object:  Database [Stock_Management51]    Script Date: 1/5/2018 12:29:34 PM ******/
CREATE DATABASE [Stock_Management51]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stock_Management51', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Stock_Management51.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Stock_Management51_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Stock_Management51_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Stock_Management51] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stock_Management51].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stock_Management51] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stock_Management51] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stock_Management51] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stock_Management51] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stock_Management51] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stock_Management51] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Stock_Management51] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Stock_Management51] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stock_Management51] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stock_Management51] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stock_Management51] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stock_Management51] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stock_Management51] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stock_Management51] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stock_Management51] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stock_Management51] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Stock_Management51] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stock_Management51] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stock_Management51] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stock_Management51] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stock_Management51] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stock_Management51] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stock_Management51] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stock_Management51] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stock_Management51] SET  MULTI_USER 
GO
ALTER DATABASE [Stock_Management51] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stock_Management51] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stock_Management51] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stock_Management51] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Stock_Management51]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockInfo]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[StockIn] [int] NULL,
	[Sell] [int] NULL,
	[Date] [date] NOT NULL,
	[Damage] [int] NULL,
	[lost] [int] NULL,
 CONSTRAINT [PK_StockInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
 CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompany]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
 CONSTRAINT [PK_tblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblItem]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblItem](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[ReorderLavel] [int] NOT NULL,
	[AvailableQuentity] [int] NOT NULL,
 CONSTRAINT [PK_tblItem] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[CategoryCompanyItemInfo]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[CategoryCompanyItemInfo]
As
SELECT i.*,c.CompanyID as compId,c.CompanyName,ctg.CategoryID As ctgid,ctg.CategoryName
FROM tblItem i
INNER JOIN tblCompany c    ON i.CompanyId=c.CompanyID
INNER JOIN tblCategory ctg on i.CategoryId=ctg.CategoryID
GO
/****** Object:  View [dbo].[DateSearch]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[DateSearch]
As

SELECT s.id,s.ItemId,s.Sell,s.Date,i.ItemName
FROM StockInfo s
INNER JOIN tblItem i
ON s.ItemId=i.ItemId where s.Sell IS NOT NULL
GO
/****** Object:  View [dbo].[StockWithCompany]    Script Date: 1/5/2018 12:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[StockWithCompany]
As
SELECT i.*,c.CompanyName
FROM tblItem i
INNER JOIN tblCompany c
ON i.CompanyId=c.CompanyID
GO
INSERT [dbo].[Login] ([Id], [UserName], [Password]) VALUES (1, N'admin', N'123456')
INSERT [dbo].[Login] ([Id], [UserName], [Password]) VALUES (2, N'rumman', N'rumman')
SET IDENTITY_INSERT [dbo].[StockInfo] ON 

INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (16, 10, 4, 50, NULL, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (17, 10, 4, 20, NULL, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (18, 11, 5, 60, NULL, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (19, 12, 7, 66, NULL, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (20, 10, 4, NULL, 10, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (21, 10, 4, NULL, 5, CAST(0xB93D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (22, 11, 5, 10, NULL, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (23, 11, 5, NULL, 5, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (24, 11, 8, 500, NULL, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (25, 11, 8, NULL, 20, CAST(0xBA3D0B00 AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[StockInfo] OFF
SET IDENTITY_INSERT [dbo].[tblCategory] ON 

INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (9, N'Computer')
INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (8, N'Electronics')
INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (10, N'Mobile Phone')
SET IDENTITY_INSERT [dbo].[tblCategory] OFF
SET IDENTITY_INSERT [dbo].[tblCompany] ON 

INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName]) VALUES (11, N'Asus')
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName]) VALUES (10, N'Dell')
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName]) VALUES (12, N'lenevo')
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName]) VALUES (1, N'rana')
SET IDENTITY_INSERT [dbo].[tblCompany] OFF
SET IDENTITY_INSERT [dbo].[tblItem] ON 

INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (1, 1, 1, N'N', 20, 0)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (4, 9, 10, N'Dell 504', 10, 55)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (5, 9, 11, N'Asus 504', 10, 65)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (6, 9, 12, N'IN 320', 10, 0)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (7, 10, 12, N'lenevo Mobile', 5, 66)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (8, 9, 11, N'asus 901', 15, 480)
SET IDENTITY_INSERT [dbo].[tblItem] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tblCategory]    Script Date: 1/5/2018 12:29:34 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tblCategory] ON [dbo].[tblCategory]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tblCompany]    Script Date: 1/5/2018 12:29:34 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tblCompany] ON [dbo].[tblCompany]
(
	[CompanyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_tblCompany_1]    Script Date: 1/5/2018 12:29:34 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tblCompany_1] ON [dbo].[tblCompany]
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tblItem]    Script Date: 1/5/2018 12:29:34 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tblItem] ON [dbo].[tblItem]
(
	[ItemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblItem] ADD  CONSTRAINT [DF_tblItem_AvailableQuentity]  DEFAULT ((0)) FOR [AvailableQuentity]
GO
ALTER TABLE [dbo].[StockInfo]  WITH CHECK ADD  CONSTRAINT [FK_StockInfo_StockInfo] FOREIGN KEY([ItemId])
REFERENCES [dbo].[tblItem] ([ItemId])
GO
ALTER TABLE [dbo].[StockInfo] CHECK CONSTRAINT [FK_StockInfo_StockInfo]
GO
ALTER TABLE [dbo].[StockInfo]  WITH CHECK ADD  CONSTRAINT [FK_StockInfo_tblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[tblCompany] ([CompanyID])
GO
ALTER TABLE [dbo].[StockInfo] CHECK CONSTRAINT [FK_StockInfo_tblCompany]
GO
ALTER TABLE [dbo].[tblCategory]  WITH CHECK ADD  CONSTRAINT [FK_tblCategory_tblCategory1] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[tblCategory] CHECK CONSTRAINT [FK_tblCategory_tblCategory1]
GO
ALTER TABLE [dbo].[tblCompany]  WITH CHECK ADD  CONSTRAINT [FK_tblCompany_tblCompany] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[tblCompany] ([CompanyID])
GO
ALTER TABLE [dbo].[tblCompany] CHECK CONSTRAINT [FK_tblCompany_tblCompany]
GO
USE [master]
GO
ALTER DATABASE [Stock_Management51] SET  READ_WRITE 
GO
