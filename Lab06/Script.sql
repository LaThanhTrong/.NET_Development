Use QLCB;
sp_changedbowner mylogin;

Create Table ChucVu( 
	MaCV int Primary Key IDENTITY(1,1), 
	TenCV nvarchar(100) Not Null, 
)
drop table chucvu;

Create Table CanBo( 
	MaCB int Primary Key, 
	TenCB nvarchar(100) Not Null, 
	ChucVuCB int Not Null, 
	SoGioGiang int Not Null, 
	DonGia Money Not Null,
	CONSTRAINT fk_canbo_chucvu FOREIGN KEY(ChucVuCB) REFERENCES ChucVu(MaCV) ON DELETE CASCADE ON UPDATE CASCADE
)
drop table canbo;

INSERT INTO ChucVu (TenCV) VALUES (N'Giảng viên');
INSERT INTO ChucVu (TenCV) VALUES (N'Giáo sư');
INSERT INTO ChucVu (TenCV) VALUES (N'Phó Giáo sư');
INSERT INTO ChucVu (TenCV) VALUES (N'Trợ giảng');
INSERT INTO ChucVu (TenCV) VALUES (N'Hiệu trưởng');
INSERT INTO ChucVu (TenCV) VALUES (N'Phó Hiệu trưởng');

DELETE FROM ChucVu;

SELECT * FROM ChucVu;
SELECT * FROM CanBo;

