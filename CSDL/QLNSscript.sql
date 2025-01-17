USE [QuanLyNhanSu]
GO
/****** Object:  UserDefinedFunction [dbo].[CREATEMANV]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[HDLD]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[LUONG]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[NHANVIEN_CHUCVU]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_CHUCVU](
	[MaCV] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN_VITRI]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_VITRI](
	[MaVT] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  Table [dbo].[VITRICONGVIEC]    Script Date: 10/22/2020 3:54:38 PM ******/
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
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000001', N'123456789', N'NV00000001')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000002', N'123456', N'NV00000002')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000003', N'123456', N'NV00000003')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000005', N'123456', N'NV00000005')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000006', N'123456', N'NV00000006')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000007', N'123456', N'NV00000007')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000008', N'123456', N'NV00000008')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000009', N'123456', N'NV00000009')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000010', N'123456', N'NV00000010')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000012', N'123456', N'NV00000012')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000014', N'123456', N'NV00000014')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000015', N'123456', N'NV00000015')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000016', N'123456', N'NV00000016')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000017', N'123456', N'NV00000017')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000018', N'123456', N'NV00000018')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000019', N'123456', N'NV00000019')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000020', N'123456', N'NV00000020')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000021', N'123456', N'NV00000021')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000022', N'123456', N'NV00000022')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000023', N'123456', N'NV00000023')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000024', N'123456', N'NV00000024')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000025', N'123456', N'NV00000025')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000026', N'123456', N'NV00000026')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV00000027', N'123456', N'NV00000027')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000001', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-12-05' AS Date), CAST(N'2021-10-30' AS Date), N'NV00000001')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000002', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-11-07' AS Date), CAST(N'2022-11-07' AS Date), N'NV00000002')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000003', N'Hợp Đồng Có Thời Hạn', CAST(N'2012-06-12' AS Date), CAST(N'2018-05-11' AS Date), N'NV00000003')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000024', N'Hợp Đồng Không Thời Hạn', CAST(N'2020-10-15' AS Date), NULL, N'NV00000024')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000005', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-02-14' AS Date), CAST(N'2019-02-14' AS Date), N'NV00000005')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000006', N'Hợp Đồng Không Thời Hạn', CAST(N'2014-03-15' AS Date), NULL, N'NV00000006')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000007', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-16' AS Date), CAST(N'2021-04-16' AS Date), N'NV00000007')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000008', N'Hợp Đồng Không Thời Hạn', CAST(N'2019-05-17' AS Date), NULL, N'NV00000008')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000009', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-06-18' AS Date), CAST(N'2023-06-18' AS Date), N'NV00000009')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000010', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-07-19' AS Date), CAST(N'2024-07-19' AS Date), N'NV00000010')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000025', N'Hợp Đồng Không Thời Hạn', CAST(N'2020-10-15' AS Date), NULL, N'NV00000025')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000012', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-09-21' AS Date), CAST(N'2022-09-21' AS Date), N'NV00000012')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000026', N'Hợp Đồng Không Thời Hạn', CAST(N'2020-10-19' AS Date), NULL, N'NV00000026')
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
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000027', N'Hợp Đồng Có Thời Hạn', CAST(N'2020-10-20' AS Date), CAST(N'2026-12-12' AS Date), N'NV00000027')
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000001', 7250000.0000, 0, NULL, 0, 7250000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000002', 7000000.0000, 0, NULL, 0, 7000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000003', 1000000.0000, 0, NULL, 0, 1000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000024', 9000000.0000, 0, NULL, 0, 9000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000005', 15000000.0000, 0, NULL, 0, 15000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000006', 6000000.0000, 0, NULL, 0, 6000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000007', 6500000.0000, 0, NULL, 0, 6500000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000008', 80000000.0000, 0, NULL, 0, 80000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000009', 7000000.0000, 0, N'Đi muộn -1 ngày làm thêm
Chửi bậy -5 ngày làm thê', -6, 6700000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000010', 6000000.0000, 0, NULL, 0, 6000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000025', 7000000.0000, 0, NULL, 0, 7000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000012', 5000000.0000, 0, NULL, 0, 5000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000026', 3000000.0000, 0, NULL, 0, 3000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000014', 6000000.0000, 0, NULL, 0, 6000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000015', 25000000.0000, 0, NULL, 0, 25000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000016', 30000000.0000, 0, NULL, 0, 30000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000017', 9000000.0000, 0, NULL, 0, 9000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000018', 10000000.0000, 0, NULL, 0, 10000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000019', 9000000.0000, 0, NULL, 0, 9000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000020', 7500000.0000, 0, NULL, 0, 7500000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000021', 15000000.0000, 0, NULL, 0, 15000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000022', 5500000.0000, 0, NULL, 0, 5500000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000023', 6500000.0000, 0, NULL, 0, 6500000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000027', 5000000.0000, 0, N'', 5, 5250000)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000001', N'Nguyễn Hữu Chính', N'Thạc sỹ', N'Nam', CAST(N'1994-09-07' AS Date), N'Bắc Giang', N'MK', N'463643564572', N'097854629', N'tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000002', N'Nguyễn Minh Tú', N'Thạc sỹ', N'Nam', CAST(N'1994-09-10' AS Date), N'Hà Nội', N'TC-KT', N'13123214599', N'098765324', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000003', N'Lê Trường Sơn', N'Tiến Sỹ', N'Nam', CAST(N'1993-05-07' AS Date), N'Yên Bái', N'MK', N'12334345465', N'098654353', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000005', N'Phạm Hải Nam', N'', N'Nam', CAST(N'1994-09-07' AS Date), N'Quảng Ninh', N'KT-KT', N'45765857343', N'098643688', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000006', N'Nguyễn Minh Anh', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'TC-KT', N'45653647547', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000007', N'Nguyễn Ba Huy', N'Đại Học', N'Nam', CAST(N'1995-10-10' AS Date), N'Hà Nội', N'TC-KT', N'533532543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000008', N'Phạm Thị Hương', N'Tiến Sỹ', N'Nữ', CAST(N'1993-05-08' AS Date), N'Yên Bái', N'BDH', N'273865344111', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000009', N'Nguyễn Mạnh Sơn', N'Đại Học', N'Nam', CAST(N'1996-09-07' AS Date), N'Bắc Giang', N'NV', N'5345235', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000010', N'Lê Hoàng Long', N'', N'Nam', CAST(N'1991-09-07' AS Date), N'Quảng Nam', N'KT-KT', N'35324534543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000012', N'Nguyễn Phúc Vân Anh', N'Đại Học', N'Nữ', CAST(N'1994-10-07' AS Date), N'Hà Giang', N'TC-KT', N'353535345', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000014', N'Nguyễn Vũ Anh Dương', N'Đại Học', N'Nam', CAST(N'1994-09-10' AS Date), N'Bình Định', N'NV', N'5435243532', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000015', N'Trần Thanh Hòa', N'Tiến sỹ', N'Nữ', CAST(N'1994-08-12' AS Date), N'THái Bình', N'BDH', N'54235243636', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000016', N'Nguyễn Chấn Huy', N'Tiến sỹ', N'Nam', CAST(N'1993-06-07' AS Date), N'Nghệ An', N'BDH', N'235325234', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000017', N'Nguyễn Lê Đình Huy', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Hà Tĩnh', N'TC-KT', N'353454325', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000018', N'Mai Quốc Hùng', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Thanh Hóa', N'TC-KT', N'5235255235', N'016765484 ', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000019', N'Nguyễn Thịnh Lâm Khang', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Vĩnh Phúc', N'NV', N'55352235456', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000020', N'Bùi Nguyên Khánh', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'KT-KT', N'353425355435', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000021', N'Lâm Chí Kiệt', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Hải Phòng', N'KT-KT', N'45324535345', N'016765484', N'Tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000022', N'Trần Phạm Hoàng Long', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Nam Định', N'NV', N'5325335235', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000023', N'Đoàn Điểm My', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Hà Nội', N'MK', N'532453245243', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000024', N'Đinh Xuân Tùng', N'Thạc sỹ', N'Nam', CAST(N'1998-06-16' AS Date), N'Sơn Tây, Hà Nội', N'KT-KT', N'035046000142', N'0973380598', N'Kinh', N'Không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000025', N'Ngô Nhật Minh', N'Đại học', N'Nam', CAST(N'1999-11-11' AS Date), N'Nghi Sơn, Thanh Hóa', N'SC', N'753425420', N'4342423423423', N'Kinh', N'')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000026', N'Đặng Trọng Tiến', N'', N'Nam', CAST(N'2004-11-11' AS Date), N'Vương quốc Yên Thành', N'SC', N'986435674', N'4234234234', N'Ơ đu', N'Hồi giáo')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000027', N'Nguyễn Vĩnh Hiền', N'', N'Nam', CAST(N'1999-08-12' AS Date), N'Krông Pắk, Đắk Lắk', N'BDH', N'345340976542', N'1214421424', N'Ê đê', N'')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000024')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000006')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000009')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000026')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000027')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000019')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000007', N'NV00000008')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000017')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000001', N'NV00000016')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000005')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000010')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000023')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000022')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000020')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000001')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000002', N'NV00000015')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000007')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000003')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000002')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000018')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000014')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000025')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000002')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000009', N'NV00000027')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000018')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000023')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000017')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000019')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000016')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000024')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000022')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000020')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000001', N'NV00000001')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000015')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000007')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000007', N'NV00000003')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000006')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000025')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000014')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000012')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000009')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'BDH', N'Ban điều hành', N'Hà Nội', N'NV00000008', N'Phạm Thị Hương')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'KT-KT', N'Kinh Tế - Kỹ Thuật', N'Quảng Nam', N'NV00000021', N'Lâm Chí Kiệt')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'MK', N'MarKeting', N'Hòa Bình', N'NV00000003', N'Lê Trường Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'NV', N'Nội Vụ', N'Hà Nội', N'NV00000009', N'Nguyễn Mạnh Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'SC', N'Security', N'unknown', N'NV00000025', N'Ngô Nhật Minh')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'TC-KT', N'Tài Chính - Kế Toán', N'Yên Bái', N'NV00000018', N'Mai Quốc Hùng')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000001', N'Thư Ký ')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000002', N'Kế Toán')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000003', N'Nhân viên Kỹ Thuật')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000004', N'Quản Lý Hồ Sơ - Thiết Bị')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000005', N'Marketting')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000006', N'Hành Chính - Nhân Sự')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000007', N'Lễ Tân')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000008', N'Spies')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000009', N'Sercurity')
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
/****** Object:  StoredProcedure [dbo].[BANGLUONGTHEOPHONG]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BANGLUONGTHEOPHONG] (@tenphongban nvarchar(50))
AS
BEGIN
	SELECT NHANVIEN.MaNV as N'Mã nhân viên', NHANVIEN.HoTen as N'Họ tên nhân viên', CHUCVU.TenCV as N'Chức vụ' FROM 
	(NHANVIEN LEFT JOIN (NHANVIEN_CHUCVU INNER JOIN CHUCVU ON NHANVIEN_CHUCVU.MaCV = CHUCVU.MaCV) ON NHANVIEN.MaNV = NHANVIEN_CHUCVU.MaNV)
	INNER JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB
	WHERE PHONGBAN.TenPB = @tenphongban
END
GO
/****** Object:  StoredProcedure [dbo].[CHECKCMND]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[CHECKHOPDONG]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CHECKHOPDONG] (@manhanvien nchar(10))
AS
BEGIN
	DECLARE @ngayhethan date
	SET @ngayhethan = (SELECT HDLD.NgayKetThucKiHopDong FROM HDLD WHERE MaNV = @manhanvien)
	IF @ngayhethan is null
	BEGIN
		SELECT 1 as TrangThai
	END
	ELSE
	BEGIN
		SELECT CASE
		WHEN DATEDIFF(Day, getdate(), @ngayhethan) < 0 THEN 0
		WHEN DATEDIFF(Day, getdate(), @ngayhethan) >= 0 THEN 1
		END
		AS TrangThai
	END
END
GO
/****** Object:  StoredProcedure [dbo].[DELETENHANVIEN]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LEVELDANGNHAP]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LEVELDANGNHAP] (@manhanvien nchar(10))
AS
BEGIN
	DECLARE @flag nchar(10)
	DECLARE @level int
	SET @flag = (SELECT MaCV FROM (NHANVIEN LEFT JOIN NHANVIEN_CHUCVU ON NHANVIEN.MaNV = NHANVIEN_CHUCVU.MaNV) WHERE NHANVIEN.MaNV = @manhanvien)
	IF @flag = 'CV00000007'
	BEGIN
		SET @level = 1
	END
	ELSE IF @flag = 'CV00000001'
	BEGIN
		SET @level = 2
	END
	ELSE IF @flag = 'CV00000002' 
	BEGIN
		SET @level = 3
	END
	ELSE IF @flag = 'CV00000003' 
	BEGIN
		SET @level = 4
	END
	ELSE IF @flag = 'CV00000004' 
	BEGIN
		SET @level = 5
	END
	ELSE
	BEGIN
		SET @level = 6
	END
	SELECT @level as 'Level'
END
GO
/****** Object:  StoredProcedure [dbo].[Load]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Load]
AS 
BEGIN
	SELECT MaPB as N'Mã phòng ban', TenPB as N'Tên phòng ban', DiaChi as N'Địa chỉ phòng ban', MaTP as N'Mã trưởng phòng', TenTP as N'Tên trưởng phòng' FROM dbo.PHONGBAN 
END
GO
/****** Object:  StoredProcedure [dbo].[MACVMAX]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MACVMAX]
AS
BEGIN
	SELECT TOP(1)(CAST(RIGHT(MaCV, 7) AS INT)) as MaLonNhat FROM CHUCVU ORDER BY (CAST(RIGHT(MaCV, 7) AS INT)) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[MANVMAX]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[REFRESH]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[REFRESH]
AS 
BEGIN
	UPDATE LUONG SET LuongThuong = 0, SoNgayTangCa = 0, TongLuong = LuongCB, GhiChu = null
END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNhanVien]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[SelectAllNhanVien]
@tukhoa nvarchar (30)
AS
BEGIN

		SELECT NHANVIEN.MaNV as N'Mã nhân viên', 
		HoTen as N'Họ tên', 
		GioiTinh as N'Giới tính', 
		CONVERT(VARCHAR(10),NgaySinh, 103) as N'Ngày sinh',
		DiaChi as N'Địa chỉ',
		SDT as N'Số điện thoại'
		FROM NHANVIEN, HDLD WHERE NHANVIEN.MaNV = HDLD.MaNV
		and (NHANVIEN.MaNV like '%'+@tukhoa + '%' OR lower(HoTen) like '%'+lower(@tukhoa) + '%' OR SDT like '%'+@tukhoa + '%' )
		and (DATEDIFF(Day, getdate(), HDLD.NgayKetThucKiHopDong) >= 0 or HDLD.NgayKetThucKiHopDong is null) 
	
END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNhanVienHetHan]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[SelectAllNhanVienHetHan]
@tukhoa nvarchar (30)
AS
BEGIN

		SELECT NHANVIEN.MaNV as N'Mã nhân viên', 
		HoTen as N'Họ tên', 
		GioiTinh as N'Giới tính', 
		CONVERT(VARCHAR(10),NgaySinh, 103) as N'Ngày sinh',
		DiaChi as N'Địa chỉ',
		SDT as N'Số điện thoại'
		FROM NHANVIEN, HDLD WHERE NHANVIEN.MaNV = HDLD.MaNV
		and (NHANVIEN.MaNV like '%'+@tukhoa + '%' OR lower(HoTen) like '%'+lower(@tukhoa) + '%' OR SDT like '%'+@tukhoa + '%' )
		and (DATEDIFF(Day, getdate(), HDLD.NgayKetThucKiHopDong) < 0 and HDLD.NgayKetThucKiHopDong is not null) 
	
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTHOPDONG]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SELECTLUONG]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTLUONG] (@manhanvien nchar(10))
AS
BEGIN
	SELECT NHANVIEN.MaNV, HoTen, LuongCB, LuongThuong, SoNgayTangCa, TongLuong, GhiChu  FROM (NHANVIEN INNER JOIN LUONG ON NHANVIEN.MaNV = LUONG.MaNV) WHERE NHANVIEN.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTNhanVien]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SELECTPHONGBAN]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTPHONGBAN] (@maphongban nvarchar(10))
AS
BEGIN
	SELECT * FROM PHONGBAN WHERE MaPB = @maphongban
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DoiMatKhau]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DoiMatKhau](@id nvarchar(20), @MKCu nvarchar(20), @MKMoi nvarchar(20))
as 
begin
	update DANGNHAP
	set MatKhau = @MKMoi
	where MaNV = @id and MatKhau = @MKCu
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DoiTTCaNhan]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DoiTTCaNhan]
(
	@id nchar(10),
	@HoTen nvarchar(50),
	@GioiTinh nvarchar(3),
	@NgaySinh date,
	@CMTND nvarchar(15),
	@DanToc nvarchar(11),
	@TonGiao nvarchar(11),
	@DiaChi nvarchar(200),
	@SDT nvarchar(15),
	@BangCap nvarchar(50)
)
as
begin
	update NHANVIEN
	set MaNV = @id, HoTen = @HoTen,GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,CMTND = @CMTND, DanToc = @DanToc, TonGiao = @TonGiao, DiaChi = @DiaChi, SDT = @SDT, BangCap = @BangCap
	where MaNV = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insCHUCVU]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insCHUCVU]
          (
          @MaCV char(10),
          @TenCV nvarchar(50)
          )
          AS
          BEGIN
          insert into CHUCVU
          (
             MaCV,
             TenCV
             )
     
         values (@MaCV,@TenCV)
         END
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadThongTinNhanVien]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadThongTinNhanVien](@MaNV nchar(10))
as
begin
	select NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.CMTND, NV.DanToc, NV.TonGiao, NV.DiaChi, NV.SDT, NV.BangCap, VT.TenVT, CV.TenCV, PB.TenPB, L.TongLuong
	from (NHANVIEN as NV left join NHANVIEN_VITRI as NV_VT on NV.MaNV = NV_VT.MaNV)
	left join VITRICONGVIEC as VT on NV_VT.MaVT = VT.MaVT
	left join NHANVIEN_CHUCVU as NV_CV on NV.MaNV = NV_CV.MaNV
	left join CHUCVU as CV on NV_CV.MaCV = CV.MaCV
	join PHONGBAN as PB on NV.MaPB = PB.MaPB
	join LUONG as L on NV.MaNV = L.MaNV
	where NV.MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Login]
(
	@TenDN nvarchar(20),
	@MatKhau nvarchar(20)
)
as
begin
	select case
	when exists (select *from DANGNHAP where TenDN = @TenDN and MatKhau = @MatKhau) then 1
	when not exists (select *from DANGNHAP where TenDN = @TenDN and MatKhau = @MatKhau) then 0
	end
	as Flag
end
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCV]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    create procedure [dbo].[sp_updateCV]
          (
           @MaCV char(10),
           @TenCV nvarchar(50)
          )
          as

          update CHUCVU
            set  
               MaCV=@MaCV,
               TenCV=@TenCV
             where MaCV=@MaCV
GO
/****** Object:  StoredProcedure [dbo].[SuaPB]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPB](@MaPB NVARCHAR(10),@TenPB NVARCHAR(50),@DiaChi NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.PHONGBAN
	SET TenPB = @TenPB,DiaChi = @DiaChi 
	WHERE MaPB = @MaPB
END
GO
/****** Object:  StoredProcedure [dbo].[THEMMOINHANVIEN]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ThemPB]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPB](@MaPB NVARCHAR(10),@TenPB NVARCHAR(50),@DiaChi NVARCHAR(50))
AS
BEGIN
 INSERT INTO dbo.PHONGBAN
 (
     MaPB,
     TenPB,
     DiaChi,
	 MaTP,
	 TenTP
 )
 VALUES
 (   @MaPB, -- MaPB - nvarchar(10)
     @TenPB, -- TenPB - nvarchar(50)
     @DiaChi, -- DiaChi - nvarchar(50)
	 null,
	 null
   
     )
END
GO
/****** Object:  StoredProcedure [dbo].[TIMPHONGBANTHEONHANVIEN]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TIMPHONGBANTHEONHANVIEN] (@manhanvien nchar(10))
AS
BEGIN
	SELECT TenPB FROM (NHANVIEN INNER JOIN PHONGBAN ON NHANVIEN.MaPB = PHONGBAN.MaPB) WHERE NHANVIEN.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEHOPDONG]    Script Date: 10/22/2020 3:54:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[UPDATELUONG]    Script Date: 10/22/2020 3:54:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATELUONG] (@manhanvien nchar(10), @luongCB money, @luongthuong int , @songaytangca int, @tongluong int, @ghichu nvarchar(50))
AS
BEGIN
	UPDATE LUONG SET 
	LuongCB = @luongCB,
	LuongThuong = @luongthuong,
	GhiChu = @ghichu,
	SoNgayTangCa = @songaytangca,
	TongLuong = @tongluong
	WHERE MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATENHANVIEN]    Script Date: 10/22/2020 3:54:38 PM ******/
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
	
	SET @chucvucu = (SELECT TenCV FROM (NHANVIEN LEFT JOIN (NHANVIEN_CHUCVU INNER JOIN CHUCVU ON NHANVIEN_CHUCVU.MaCV = CHUCVU.MaCV) ON NHANVIEN.MaNV = NHANVIEN_CHUCVU.MaNV) WHERE NHANVIEN.MaNV = @Manhanvien)
	IF @chucvucu is null
	BEGIN
		SET @chucvucu = N'Không'
	END
		
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

