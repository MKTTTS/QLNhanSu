USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 10/15/2020 10:09:23 PM ******/
CREATE DATABASE [QuanLyNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhanSu', N'ON'
GO
USE [QuanLyNhanSu]
GO
/****** Object:  UserDefinedFunction [dbo].[CREATEMANV]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CREATEMANV]()
RETURNS  NCHAR(10)
AS
BEGIN
	DECLARE @result nchar(10)
	
	DECLARE @TEMP INT
		SET @TEMP = (SELECT TOP(1)(CAST(RIGHT(MaNV, 7) AS INT)) FROM NHANVIEN ORDER BY (CAST(RIGHT(MaNV, 7) AS INT)) DESC )
		SET @TEMP = @TEMP + 1
		IF @TEMP < 10
			SET @result = CONCAT('NV', '0000000', CAST(@TEMP as nchar(1)))
		IF @TEMP > 9 and @TEMP < 100
			SET @result = CONCAT('NV', '000000', CAST(@TEMP as nchar(2))) 
		IF @TEMP > 99 and @TEMP < 1000
			SET @result = CONCAT('NV', '00000', CAST(@TEMP as nchar(3))) 
		IF @TEMP > 999 and @TEMP < 10000
			SET @result = CONCAT('NV', '0000', CAST(@TEMP as nchar(4))) 
		IF @TEMP > 9999 and @TEMP < 100000
			SET @result = CONCAT('NV', '000', CAST(@TEMP as nchar(5))) 
		IF @TEMP > 99999 and @TEMP < 1000000
			SET @result = CONCAT('NV', '00', CAST(@TEMP as nchar(6))) 
		IF @TEMP > 999999 and @TEMP < 10000000
			SET @result = CONCAT('NV', '0', CAST(@TEMP as nchar(7))) 
		IF @TEMP > 9999999 and @TEMP < 100000000
			SET @result = CONCAT('NV', CAST(@TEMP as nchar(8))) 

	RETURN @result
END
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 10/15/2020 10:09:23 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[TenDN] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[MaNV] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HDLD]    Script Date: 10/15/2020 10:09:23 PM ******/
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
/****** Object:  Table [dbo].[LUONG]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[MaNV] [nchar](10) NULL,
	[LuongCB] [money] NULL,
	[LuongThuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoNgayTangCa] [int] NULL,
	[TongLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[BangCap] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaPB] [nvarchar](10) NULL,
	[CMTND] [nvarchar](15) NULL,
	[SDT] [nvarchar](15) NULL,
	[DanToc] [nvarchar](11) NULL,
	[TonGiao] [nvarchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN_CHUCVU]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_CHUCVU](
	[MaCV] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN_VITRI]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_VITRI](
	[MaVT] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [nvarchar](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaTP] [nchar](10) NULL,
	[TenTP] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VITRICONGVIEC]    Script Date: 10/15/2020 10:09:23 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000001', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000002', N'Phó giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000003', N'Trưởng phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000004', N'Phó phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000005', N'Nhân viên')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000006', N'Lao công')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000007', N'Chủ tịch')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000024', N'123456', N'NV00000024')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000025', N'123456', N'NV00000025')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV01', N'admin', N'NV00000001')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV03', N'admin', N'NV00000003')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV05', N'admin', N'NV00000005')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV08', N'admin', N'NV00000008')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPKT', N'admin', N'NV00000001')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPMK', N'admin', N'NV00000003')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPTC', N'admin', N'NV00000005')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000001', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-12-05' AS Date), CAST(N'2018-10-30' AS Date), N'NV00000001')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000002', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-11-07' AS Date), CAST(N'2016-11-07' AS Date), N'NV00000002')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000003', N'Hợp Đồng Có Thời Hạn', CAST(N'2012-06-12' AS Date), CAST(N'2018-05-11' AS Date), N'NV00000003')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000024', N'Hợp Đồng Không Thời Hạn', CAST(N'2020-10-15' AS Date), NULL, N'NV00000024')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000005', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-02-14' AS Date), CAST(N'2019-02-14' AS Date), N'NV00000005')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000006', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-03-15' AS Date), CAST(N'2020-03-15' AS Date), N'NV00000006')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000007', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-16' AS Date), CAST(N'2021-04-16' AS Date), N'NV00000007')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000008', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'NV00000008')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000009', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-06-18' AS Date), CAST(N'2023-06-18' AS Date), N'NV00000009')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000010', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-07-19' AS Date), CAST(N'2024-07-19' AS Date), N'NV00000010')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000025', N'Hợp Đồng Không Thời Hạn', CAST(N'2020-10-15' AS Date), NULL, N'NV00000025')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000012', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-09-21' AS Date), CAST(N'2022-09-21' AS Date), N'NV00000012')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000014', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-08-23' AS Date), CAST(N'2027-08-23' AS Date), N'NV00000014')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000015', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-09-24' AS Date), CAST(N'2028-09-24' AS Date), N'NV00000015')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000016', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-04-25' AS Date), CAST(N'2029-04-25' AS Date), N'NV00000016')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000017', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-09-17' AS Date), CAST(N'2030-09-17' AS Date), N'NV00000017')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000018', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-06-18' AS Date), CAST(N'2031-06-18' AS Date), N'NV00000018')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000019', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-03-16' AS Date), CAST(N'2032-03-16' AS Date), N'NV00000019')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000020', N'Hợp Đồng Có Thời Hạn', CAST(N'2016-02-14' AS Date), CAST(N'2033-02-14' AS Date), N'NV00000020')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000021', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-07-13' AS Date), CAST(N'2034-07-13' AS Date), N'NV00000021')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000022', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-09-11' AS Date), CAST(N'2035-09-11' AS Date), N'NV00000022')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000023', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-11-15' AS Date), CAST(N'2030-11-15' AS Date), N'NV00000023')
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000001', 7250000.0000, 300000, N'tháng 10', 4, 7750000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000002', 7000000.0000, 700000, N'', 4, 7900000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000003', 1000000.0000, 1000000, N'thương tháng 5', 1, 2050000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000024', 20000000.0000, 0, NULL, 0, 20000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000005', 15000000.0000, 300000, N'hợp đồng', 5, 15550000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000006', 6000000.0000, 700000, N'', 5, 6950000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000007', 6500000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000008', 8000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000009', 7000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000010', 6000000.0000, 0, N'thánggggggggg', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000025', 7000000.0000, 0, NULL, 0, 7000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000012', 5000000.0000, 5000000, N'scfs', 5, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000014', 6000000.0000, 500000, N'kí hợp đồng mới', 8, 6700000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000015', 7500000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000016', 7000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000017', 9000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000018', 10000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000019', 9000000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000020', 7500000.0000, 0, N'tháng 3', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000021', 6500000.0000, 0, N'', 5, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000022', 5500000.0000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000023', 6500000.0000, 0, N'', 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000001', N'Nguyễn Hữu Chính', N'Thạc sỹ', N'Nam', CAST(N'1994-09-07' AS Date), N'Bắc Giang', N'MK', N'463643564575', N'097854629', N'tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000002', N'Nguyễn Minh Tú', N'Thạc sỹ', N'Nam', CAST(N'1994-09-10' AS Date), N'Hà Nội', N'TC-KT', N'13123214599', N'098765324', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000003', N'Lê Trường Sơn', N'Tiến Sỹ', N'Nam', CAST(N'1993-05-07' AS Date), N'Yên Bái', N'MK', N'12334345465', N'098654353', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000005', N'Phạm Hải Nam', N'', N'Nam', CAST(N'1994-09-07' AS Date), N'Quảng Ninh', N'KT-KT', N'45765857343', N'098643688', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000006', N'Nguyễn Minh Anh', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'TC-KT', N'45653647547', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000007', N'Nguyễn Ba Huy', N'Đại Học', N'Nam', CAST(N'1995-10-10' AS Date), N'Hà Nội', N'TC-KT', N'533532543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000008', N'Phạm Thị Hương', N'Tiến Sỹ', N'Nữ', CAST(N'1993-05-08' AS Date), N'Yên Bái', N'BDH', N'436362', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000009', N'Nguyễn Mạnh Sơn', N'Đại Học', N'Nam', CAST(N'1996-09-07' AS Date), N'Bắc Giang', N'NV', N'5345235', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000010', N'Lê Hoàng Long', N'', N'Nam', CAST(N'1991-09-07' AS Date), N'Quảng Nam', N'KT-KT', N'35324534543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000012', N'Nguyễn Phúc Vân Anh', N'Đại Học', N'Nữ', CAST(N'1994-10-07' AS Date), N'Hà Giang', N'TC-KT', N'353535345', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000014', N'Nguyễn Vũ Anh Dương', N'Đại Học', N'Nam', CAST(N'1994-09-10' AS Date), N'Bình Định', N'NV', N'5435243532', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000015', N'Trần Thanh Hòa', N'Tiến sỹ', N'Nữ', CAST(N'1994-08-12' AS Date), N'THái Bình', N'BDH', N'54235243636', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000016', N'Nguyễn Chấn Huy', N'Tiến sỹ', N'Nam', CAST(N'1993-06-07' AS Date), N'Nghệ An', N'BDH', N'2353252345', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000017', N'Nguyễn Lê Đình Huy', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Hà Tĩnh', N'TC-KT', N'353454325', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000018', N'Mai Quốc Hùng', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Thanh Hóa', N'TC-KT', N'5235255235', N'016765484 ', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000019', N'Nguyễn Thịnh Lâm Khang', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Vĩnh Phúc', N'NV', N'55352235456', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000020', N'Bùi Nguyên Khánh', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'KT-KT', N'353425355435', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000021', N'Lâm Chí Kiệt', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Hải Phòng', N'KT-KT', N'45324535345', N'016765484', N'Tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000022', N'Trần Phạm Hoàng Long', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Nam Định', N'NV', N'5325335235', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000023', N'Đoàn Điểm My', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Hà Nội', N'NV', N'532453245243', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000024', N'Đinh Xuân Tùng', N'Thạc sỹ', N'Nam', CAST(N'1998-06-16' AS Date), N'Sơn Tây, Hà Nội', N'KT-KT', N'035046000142', N'0973380598', N'Kinh', N'Không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000025', N'Ngô Nhật Minh', N'', N'Nam', CAST(N'1999-11-11' AS Date), N'Nghi Sơn, Thanh Hóa', N'MK', N'753425420', N'4342423423423', N'Kinh', N'')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000024')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000006')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000019')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000009')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000007', N'NV00000008')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000014')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000017')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000018')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000001', N'NV00000016')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000005')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000010')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000023')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000022')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000025')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000020')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000001')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000002', N'NV00000015')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000007')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000003')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000002')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000009')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000012')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000014')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000017')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000018')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000019')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000016')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000024')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000023')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000022')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000020')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000001', N'NV00000001')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000015')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000007')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000007', N'NV00000003')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000002')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000006')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'BDH', N'Ban điều hành', N'Hà Nội', N'NV00000008', N'Phạm Thị Hương')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'KT-KT', N'Kinh Tế - Kỹ Thuật', N'Quảng Nam', N'NV00000021', N'Lâm Chí Kiệt')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'MK', N'MarKeting', N'Hòa Bình', N'NV00000003', N'Lê Trường Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'NV', N'Nội Vụ', N'Hà Nội', N'NV00000009', N'Nguyễn Mạnh Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'TC-KT', N'Tài Chính - Kế Toán', N'Yên Bái', N'NV00000002', N'Nguyễn Minh Tú')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000001', N'Thư Ký ')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000002', N'Kế Toán')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000003', N'Nhân viên Kỹ Thuật')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000004', N'Quản Lý Hồ Sơ - Thiết Bị')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000005', N'Marketting')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000006', N'Hành Chính - Nhân Sự')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000007', N'Lễ Tân')
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HDLD]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHONGBAN] ([MaPB])
GO
ALTER TABLE [dbo].[NHANVIEN_CHUCVU]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN_CHUCVU]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN_VITRI]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN_VITRI]  WITH CHECK ADD FOREIGN KEY([MaVT])
REFERENCES [dbo].[VITRICONGVIEC] ([MaVT])
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_NHANVIEN] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[CHECKCMND]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CHECKCMND] @cmnd nvarchar(15)
AS
BEGIN
SELECT
CASE
WHEN EXISTS(SELECT * FRom NHANVIEN WHERE NHANVIEN.CMTND = @cmnd) THEN 1
WHEN NOT EXISTS(SELECT * FRom NHANVIEN WHERE NHANVIEN.CMTND = @cmnd) THEN 0
END AS TonTai
END
GO
/****** Object:  StoredProcedure [dbo].[DELETENHANVIEN]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETENHANVIEN]
@manhanvien nchar(10)
AS
BEGIN
DELETE FROM HDLD WHERE HDLD.MaNV = @manhanvien
DELETE FROM NHANVIEN_CHUCVU WHERE NHANVIEN_CHUCVU.MaNV = @manhanvien
DELETE FROM NHANVIEN_VITRI WHERE NHANVIEN_VITRI.MaNV = @manhanvien
DELETE FROM LUONG WHERE LUONG.MaNV = @manhanvien
DELETE FROM DANGNHAP WHERE DANGNHAP.MaNV = @manhanvien

DECLARE @maphongban nvarchar(10)
SET @maphongban = (SELECT MaPB FROM PHONGBAN WHERE MaTP = @manhanvien)
UPDATE PHONGBAN SET MaTP = null, TenTP = null WHERE MaPB = @maphongban
DELETE FROM NHANVIEN WHERE NHANVIEN.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[MANVMAX]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MANVMAX]
AS
BEGIN
	SELECT TOP(1)(CAST(RIGHT(MaNV, 7) AS INT)) as MaLonNhat FROM NHANVIEN ORDER BY (CAST(RIGHT(MaNV, 7) AS INT)) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNhanVien]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC  [dbo].[SelectAllNhanVien]
@tukhoa nvarchar (30)
AS
BEGIN

		SELECT MaNV as N'Mã nhân viên', 
		HoTen as N'Họ tên', 
		GioiTinh as N'Giới tính', 
		CONVERT(VARCHAR(10),NgaySinh, 103) as N'Ngày sinh',
		DiaChi as N'Địa chỉ',
		SDT as N'Số điện thoại'
		FROM NHANVIEN WHERE MaNV like '%'+@tukhoa + '%' OR lower(HoTen) like '%'+lower(@tukhoa) + '%' OR SDT like '%'+@tukhoa + '%'
	
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTHOPDONG]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTHOPDONG]
@manhanvien nchar(10)
AS
BEGIN
SELECT  NHANVIEN.MaNV, 
		NHANVIEN.HoTen, 
		NHANVIEN.GioiTinh,
		CONVERT(VARCHAR(10),NgaySinh, 103) as NgaySinh,
		CONVERT(VARCHAR(10),HDLD.NgayKiHopDong, 103) as NgayKi,
		CONVERT(VARCHAR(10),HDLD.NgayKetThucKiHopDong, 103) as NgayHetHan,
		TenHD
FROM NHANVIEN, HDLD WHERE NHANVIEN.MaNV = HDLD.MaNV and NHANVIEN.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTNhanVien]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTNhanVien]
	@manhanvien char(20)
AS
BEGIN
	SELECT 
		HoTen,
		CONVERT(VARCHAR(10),NgaySinh, 103) as NgaySinh,
		GioiTinh,
		NHANVIEN.DiaChi,
		SDT,
		CMTND,
		BangCap,
		DanToc,
		TonGiao,
		CHUCVU.TenCV,
		PHONGBAN.TenPB,
		VITRICONGVIEC.TenVT
	FROM (((NHANVIEN LEFT JOIN (NHANVIEN_VITRI INNER JOIN VITRICONGVIEC ON NHANVIEN_VITRI.MaVT = VITRICONGVIEC.MaVT) ON NHANVIEN.MaNV = NHANVIEN_VITRI.MaNV)
		LEFT JOIN (NHANVIEN_CHUCVU INNER JOIN CHUCVU ON NHANVIEN_CHUCVU.MaCV = CHUCVU.MaCV) ON NHANVIEN.MaNV = NHANVIEN_CHUCVU.MaNV) 
		LEFT JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB) WHERE NHANVIEN.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[THEMMOINHANVIEN]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMMOINHANVIEN]
@manhanvien nchar(10),
@gioitinh nvarchar(3),
@hoten nvarchar(50),
@ngaysinh date,
@diachi nvarchar(200),
@sdt nvarchar(15),
@cmnd nvarchar(15),
@dantoc nvarchar(11),
@tongiao nvarchar(11),
@bangcap nvarchar(50),
@hopdong nvarchar(50),
@ngayky date,
@ngayhethan date,
@phongban nvarchar(50),
@chucvu nvarchar(50),
@vitri nvarchar(50),
@luong money
AS
BEGIN
	DECLARE @maphongban nvarchar(10)
	SET @maphongban = (SELECT MaPB FROM PHONGBAN WHERE PHONGBAN.TenPB = @phongban)
	INSERT INTO NHANVIEN(MaNV, HoTen, BangCap, GioiTinh, NgaySinh, DiaChi, MaPB, CMTND, SDT, DanToc, TonGiao)
	VALUES (@manhanvien, @hoten, @bangcap, @gioitinh, @ngaysinh, @diachi, @maphongban, @cmnd, @sdt, @dantoc, @tongiao)
	if(@chucvu != N'Không')
	BEGIN
		DECLARE @maCV nchar(10)
		SET @maCV = (SELECT MaCV FROM CHUCVU WHERE TenCV = @chucvu)
		INSERT INTO NHANVIEN_CHUCVU(MaCV, MaNV) VALUES (@maCV, @manhanvien)
	END
	if (@vitri != '')
	BEGIN
		DECLARE @maVT nchar(10)
		SET @maVT = (SELECT MaVT FROM VITRICONGVIEC WHERE TenVT = @vitri)
		INSERT INTO NHANVIEN_VITRI(MaVT, MaNV) VALUES (@maVT, @manhanvien)
	END
	INSERT INTO LUONG(MaNV, LuongCB, LuongThuong, GhiChu, SoNgayTangCa, TongLuong) VALUES (@manhanvien, @luong, 0, null, 0, @luong)
	INSERT INTO HDLD(MaNV, TenHD, NgayKiHopDong, NgayKetThucKiHopDong, MaHD) 
	VALUES (@manhanvien, 
			CASE @hopdong
			WHEN N'Có thời hạn' THEN N'Hợp Đồng Có Thời Hạn'
			WHEN N'Không thời hạn' THEN N'Hợp Đồng Không Thời Hạn'
			END,
			@ngayky,
			CASE @hopdong
			WHEN N'Có thời hạn' THEN @ngayhethan
			WHEN N'Không thời hạn' THEN null
			END,
			@manhanvien)
	INSERT INTO DANGNHAP(TenDN, MatKhau, MaNV) VALUES (@manhanvien, '123456', @manhanvien)
			 
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATEHOPDONG]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEHOPDONG] 
@manhanvien nchar(10),
@tenhopdong nvarchar(50),
@ngayhethan date
AS
BEGIN
	IF (@tenhopdong = N'Có thời hạn')
	BEGIN
		UPDATE HDLD
		SET TenHD = N'Hợp Đồng Có Thời Hạn', NgayKetThucKiHopDong = @ngayhethan WHERE MaNV = @manhanvien
	END
	ELSE
	BEGIN
		UPDATE HDLD
		SET TenHD = N'Hợp Đồng Không Thời Hạn', NgayKetThucKiHopDong = null WHERE MaNV = @manhanvien
	END
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATENHANVIEN]    Script Date: 10/15/2020 10:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATENHANVIEN]
@Manhanvien nchar(10),
@Gioitinh nvarchar(3),
@Hoten nvarchar(50),
@ngaysinh date,
@diachi nvarchar(200),
@sodienthoai nvarchar(15),
@chucvu nvarchar(50),
@bangcap nvarchar(50),
@phongban nvarchar(50),
@vitricongviec nvarchar(50)

AS
BEGIN
	DECLARE @chucvucu nvarchar(50)
	
	SET @chucvucu = (SELECT TenCV FROM NHANVIEN INNER JOIN (NHANVIEN_CHUCVU INNER JOIN CHUCVU ON NHANVIEN_CHUCVU.MaCV = CHUCVU.MaCV) ON NHANVIEN.MaNV = NHANVIEN_CHUCVU.MaNV and NHANVIEN.MaNV = @Manhanvien)
	IF LEN(@chucvucu) =  0
	BEGIN
		SET @chucvucu = N'Không'
	END
		SELECT @chucvucu
	DECLARE @Maphongban nvarchar(10)
	SET @Maphongban = (SELECT MaPB FROM PHONGBAN WHERE TenPB = @phongban)
	UPDATE NHANVIEN
	SET GioiTinh = @Gioitinh,
		HoTen = @Hoten,
		NgaySinh = @ngaysinh,
		DiaChi = @diachi,
		SDT = @sodienthoai,
		BangCap = @bangcap,
		MaPB = @Maphongban
	WHERE NHANVIEN.MaNV = @Manhanvien

	IF(@chucvu <> @chucvucu )
	BEGIN
		IF(@chucvucu = N'Trưởng phòng')
		BEGIN
			IF(@chucvu = N'Không')
				BEGIN
					DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
				END
			ELSE
				BEGIN
					DECLARE @Machucvu nchar(10)
					SET @Machucvu = (SELECT CHUCVU.MaCV FROM CHUCVU WHERE TenCV = @chucvu)
					DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
					INSERT INTO NHANVIEN_CHUCVU (MaCV, MaNV) VALUES (@Machucvu, @Manhanvien)
				END
			DECLARE @MPB nvarchar(10)
			SET @MPB = (SELECT MaPB FROM PHONGBAN WHERE PHONGBAN.MaTP = @Manhanvien)
			UPDATE PHONGBAN SET MaTP = null, TenTP = null WHERE MaPB = @MPB
		END
		ELSE IF (@chucvu = N'Trưởng phòng')
		BEGIN
			
			DECLARE @MaTP nchar(10)
			SET @MaTP = (SELECT MaTP FROM PHONGBAN WHERE PHONGBAN.MaPB = @Maphongban)
			IF (NOT EXISTS(SELECT * FROM PHONGBAN WHERE PHONGBAN.MaPB = @Maphongban and PHONGBAN.MaTP != null))
				BEGIN
					UPDATE PHONGBAN SET MaTP = @Manhanvien, TenTP = @Hoten WHERE MaPB = @Maphongban
					DECLARE @Machucvu1 nchar(10)
					SET @Machucvu1 = (SELECT CHUCVU.MaCV FROM CHUCVU WHERE TenCV = @chucvu)
					DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
					INSERT INTO NHANVIEN_CHUCVU (MaCV, MaNV) VALUES (@Machucvu1, @Manhanvien)
				END
		END
		ELSE 
		BEGIN
			IF(@chucvu = N'Không')
				BEGIN
					DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
				END
			ELSE
				BEGIN
					DECLARE @Machucvu2 nchar(10)
					SET @Machucvu2 = (SELECT CHUCVU.MaCV FROM CHUCVU WHERE TenCV = @chucvu)
					DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
					INSERT INTO NHANVIEN_CHUCVU (MaCV, MaNV) VALUES (@Machucvu2, @Manhanvien)
				END
		END
	END
	IF @vitricongviec = N'Không'
	BEGIN
		DELETE FROM NHANVIEN_VITRI WHERE MaNV = @Manhanvien
	END
	ELSE
	BEGIN
	DECLARE @Mavitri nchar(10)
	SET @Mavitri = (SELECT MaVT FROM VITRICONGVIEC WHERE TenVT = @vitricongviec)
	DELETE FROM NHANVIEN_VITRI WHERE MaNV = @Manhanvien
	INSERT INTO NHANVIEN_VITRI (MaVT, MaNV) VALUES (@Mavitri, @Manhanvien)
	END
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
