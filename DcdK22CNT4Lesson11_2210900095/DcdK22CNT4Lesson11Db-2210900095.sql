USE [DcdK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[DcdCategory]    Script Date: 04/07/2024 10:06:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DcdCategory](
	[DcdID] [int] NOT NULL,
	[DcdCateName] [nvarchar](50) NULL,
	[DcdStatus] [bit] NULL,
 CONSTRAINT [PK_DcdCategory] PRIMARY KEY CLUSTERED 
(
	[DcdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DcdProduct]    Script Date: 04/07/2024 10:06:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DcdProduct](
	[DcdId2210900095] [nvarchar](50) NOT NULL,
	[DcdProName] [nvarchar](50) NULL,
	[DcdQty] [int] NULL,
	[DcdPrice] [float] NULL,
	[DcdCateId] [int] NULL,
	[DcdActive] [bit] NULL,
 CONSTRAINT [PK_DcdProduct] PRIMARY KEY CLUSTERED 
(
	[DcdId2210900095] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DcdCategory] ([DcdID], [DcdCateName], [DcdStatus]) VALUES (1, N'2210900095', 1)
INSERT [dbo].[DcdCategory] ([DcdID], [DcdCateName], [DcdStatus]) VALUES (2, N'iphone', 1)
GO
INSERT [dbo].[DcdProduct] ([DcdId2210900095], [DcdProName], [DcdQty], [DcdPrice], [DcdCateId], [DcdActive]) VALUES (N'2210900095', N'Đinh Công Định', 10, 1000, 1, 1)
INSERT [dbo].[DcdProduct] ([DcdId2210900095], [DcdProName], [DcdQty], [DcdPrice], [DcdCateId], [DcdActive]) VALUES (N'P1000', N'Iphone15prm', 1, 1000, 1, 1)
GO
ALTER TABLE [dbo].[DcdProduct]  WITH CHECK ADD  CONSTRAINT [FK_DcdProduct_DcdCategory] FOREIGN KEY([DcdCateId])
REFERENCES [dbo].[DcdCategory] ([DcdID])
GO
ALTER TABLE [dbo].[DcdProduct] CHECK CONSTRAINT [FK_DcdProduct_DcdCategory]
GO
