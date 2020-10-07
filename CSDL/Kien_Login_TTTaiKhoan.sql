create proc SP_Login
(
	@TenDN nvarchar(20),
	@MatKhau nvarchar(20)
)
as
begin
	select MaNV from DANGNHAP where TenDN = @TenDN and MatKhau = @MatKhau
end

SP_Login @TenDN = N'NV01', @MatKhau = N'admin'

create proc SP_LoadThongTinNhanVien(@MaNV nchar(10))
as
begin
	select NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.CMTND, NV.DanToc, NV.TonGiao, NV.DiaChi, NV.SDT, NV.BangCap, VT.TenVT, CV.TenCV,PB.TenPB, L.TongLuong
	from NHANVIEN as NV join NHANVIEN_VITRI as NV_VT on NV.MaNV = NV_VT.MaNV
	join VITRICONGVIEC as VT on NV_VT.MaVT = VT.MaVT
	join NHANVIEN_CHUCVU as NV_CV on NV.MaNV = NV_CV.MaNV
	join CHUCVU as CV on NV_CV.MaCV = CV.MaCV
	join PHONGBAN as PB on NV.MaPB = PB.MaPB
	join LUONG as L on NV.MaNV = L.MaNV
	where NV.MaNV = @MaNV
end