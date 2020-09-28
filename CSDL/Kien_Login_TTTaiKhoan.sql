create proc SP_Login
(
	@TenDN nvarchar(20),
	@MatKhau nvarchar(20)
)
as
begin
	select count(*) from DANGNHAP where TenDN = @TenDN and MatKhau = @MatKhau
end

SP_Login @TenDN = N'NV01', @MatKhau = N'admin'