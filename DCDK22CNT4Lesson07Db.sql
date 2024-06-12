USE [DcdK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[dcdKhoa]    Script Date: 12/06/2024 3:09:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdKhoa](
	[DcdMaKH] [nchar](10) NOT NULL,
	[DcdTenKH] [nvarchar](50) NULL,
	[DcdTrangThai] [bit] NULL,
 CONSTRAINT [PK_dcdKhoa] PRIMARY KEY CLUSTERED 
(
	[DcdMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dcdSinhVien]    Script Date: 12/06/2024 3:09:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdSinhVien](
	[DcdMaSV] [nvarchar](50) NOT NULL,
	[DcdHoSV] [nvarchar](50) NULL,
	[DcdTenSv] [nvarchar](50) NULL,
	[DcdNgaySinh] [date] NULL,
	[DcdPhai] [bit] NULL,
	[DcdPhone] [nchar](10) NULL,
	[DcdEmail] [nvarchar](50) NULL,
	[DcdMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_dcdSinhVien] PRIMARY KEY CLUSTERED 
(
	[DcdMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dcdKhoa] ([DcdMaKH], [DcdTenKH], [DcdTrangThai]) VALUES (N'K22CNT4   ', N'K22CNT4', 1)
GO
INSERT [dbo].[dcdSinhVien] ([DcdMaSV], [DcdHoSV], [DcdTenSv], [DcdNgaySinh], [DcdPhai], [DcdPhone], [DcdEmail], [DcdMaKH]) VALUES (N'2210900095', N'Đinh Công', N'Định', CAST(N'2004-01-21' AS Date), 1, N'0399355483', N'Dinhmobile35@gmail.com', N'K22CNT4   ')
GO
