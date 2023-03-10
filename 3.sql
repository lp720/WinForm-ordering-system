USE [mydb2]
GO
/****** Object:  Table [dbo].[drinks]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drinks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[餐點] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[供應狀態] [bit] NULL,
	[上架日] [date] NULL,
 CONSTRAINT [PK_drinks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[members]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[members](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[tel] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NULL,
	[email] [nvarchar](50) NOT NULL,
	[birth] [date] NULL,
	[password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_members] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[餐點] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[供應狀態] [bit] NULL,
	[上架日] [date] NOT NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[onemore]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[onemore](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[餐點] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[供應狀態] [bit] NULL,
	[上架日] [date] NULL,
 CONSTRAINT [PK_onemore] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sauce]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sauce](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[餐點] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[供應狀態] [bit] NULL,
	[上架日] [date] NULL,
 CONSTRAINT [PK_sauce] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sidedishes]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sidedishes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[餐點] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[供應狀態] [bit] NULL,
	[上架日] [date] NULL,
 CONSTRAINT [PK_sidedishes()] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffs]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffs](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[tel] [nvarchar](50) NOT NULL,
	[address] [nvarchar](10) NULL,
	[birth] [date] NULL,
	[到職日] [date] NOT NULL,
	[職位] [int] NOT NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[訂單細項]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單細項](
	[產品順序] [int] IDENTITY(1,1) NOT NULL,
	[訂單編號] [int] NOT NULL,
	[主餐] [nvarchar](20) NOT NULL,
	[配餐] [nvarchar](20) NOT NULL,
	[飲料] [nvarchar](20) NOT NULL,
	[加價購] [nvarchar](20) NOT NULL,
	[份數] [int] NOT NULL,
	[單價] [int] NOT NULL,
 CONSTRAINT [PK_訂單細項] PRIMARY KEY CLUSTERED 
(
	[產品順序] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[訂單資料]    Script Date: 2022/11/3 下午 05:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單資料](
	[訂單編號] [int] IDENTITY(1,1) NOT NULL,
	[訂購人id] [int] NOT NULL,
	[訂單時間] [datetime] NOT NULL,
	[訂單總價] [int] NOT NULL,
	[折扣後總價] [int] NULL,
 CONSTRAINT [PK_訂單資料] PRIMARY KEY CLUSTERED 
(
	[訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[drinks] ON 

INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (1, N'不需要', 0, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (2, N'可口可樂', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (3, N'0卡可樂', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (4, N'雪碧', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (5, N'檸檬紅茶', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (6, N'紅茶', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (7, N'綠茶', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[drinks] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (8, N'玉米湯', 55, 1, CAST(N'2022-10-21' AS Date))
SET IDENTITY_INSERT [dbo].[drinks] OFF
GO
SET IDENTITY_INSERT [dbo].[members] ON 

INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (1, N'阿方', N'0927168597', N'高雄市鼓山區', N'ben@gmail.com', CAST(N'1999-05-12' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (2, N'阿堭', N'0985754870', N'嘉義市東區', N'gay@gmail.com', CAST(N'1999-06-30' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (3, N'阿哲', N'0976543210', N'嘉義市西區', N'charge@gmail.com', CAST(N'1999-03-25' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (4, N'阿展', N'0983571678', N'嘉義縣民雄鄉', N'monkey@gmail.com', CAST(N'1998-11-11' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (5, N'阿傑', N'0954321012', N'南投市埔里鄉', N'lee@gmail.com', CAST(N'2000-05-30' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (6, N'阿彥', N'0987954621', N'雲連縣水林村', N'chen@gmail.com', CAST(N'1999-06-01' AS Date), N'123')
INSERT [dbo].[members] ([id], [name], [tel], [address], [email], [birth], [password]) VALUES (7, N'阿吾', N'0985785757', N'嘉義市西區', N'lin@gmail.com', CAST(N'1999-04-04' AS Date), N'123')
SET IDENTITY_INSERT [dbo].[members] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (1, N'嫩煎G腿堡', 80, 1, CAST(N'2022-10-21' AS Date), N'1.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (2, N'蕈菇牛堡', 124, 1, CAST(N'2022-10-21' AS Date), N'2.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (3, N'好大的麥可堡', 75, 1, CAST(N'2022-10-21' AS Date), N'3.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (4, N'吉事雙層牛堡', 65, 1, CAST(N'2022-10-21' AS Date), N'4.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (5, N'香香魚堡', 49, 1, CAST(N'2022-10-21' AS Date), N'5.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (6, N'辣G腿堡', 75, 1, CAST(N'2022-10-21' AS Date), N'6.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (7, N'培根炸G堡', 114, 1, CAST(N'2022-10-21' AS Date), N'7.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (8, N'培根和牛堡', 114, 1, CAST(N'2022-10-21' AS Date), N'8.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (9, N'培根烤G堡', 114, 1, CAST(N'2022-10-21' AS Date), N'9.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (10, N'凱薩沙拉', 104, 1, CAST(N'2022-10-21' AS Date), N'10.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (11, N'麥可雞塊', 64, 1, CAST(N'2022-10-21' AS Date), N'11.png')
INSERT [dbo].[menu] ([id], [餐點], [價格], [供應狀態], [上架日], [pimage]) VALUES (12, N'香炸G腿排', 60, 1, CAST(N'2022-10-21' AS Date), N'12.png')
SET IDENTITY_INSERT [dbo].[menu] OFF
GO
SET IDENTITY_INSERT [dbo].[onemore] ON 

INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (1, N'不需要', 0, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (2, N'洋蔥圈', 59, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (3, N'4塊麥可雞', 49, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (4, N'酥嫩雞翅', 49, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (5, N'蘋果派', 35, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[onemore] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (6, N'金黃地瓜條', 58, 1, CAST(N'2022-10-21' AS Date))
SET IDENTITY_INSERT [dbo].[onemore] OFF
GO
SET IDENTITY_INSERT [dbo].[sauce] ON 

INSERT [dbo].[sauce] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (1, N'醣醋醬', 0, 1, CAST(N'2022-11-03' AS Date))
INSERT [dbo].[sauce] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (2, N'泰式香辣醬', 0, 1, CAST(N'2022-11-03' AS Date))
INSERT [dbo].[sauce] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (3, N'蜂蜜芥末醬', 0, 1, CAST(N'2022-11-03' AS Date))
INSERT [dbo].[sauce] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (4, N'肯瓊醬', 0, 1, CAST(N'2022-11-03' AS Date))
SET IDENTITY_INSERT [dbo].[sauce] OFF
GO
SET IDENTITY_INSERT [dbo].[sidedishes] ON 

INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (1, N'不需要', 0, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (2, N'經典配餐(中薯)', 38, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (3, N'清爽配餐(沙拉)', 55, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (4, N'勁脆配餐(G腿)', 60, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (5, N'炫冰配餐', 85, 1, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[sidedishes] ([id], [餐點], [價格], [供應狀態], [上架日]) VALUES (6, N'豪吃配餐(麥可雞*4+小薯)', 85, 1, CAST(N'2022-10-21' AS Date))
SET IDENTITY_INSERT [dbo].[sidedishes] OFF
GO
INSERT [dbo].[staffs] ([id], [name], [tel], [address], [birth], [到職日], [職位], [email], [password]) VALUES (1, N'阿佑', N'0983788888', N'嘉義縣東區', CAST(N'1998-11-07' AS Date), CAST(N'2020-10-10' AS Date), 1, N'qq@gmail.com', N'123')
INSERT [dbo].[staffs] ([id], [name], [tel], [address], [birth], [到職日], [職位], [email], [password]) VALUES (2, N'阿發', N'0988000000', N'嘉義縣西區', CAST(N'1971-05-05' AS Date), CAST(N'2021-01-01' AS Date), 2, N'cc@gmail.com', N'123')
GO
ALTER TABLE [dbo].[drinks] ADD  CONSTRAINT [DF_drinks_上架時間]  DEFAULT (getdate()) FOR [上架日]
GO
ALTER TABLE [dbo].[menu] ADD  CONSTRAINT [DF_Menu_上架日]  DEFAULT (getdate()) FOR [上架日]
GO
ALTER TABLE [dbo].[onemore] ADD  CONSTRAINT [DF_onemore_上架日]  DEFAULT (getdate()) FOR [上架日]
GO
ALTER TABLE [dbo].[sauce] ADD  CONSTRAINT [DF_sauce_上架日]  DEFAULT (getdate()) FOR [上架日]
GO
ALTER TABLE [dbo].[sidedishes] ADD  CONSTRAINT [DF_sidedishes()_上架日]  DEFAULT (getdate()) FOR [上架日]
GO
ALTER TABLE [dbo].[訂單細項]  WITH CHECK ADD  CONSTRAINT [FK_訂單細項_訂單資料] FOREIGN KEY([訂單編號])
REFERENCES [dbo].[訂單資料] ([訂單編號])
GO
ALTER TABLE [dbo].[訂單細項] CHECK CONSTRAINT [FK_訂單細項_訂單資料]
GO
ALTER TABLE [dbo].[訂單資料]  WITH CHECK ADD  CONSTRAINT [FK_訂單資料_members] FOREIGN KEY([訂購人id])
REFERENCES [dbo].[members] ([id])
GO
ALTER TABLE [dbo].[訂單資料] CHECK CONSTRAINT [FK_訂單資料_members]
GO
