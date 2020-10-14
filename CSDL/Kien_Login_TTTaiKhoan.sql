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

SP_LoadThongTinNhanVien @MaNV = N'NV00000001'

create proc SP_DoiMatKhau(@id nvarchar(20), @MKCu nvarchar(20), @MKMoi nvarchar(20))
as 
begin
	update DANGNHAP
	set MatKhau = @MKMoi
	where MaNV = @id and MatKhau = @MKCu
end

create proc SP_DoiTTCaNhan
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