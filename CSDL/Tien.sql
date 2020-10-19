CREATE PROC Load
AS 
BEGIN
	SELECT * FROM dbo.PHONGBAN 
END

LOAD

CREATE PROC ThemPB(@MaPB NVARCHAR(10),@TenPB NVARCHAR(50),@DiaChi NVARCHAR(50))
AS
BEGIN
 INSERT INTO dbo.PHONGBAN
 (
     MaPB,
     TenPB,
     DiaChi
 )
 VALUES
 (   @MaPB, -- MaPB - nvarchar(10)
     @TenPB, -- TenPB - nvarchar(50)
     @DiaChi -- DiaChi - nvarchar(50)
   
     )
END

go
ThemPB N'MaPB', N'TenPB',N'DiaChi'

CREATE PROC Sua(@MaPB NVARCHAR(10),@TenPB NVARCHAR(50),@DiaChi NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.PHONGBAN
	SET TenPB = @TenPB,DiaChi = @DiaChi 
	WHERE MaPB = @MaPB
END
GO
Sua  N'MaPB', N'TenPB',N'DiaChi'