IF(@chucvu != @chucvucu )
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
				DECLARE @flagg nchar(10)
				SET @flagg = (SELECT MaTP FROM PHONGBAN WHERE MaPB = @Maphongban)
				IF (@flagg is null)
					BEGIN
						UPDATE PHONGBAN SET MaTP = @Manhanvien, TenTP = @Hoten WHERE MaPB = @Maphongban
						DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
						INSERT INTO NHANVIEN_CHUCVU (MaCV, MaNV) VALUES ('CV00000003', @Manhanvien)
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
ELSE
	BEGIN
		IF(@chucvucu = N'Trưởng phòng')
			BEGIN
				DECLARE @ManhanvienTP nchar(10)
				SET @ManhanvienTP = (SELECT MaTP FROM PHONGBAN WHERE TenPB = @phongban)
				IF(@ManhanvienTP is null)
					BEGIN
						DECLARE @maTPcu1 nchar(10)
						SET @maTPcu1 = (SELECT MaPB FROM PHONGBAN WHERE MaTP = @Manhanvien)
						UPDATE PHONGBAN SET MaTP = null, TenTP = null WHERE MaPB = @maTPcu1
						UPDATE PHONGBAN SET MaTP = @Manhanvien, TenTP = @Hoten WHERE MaPB = @Maphongban
						

					END
				ELSE
					BEGIN
						DECLARE @maTPcu nchar(10)
						SET @maTPcu = (SELECT MaPB FROM PHONGBAN WHERE MaTP = @Manhanvien)
						UPDATE PHONGBAN SET MaTP = null, TenTP = null WHERE MaPB = @maTPcu
						DELETE FROM NHANVIEN_CHUCVU WHERE MaNV = @Manhanvien
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
