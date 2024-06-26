USE [DcdK22CNT4Lesson09Db]
GO
/****** Object:  Table [dbo].[dcdKetQua]    Script Date: 26/06/2024 7:09:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdKetQua](
	[dcdMaSV] [char](10) NOT NULL,
	[dcdMaMH] [char](10) NOT NULL,
	[Diem] [decimal](18, 0) NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[dcdMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dcdKhoa]    Script Date: 26/06/2024 7:09:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdKhoa](
	[DcdMaKH] [char](10) NOT NULL,
	[DcdTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_dcdKhoa_1] PRIMARY KEY CLUSTERED 
(
	[DcdMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dcdMonHoc]    Script Date: 26/06/2024 7:09:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdMonHoc](
	[DcdMaMH] [char](10) NOT NULL,
	[DcdTenMH] [char](10) NULL,
 CONSTRAINT [PK_dcdMonHoc] PRIMARY KEY CLUSTERED 
(
	[DcdMaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dcdSinhVien]    Script Date: 26/06/2024 7:09:19 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dcdSinhVien](
	[DcdMaSV] [char](10) NOT NULL,
	[DcdHoSV] [nvarchar](50) NULL,
	[DcdTenSV] [nvarchar](50) NULL,
	[DcdPhai] [char](10) NULL,
	[DcdNgaySinh] [date] NULL,
	[DcdNoiSinh] [nvarchar](50) NULL,
	[DcdMaKH] [char](10) NULL,
	[DcdHocBong] [char](10) NULL,
	[DcdDiemTrungBinh] [decimal](18, 0) NULL,
 CONSTRAINT [PK_dcdSinhVien_1] PRIMARY KEY CLUSTERED 
(
	[DcdMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[dcdKetQua]  WITH CHECK ADD  CONSTRAINT [FK_dcdKetQua_dcdMonHoc] FOREIGN KEY([dcdMaMH])
REFERENCES [dbo].[dcdMonHoc] ([DcdMaMH])
GO
ALTER TABLE [dbo].[dcdKetQua] CHECK CONSTRAINT [FK_dcdKetQua_dcdMonHoc]
GO
ALTER TABLE [dbo].[dcdSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dcdSinhVien_dcdKetQua] FOREIGN KEY([DcdMaSV])
REFERENCES [dbo].[dcdKetQua] ([dcdMaSV])
GO
ALTER TABLE [dbo].[dcdSinhVien] CHECK CONSTRAINT [FK_dcdSinhVien_dcdKetQua]
GO
ALTER TABLE [dbo].[dcdSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_dcdSinhVien_dcdKhoa] FOREIGN KEY([DcdMaKH])
REFERENCES [dbo].[dcdKhoa] ([DcdMaKH])
GO
ALTER TABLE [dbo].[dcdSinhVien] CHECK CONSTRAINT [FK_dcdSinhVien_dcdKhoa]
GO
