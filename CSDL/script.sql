USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 23/09/2020 10:42:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 23/09/2020 10:42:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[TenDN] [nchar](10) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[MaNV] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDLD]    Script Date: 23/09/2020 10:42:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDLD](
	[MaNV] [nchar](10) NULL,
	[TenHD] [nvarchar](50) NULL,
	[NgayKiHopDong] [date] NULL,
	[NgayKetThucKiHopDong] [date] NULL,
	[MaHD] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 23/09/2020 10:42:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[MaNV] [nchar](10) NULL,
	[LuongCB] [int] NULL,
	[LuongThuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoNgayTangCa] [char](5) NULL,
	[TongLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 23/09/2020 10:42:47 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[BangCap] [nvarchar](50) NULL,
	[GioiTinh] [nchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaPB] [nchar](10) NULL,
	[CMTND] [nchar](20) NULL,
	[SDT] [nchar](11) NULL,
	[DanToc] [nchar](11) NULL,
	[TonGiao] [nchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_CHUCVU]    Script Date: 23/09/2020 10:42:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_CHUCVU](
	[MaCV] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_VITRI]    Script Date: 23/09/2020 10:42:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_VITRI](
	[MaVT] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 23/09/2020 10:42:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [nchar](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaTP] [nchar](10) NULL,
	[TenTP] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VITRICONGVIEC]    Script Date: 23/09/2020 10:42:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VITRICONGVIEC](
	[MaVT] [nchar](10) NOT NULL,
	[TenVT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
