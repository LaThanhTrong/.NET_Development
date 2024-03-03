use QL_HANGHOA;

-- Bai 1
DROP TABLE IF EXISTS MUA;
DROP TABLE IF EXISTS BAN;
DROP TABLE IF EXISTS HANGHOA;
DROP TABLE IF EXISTS LOAI_HG;
DROP TABLE IF EXISTS DAILY;


CREATE TABLE DAILY (
    STT_DL INT NOT NULL IDENTITY(1,1),
    TEN_DL NVARCHAR(20) NOT NULL,
    DCHI_DL NVARCHAR(20) NULL,
    CONSTRAINT PK_DAILY PRIMARY KEY (STT_DL)
);

CREATE TABLE HANGHOA (
    MA_HANG NVARCHAR(3) NOT NULL,
    TEN_HG NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_HANGHOA PRIMARY KEY (MA_HANG)
);

CREATE TABLE MUA (
    STT_DL INT NOT NULL,
    MA_HANG NVARCHAR(3) NOT NULL,
    NGAY_MUA SMALLDATETIME NOT NULL DEFAULT GETDATE(),
    SOLG_MUA INT NOT NULL CHECK (SOLG_MUA > 0),
    TRIGIA_MUA FLOAT NOT NULL CHECK (TRIGIA_MUA > 0),
    CONSTRAINT PK_MUA PRIMARY KEY (STT_DL, MA_HANG,NGAY_MUA),
    CONSTRAINT FK_MUA_DAILY FOREIGN KEY (STT_DL) REFERENCES DAILY (STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_MUA_HANGHOA FOREIGN KEY (MA_HANG) REFERENCES HANGHOA (MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT CK_MUA_NGAY_MUA CHECK (NGAY_MUA <= GETDATE())
);

CREATE TABLE BAN (
    STT_DL INT NOT NULL,
    MA_HANG NVARCHAR(3) NOT NULL,
    NGAY_BAN SMALLDATETIME NOT NULL DEFAULT GETDATE(),
    SOLG_BAN INT NOT NULL CHECK (SOLG_BAN > 0),
    TRIGIA_BAN FLOAT NOT NULL CHECK (TRIGIA_BAN > 0),
    CONSTRAINT PK_BAN PRIMARY KEY (STT_DL, MA_HANG,NGAY_BAN),
    CONSTRAINT FK_BAN_DAILY FOREIGN KEY (STT_DL) REFERENCES DAILY (STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_BAN_HANGHOA FOREIGN KEY (MA_HANG) REFERENCES HANGHOA (MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT CK_BAN_NGAY_BAN CHECK (NGAY_BAN <= GETDATE())
);

-- Bai 2
ALTER TABLE DAILY ADD SODT CHAR(11) NOT NULL;

ALTER TABLE HANGHOA
ADD DVT CHAR(12) NOT NULL,
	NCC CHAR(30) NOT NULL;

CREATE TABLE LOAI_HG (
    MA_LOAI CHAR(2) NOT NULL,
    TEN_LOAI CHAR(50) NOT NULL,
    CONSTRAINT PK_LOAI_HG PRIMARY KEY (MA_LOAI)
);

ALTER TABLE HANGHOA
ADD MA_LOAI CHAR(2) NOT NULL;

ALTER TABLE HANGHOA
ADD CONSTRAINT FK_HANGHOA_LOAI_HG FOREIGN KEY (MA_LOAI) REFERENCES LOAI_HG (MA_LOAI) ON DELETE CASCADE ON UPDATE CASCADE;

-- Bai 3
/*
Về nguyên tắc khi nhập dữ liệu vào CSDL QL_HANGHOA trên thì ta cần nhập dữ liệu cho 2 bảng DAILY và HANGHOA trước sau đó mới nhập dữ liệu cho bảng MUA và bảng BAN vì:
	- Bảng DAILY và HANGHOA là hai bảng cơ sở, chứa thông tin cơ bản về đại lý và hàng hóa. Các bảng MUA và BAN phụ thuộc vào hai bảng cơ sở này.
	- Các bảng MUA và BAN có ràng buộc khóa ngoại tham chiếu đến hai bảng cơ sở DAILY và HANGHOA.
*/

INSERT INTO MUA (STT_DL, MA_HANG, NGAY_MUA, SOLG_MUA, TRIGIA_MUA)
VALUES (1, 'AB', '2023-07-20', 10, 100000);

/*
The INSERT statement conflicted with the FOREIGN KEY constraint "FK_MUA_DAILY". The conflict occurred in database "QL_HANGHOA", table "dbo.DAILY", column 'STT_DL'.
The statement has been terminated.

Cascade update là một ràng buộc khóa ngoại cho phép cập nhật giá trị của cột khóa ngoại trong bảng phụ theo giá trị của cột khóa chính trong bảng chính.
- Khi cập nhật giá trị của cột khóa chính MA_HANG trong bảng HANGHOA, giá trị của cột khóa ngoại MA_HANG trong bảng MUA sẽ được cập nhật theo.
- Khi cập nhật giá trị của cột khóa ngoại MA_HANG trong bảng MUA, giá trị của cột khóa chính MA_HANG trong bảng HANGHOA sẽ được cập nhật theo.
*/

INSERT INTO DAILY (TEN_DL, DCHI_DL, SODT)
VALUES ('Vinamilk Company', 'Ly Thuong Kiet', '0901248021');

INSERT INTO LOAI_HG (MA_LOAI, TEN_LOAI) VALUES ('MK','Milk');

INSERT INTO HANGHOA (MA_HANG, TEN_HG, DVT, NCC, MA_LOAI)
VALUES ('AB', 'Milk Cream', 'Lon', 'Vinamilk','MK');

INSERT INTO MUA (STT_DL, MA_HANG, NGAY_MUA, SOLG_MUA, TRIGIA_MUA)
VALUES (1, 'AB', '2024-01-12', 10, 100000);
DELETE FROM MUA;

INSERT INTO BAN (STT_DL, MA_HANG, NGAY_BAN,SOLG_BAN, TRIGIA_BAN)
VALUES (1, 'AB', '2024-01-12', 10, 100000);
DELETE FROM BAN;

UPDATE HANGHOA
SET MA_HANG = 'CD'
WHERE MA_HANG = 'AB';

SELECT * FROM MUA;
SELECT * FROM BAN;
SELECT * FROM HANGHOA;

/*	
	Khi sửa mã hàng AB thành CD trên bảng HANGHOA, giá trị của cột khóa ngoại MA_HANG trong bảng MUA và BAN cũng được cập nhật theo.
*/

/*
Mở diagram của CSDL QL_HANGHOA, click phải chuột lên quan hệ giữa bảng HANGHOA và bảng MUA (tương tự với quan hệ giữa bảng DAILY và bảng MUA), 
chọn properties và kiểm tra xem đã đánh dấu chọn cascade delete.
*/

DELETE FROM HANGHOA;

/*
Khi bỏ chọn đánh dấu chọn cascade delete:
	The DELETE statement conflicted with the REFERENCE constraint "FK_MUA_HANGHOA". The conflict occurred in database "QL_HANGHOA", table "dbo.MUA", column 'MA_HANG'. The statement has been terminated.

Khi đánh dấu chọn cascade delete:
	(1 row affected)

Cascade delete là một loại ràng buộc khóa ngoại cho phép xóa một bản ghi trong bảng chính sẽ tự động xóa tất cả các bản ghi liên quan trong bảng phụ, đảm bảo tính nhất quán của dữ liệu trong cơ sở dữ liệu.
Nếu sử dụng cascade delete cho ràng buộc khóa ngoại, thì khi xóa một mặt hàng khỏi bảng HANGHOA, tất cả các bản ghi trong bảng MUA có chứa mã hàng của mặt hàng đó cũng sẽ bị xóa.

*/

-- Bai 4
create table product 
	(prod_nr int not null primary key, 
	name varchar(30) not null, 
	price money not null, 
	type varchar(30) not null
)

insert into product values (4,'ColorTv',700,'electronic');
insert into product values (5,'Fan',350,'electronic');
insert into product values (6,'Heater',200,'electronic'); 
insert into product values (7,'Webcam',60,'Computer');
DELETE FROM product;

SELECT * FROM product;

CREATE PROCEDURE CalculateAndPrintAveragePrice
AS
BEGIN
  DECLARE @avg_price FLOAT;

  SELECT @avg_price = AVG(price)
  FROM product;

  PRINT 'Average Price: ' + CONVERT(VARCHAR, @avg_price);
END;

EXEC CalculateAndPrintAveragePrice;

DECLARE @average_price MONEY;

WHILE 1 = 1
BEGIN
    SELECT @average_price = AVG(price) FROM product;

    IF @average_price >= 500
        BREAK;
    ELSE
        UPDATE product SET price = price * 1.05;
END

PRINT 'Average Price after Increase: ' + CONVERT(VARCHAR, @average_price);
SELECT * FROM product;

-- Bai 5
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_NAME = 'TonKho' AND ROUTINE_TYPE = 'PROCEDURE')
BEGIN
    DROP PROCEDURE TonKho;
END

Create Procedure TonKho 
    @STT_DL int, @Ma_Hang nvarchar(3), 
    @TongMua int Output, @TongBan int Output, @Ton int Output 
As 
Begin 
    Select @TongMua = ISNULL(Sum(SoLg_Mua), 0)
    From Mua 
    Where STT_DL = @STT_DL and Ma_Hang = @Ma_Hang 

    Select @TongBan = ISNULL(Sum(SoLg_Ban), 0)
    From Ban 
    Where STT_DL = @STT_DL and Ma_Hang = @Ma_Hang 

    Set @Ton = @TongMua - @TongBan 
End

Declare @Mua int, @Ban int, @Ton int 
Execute TonKho 2, '002', @Mua Output, @Ban Output, @Ton Output 
PRINT 'Tong mua: ' + Cast(@Mua as varchar(20)) + 
'. Tong ban ' + Cast(@Ban as varchar(20)) + 
'. Ton: '+ Cast(@Ton as varchar(20));
