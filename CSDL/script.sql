USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 24/09/2020 2:23:24 CH ******/
CREATE DATABASE [QuanLyNhanSu]
go 

USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 24/09/2020 2:23:24 CH ******/
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
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 24/09/2020 2:23:24 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDLD]    Script Date: 24/09/2020 2:23:24 CH ******/
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
/****** Object:  Table [dbo].[LUONG]    Script Date: 24/09/2020 2:23:24 CH ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 24/09/2020 2:23:24 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_CHUCVU]    Script Date: 24/09/2020 2:23:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_CHUCVU](
	[MaCV] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_VITRI]    Script Date: 24/09/2020 2:23:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_VITRI](
	[MaVT] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 24/09/2020 2:23:24 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VITRICONGVIEC]    Script Date: 24/09/2020 2:23:24 CH ******/
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

GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000001', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000002', N'Phó giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000003', N'Trưởng phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000004', N'Phó phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000005', N'Nhân viên')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000006', N'Lao công')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV00000007', N'Chủ tịch')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV01', N'admin', N'NV00000001')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV03', N'admin', N'NV00000003')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV04', N'admin', N'NV00000004')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV05', N'admin', N'NV00000005')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV08', N'admin', N'NV00000008')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPKT', N'admin', N'NV00000001')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPMK', N'admin', N'NV00000003')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPNV', N'admin', N'NV00000004')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPTC', N'admin', N'NV00000005')


INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000001', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-12-05' AS Date), CAST(N'2018-10-30' AS Date), N'NV00000001')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000002', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-11-07' AS Date), CAST(N'2016-11-07' AS Date), N'NV00000002')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000003', N'Hợp Đồng Có Thời Hạn', CAST(N'2012-06-12' AS Date), CAST(N'2018-05-11' AS Date), N'NV00000003')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000004', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-08-13' AS Date), CAST(N'2018-08-13' AS Date), N'NV00000004')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000005', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-02-14' AS Date), CAST(N'2019-02-14' AS Date), N'NV00000005')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000006', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-03-15' AS Date), CAST(N'2020-03-15' AS Date), N'NV00000006')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000007', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-16' AS Date), CAST(N'2021-04-16' AS Date), N'NV00000007')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000008', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'NV00000008')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000009', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-06-18' AS Date), CAST(N'2023-06-18' AS Date), N'NV00000009')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000010', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-07-19' AS Date), CAST(N'2024-07-19' AS Date), N'NV00000010')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000011', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-08-20' AS Date), CAST(N'2026-08-20' AS Date), N'NV00000011')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000012', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-09-21' AS Date), CAST(N'2025-09-21' AS Date), N'NV00000012')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV00000013', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-22' AS Date), CAST(N'2026-04-22' AS Date), N'NV00000013')
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
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000001', 7250000, 300000, N'tháng 10', 4, 7750000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000002', 7000000, 700000, N'', 4, 7900000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000003', 1000000, 1000000, N'thương tháng 5',1, 2050000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000004', 700000, 500000, N'', 0, 1200000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000005', 15000000, 300000, N'hợp đồng', 5, 15550000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000006', 6000000, 700000, N'', 5, 6950000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000007', 6500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000008', 8000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000009', 7000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000010', 6000000, 0, N'thánggggggggg', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000011', 5000000, 500000, N'tháng 2', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000012', 5000000, 5000000, N'scfs', 5, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000013', 10000000, 0, N'', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000014', 6000000, 500000, N'kí hợp đồng mới', 8, 6700000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000015', 7500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000016', 7000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000017', 9000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000018', 10000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000019', 9000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000020', 7500000, 0, N'tháng 3', 0, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000021', 6500000, 0, N'', 5, 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000022', 5500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV00000023', 6500000, 0, N'', 0, 0)

INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000001', N'Nguyễn Hữu Chính', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Bắc Giang', N'MK', N'463643564575', N'097854629', N'tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000002', N'Nguyễn Minh Tú', N'Đại Học', N'Nam', CAST(N'1994-09-10' AS Date), N'Hà Nội', N'TC-KT', N'13123214599', N'098765324', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000003', N'Lê Trường Sơn', N'Tiến Sỹ', N'Nam', CAST(N'1993-05-07' AS Date), N'Yên Bái', N'MK', N'12334345465', N'098654353', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000004', N'Đặng Tuấn Anh', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Hà Nội', N'NV', N'4545464565', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000005', N'Phạm Hải Nam', N'Thạc Sỹ', N'Nam', CAST(N'1994-09-07' AS Date), N'Quảng Ninh', N'KT-KT', N'45765857343', N'098643688', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000006', N'Nguyễn Minh Anh', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'TC-KT', N'45653647547', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000007', N'Nguyễn Ba Huy', N'Đại Học', N'Nam', CAST(N'1995-10-10' AS Date), N'Hà Nội', N'TC-KT', N'533532543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000008', N'Phạm Thị Hương', N'Tiến Sỹ', N'Nữ', CAST(N'1993-05-08' AS Date), N'Yên Bái', N'MK', N'436362', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000009', N'Đặng Anh Vũ', N'Đại Học', N'Nam', CAST(N'1996-09-07' AS Date), N'Bắc Giang', N'NV', N'5345235', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000010', N'Lê Hoàng Long', N'Thạc Sỹ', N'Nam', CAST(N'1991-09-07' AS Date), N'Quảng Nam', N'KT-KT', N'35324534543', N'0987554444', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000011', N'Đào Quang An', N'Đại Học', N'Nam', CAST(N'1992-02-07' AS Date), N'Bắc Giang', N'KT-KT', N'35435435325', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000012', N'Nguyễn Phúc Vân Anh', N'Đại Học', N'Nữ', CAST(N'1994-10-07' AS Date), N'Hà Giang', N'TC-KT', N'353535345', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000013', N'Mai Gia Bảo', N'Đại Học', N'Nam', CAST(N'1997-01-07' AS Date), N'Bắc Giang', N'NV', N'455354354645', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000014', N'Nguyễn Vũ Anh Dương', N'Đại Học', N'Nam', CAST(N'1994-09-10' AS Date), N'Bình Định', N'NV', N'5435243532', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000015', N'Trần Thanh Hòa', N'Đại Học', N'Nữ', CAST(N'1994-08-12' AS Date), N'THái Bình', N'MK', N'54235243636', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000016', N'Nguyễn Chấn Huy', N'Đại Học', N'Nam', CAST(N'1993-06-07' AS Date), N'Nghệ An', N'MK', N'2353252345', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000017', N'Nguyễn Lê Đình Huy', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Hà Tĩnh', N'TC-KT', N'353454325', N'9877349500', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000018', N'Mai Quốc Hùng', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Thanh Hóa', N'TC-KT', N'5235255235', N'016765484 ', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000019', N'Nguyễn Thịnh Lâm Khang', N'Đại Học', N'Nam', CAST(N'1994-09-07' AS Date), N'Vĩnh Phúc', N'NV', N'55352235456', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000020', N'Bùi Nguyên Khánh', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'KT-KT', N'353425355435', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000021', N'Lâm Chí Kiệt', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Hải Phòng', N'KT-KT', N'45324535345', N'016765484', N'Tày', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000022', N'Trần Phạm Hoàng Long', N'Đại Học', N'Nam', CAST(N'1994-07-07' AS Date), N'Nam Định', N'NV', N'5325335235', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV00000023', N'Đoàn Điểm My', N'Đại Học', N'Nữ', CAST(N'1994-07-07' AS Date), N'Hà Nội', N'NV', N'532453245243', N'016765484', N'Kinh', N'không')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000001')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000002')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000006')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000007')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000002', N'NV00000015')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000002', N'NV00000016')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000022')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000023')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000003', N'NV00000020')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000005', N'NV00000019')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000005')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000010')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000006', N'NV00000012')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000007', N'NV00000003')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000007', N'NV00000008')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000011')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000014')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000017')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV00000004', N'NV00000018')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000001', N'NV00000001')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000002')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000007', N'NV00000003')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000004')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000005')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000006')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000007')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000007', N'NV00000008')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000009')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000010')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000011')
INSERT [dbo].[NHANVIEN_] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000012')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000013')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000014')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000015')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000005', N'NV00000016')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000017')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000002', N'NV00000018')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000019')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000020')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000003', N'NV00000021')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000022')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT00000004', N'NV00000023')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'KT-KT', N'Kinh Tế - Kỹ Thuật', N'Quảng Nam', N'NV00000011', N'Đào Quang An')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'MK', N'MarKeting', N'Hòa Bình', N'NV00000003', N'Lê Trường Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'NV', N'Nội Vụ', N'Hà Nội', N'NV00000004', N'Đặng Tuấn Anh')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'TC-KT', N'Tài Chính - Kế Toán', N'Yên Bái', N'NV00000001', N'Nguyễn Hữu Chính')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000001', N'Thư Ký ')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000002', N'Kế Toán')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000003', N'Nhân viên Kỹ Thuật')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000004', N'Quản Lý Hồ Sơ - Thiết Bị')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000005', N'Marketting')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000006', N'Hành Chính - Nhân Sự')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT00000007', N'Lễ Tân')

go
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

