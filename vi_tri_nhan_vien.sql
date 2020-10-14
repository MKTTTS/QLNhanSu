CREATE proc them_vi_tri
(
	@MaVT nchar(10),
	@TenVT nvarchar(50)
)
as
begin
	INSERT INTO dbo.VITRICONGVIEC
	(
	    MaVT,
	    TenVT
	)
	VALUES
	(   N'@MaVT', -- MaVT - nchar(10)
	    N'@TenVT'  -- TenVT - nvarchar(50)
	    )
END

CREATE proc sua_vi_tri
(
	@MaVT nchar(10),
	@TenVT nvarchar(50)
)
AS
BEGIN	
	UPDATE dbo.VITRICONGVIEC 
	SET TenVT = @TenVT
	WHERE MaVT = @MaVT
END