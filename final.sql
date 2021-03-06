USE [Stock_Management51]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 1/5/2018 8:07:46 PM ******/
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
/****** Object:  Table [dbo].[StockInfo]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  Table [dbo].[tblCategory]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  Table [dbo].[tblCompany]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  Table [dbo].[tblItem]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  View [dbo].[CategoryCompanyItemInfo]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  View [dbo].[DateSearch]    Script Date: 1/5/2018 8:07:47 PM ******/
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
/****** Object:  View [dbo].[StockWithCompany]    Script Date: 1/5/2018 8:07:47 PM ******/
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
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (26, 11, 5, 5, NULL, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (27, 11, 5, 5, NULL, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (28, 11, 8, 20, NULL, CAST(0xBA3D0B00 AS Date), NULL, NULL)
INSERT [dbo].[StockInfo] ([id], [CompanyId], [ItemId], [StockIn], [Sell], [Date], [Damage], [lost]) VALUES (29, 11, 8, NULL, 50, CAST(0xBA3D0B00 AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[StockInfo] OFF
SET IDENTITY_INSERT [dbo].[tblCategory] ON 

INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (9, N'Computer')
INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (8, N'Electronics')
INSERT [dbo].[tblCategory] ([CategoryID], [CategoryName]) VALUES (10, N'Mobile')
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
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (5, 9, 11, N'Asus 504', 10, 75)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (6, 9, 12, N'IN 320', 10, 0)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (7, 10, 12, N'lenevo Mobile', 5, 66)
INSERT [dbo].[tblItem] ([ItemId], [CategoryId], [CompanyId], [ItemName], [ReorderLavel], [AvailableQuentity]) VALUES (8, 9, 11, N'asus 901', 15, 450)
SET IDENTITY_INSERT [dbo].[tblItem] OFF
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
