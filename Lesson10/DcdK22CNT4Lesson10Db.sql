USE [DcdK22CNT4Lesson10Db]
GO
/****** Object:  Table [dbo].[DcdAccount]    Script Date: 03/07/2024 2:50:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DcdAccount](
	[DcdID] [int] NOT NULL,
	[DcdUserName] [nvarchar](50) NULL,
	[DcdPassword] [nvarchar](50) NULL,
	[DcdFullName] [nvarchar](50) NULL,
	[DcdEmail] [nvarchar](50) NULL,
	[DcdPhone] [nvarchar](50) NULL,
	[DcdActive] [bit] NULL,
 CONSTRAINT [PK_DcdAccount] PRIMARY KEY CLUSTERED 
(
	[DcdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DcdAccount] ([DcdID], [DcdUserName], [DcdPassword], [DcdFullName], [DcdEmail], [DcdPhone], [DcdActive]) VALUES (1, N'Cong Dinh', N'Dinh1234', N'Dinh Cong Dinh', N'Dinhmobile35@gmail.com', N'0399355483', 1)
GO
