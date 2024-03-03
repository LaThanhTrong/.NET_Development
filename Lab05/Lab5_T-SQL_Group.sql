CREATE DATABASE QL_HANGHOA;

USE QL_HANGHOA;

DROP TABLE DAILY;
DROP TABLE BAN;
DROP TABLE MUA;
DROP TABLE HANGHOA;



--BAI1
-- Tạo bảng DAILY
CREATE TABLE DAILY (
    STT_DL int PRIMARY KEY,
    TENDL nvarchar(20),
    DCHI_DL nvarchar(20)
);


-- Tạo bảng BAN
CREATE TABLE BAN (
    MA_HANG nvarchar(3),
    STT_DL int,
    NGAY_BAN smalldatetime,
    SOLG_BAN int,
    TRIGIA_BAN float,
    PRIMARY KEY (MA_HANG, STT_DL, NGAY_BAN),
    CHECK (SOLG_BAN > 0 AND TRIGIA_BAN > 0),
    FOREIGN KEY (STT_DL) REFERENCES DAILY(STT_DL) ON DELETE CASCADE,
    FOREIGN KEY (MA_HANG) REFERENCES HANGHOA(MA_HANG) ON DELETE CASCADE
);


-- Tạo bảng MUA
CREATE TABLE MUA (
    MA_HANG nvarchar(3),
    STT_DL int,
    NGAY_MUA smalldatetime DEFAULT GETDATE(),
    SLG_MUA int,
    TRIGIA_MUA float,
    PRIMARY KEY (MA_HANG, STT_DL, NGAY_MUA),
    CHECK (SLG_MUA > 0 AND TRIGIA_MUA > 0),
    FOREIGN KEY (STT_DL) REFERENCES DAILY(STT_DL) ON DELETE CASCADE,
    FOREIGN KEY (MA_HANG) REFERENCES HANGHOA(MA_HANG) ON DELETE CASCADE
);

-- Tạo bảng HANGHOA
CREATE TABLE HANGHOA (
    MA_HANG nvarchar(3) PRIMARY KEY,
    TEN_HG nvarchar(20)
);

-- Tạo ràng buộc ngày mua và ngày bán
ALTER TABLE MUA
ADD CONSTRAINT CHK_NGAY_MUA CHECK (NGAY_MUA <= GETDATE());

ALTER TABLE BAN
ADD CONSTRAINT CHK_NGAY_BAN CHECK (NGAY_BAN <= GETDATE());

-- Tạo khóa ngoại
ALTER TABLE BAN
ADD CONSTRAINT FK_BAN_DAILY FOREIGN KEY (STT_DL) REFERENCES DAILY(STT_DL);

ALTER TABLE BAN
ADD CONSTRAINT FK_BAN_HANGHOA FOREIGN KEY (MA_HANG) REFERENCES HANGHOA(MA_HANG);

ALTER TABLE MUA
ADD CONSTRAINT FK_MUA_DAILY FOREIGN KEY (STT_DL) REFERENCES DAILY(STT_DL);

ALTER TABLE MUA
ADD CONSTRAINT FK_MUA_HANGHOA FOREIGN KEY (MA_HANG) REFERENCES HANGHOA(MA_HANG);


-- Show structure of DAILY table
EXEC sp_columns 'DAILY';

-- Show structure of BAN table
EXEC sp_columns 'BAN';

-- Show structure of MUA table
EXEC sp_columns 'MUA';

-- Show structure of HANGHOA table
EXEC sp_columns 'HANGHOA';


--BAI2
-- Thêm cột SODT vào bảng DAILY
ALTER TABLE DAILY
ADD SODT CHAR(11);


-- Thêm cột DVT và NCC vào bảng HANGHOA
ALTER TABLE HANGHOA
ADD DVT CHAR(12),
    NCC CHAR(30);


-- Tạo bảng LOAI_HG
CREATE TABLE LOAI_HG (
    MA_LOAI CHAR(2),
    TEN_LOAI CHAR(50),
    PRIMARY KEY (MA_LOAI)
);

 drop table LOAI_HG;

-- Thêm cột MA_LOAI vào bảng HANGHOA
ALTER TABLE HANGHOA
ADD MA_LOAI CHAR(2);

-- Tạo khóa ngoại tham chiếu
ALTER TABLE HANGHOA
ADD CONSTRAINT FK_HANGHOA_LOAI_HG
FOREIGN KEY (MA_LOAI)
REFERENCES LOAI_HG(MA_LOAI)
ON UPDATE CASCADE
ON DELETE CASCADE;


--Bai 3: Y Nghia Khoa Ngoai
/*
1. Nguyên tắc nhập dữ liệu:

Trong trường hợp CSDL QL_HANGHOA, cần nhập dữ liệu cho bảng DAILY và HANGHOA trước vì các bảng MUA và BAN 
có khóa ngoại tham chiếu đến khóa chính của bảng DAILY và HANGHOA. Điều này đảm bảo rằng mỗi đợt nhập dữ 
liệu cho MUA và BAN đều liên quan đến đối tượng có sẵn trong bảng DAILY và HANGHOA.


2. Thử nhập dữ liệu cho bảng MUA trước:

Nếu thử nhập dữ liệu cho bảng MUA trước khi nhập dữ liệu cho DAILY và HANGHOA, 
SQL Server sẽ phát hiện lỗi vì không tồn tại khóa chính hoặc khóa ngoại chưa được 
tạo trong DAILY hoặc HANGHOA. Cascade update không ảnh hưởng vì không có dữ liệu hợp lệ để cập nhật.


3. Thử nhập dữ liệu sau đó mới nhập dữ liệu cho MUA và BAN:

Khi nhập dữ liệu vào DAILY và HANGHOA trước, sau đó nhập dữ liệu cho 
MUA và BAN, SQL Server cho phép thêm dữ liệu mới với điều kiện là dữ liệu 
đó hợp lệ với các ràng buộc khóa ngoại.

4. Sửa mã hàng trên bảng HANGHOA và mở bảng MUA (cả bảng BAN):

Nếu sửa mã hàng trên bảng HANGHOA và có cascade update, thì tất cả 
các hàng liên quan trong bảng MUA (cả BAN) sẽ được cập nhật theo mã hàng mới.
Nếu không có cascade update, sẽ phải cập nhật thủ công mã hàng trong bảng MUA và BAN.

5. Cascade delete:

Khi xóa một hàng trong bảng DAILY hoặc HANGHOA có cascade delete, tất cả các 
hàng liên quan trong bảng MUA hoặc BAN cũng sẽ bị xóa.
Nếu không có cascade delete, xóa một hàng trong DAILY hoặc HANGHOA có thể gây ra lỗi 
khóa ngoại nếu có hàng liên quan trong MUA hoặc BAN.

6. Kiểm tra cascade delete trong diagram:

Nếu có cascade delete, việc xóa một hàng trong DAILY hoặc HANGHOA sẽ tự động 
xóa các hàng liên quan trong MUA hoặc BAN.
Nếu không có cascade delete, xóa một hàng trong DAILY hoặc HANGHOA có thể yêu cầu 
xóa thủ công các hàng liên quan trong MUA hoặc BAN.

*/

--Them du lieu vao cac bang
--DAILY
INSERT INTO DAILY (STT_DL, TENDL, DCHI_DL, SODT) 
VALUES 
(1, 'Đại Lý A', 'Địa chỉ A', '0123456789'),
(2, 'Đại Lý B', 'Địa chỉ B', '0987654321');


--HANGHOA
INSERT INTO HANGHOA (MA_HANG, TEN_HG, DVT, NCC, MA_LOAI)
VALUES
('HH1', 'Hàng hóa 1', 'Kg', 'Nhà cung cấp 1', 'L1'),
('HH2', 'Hàng hóa 2', 'Kg', 'Nhà cung cấp 2', 'L2');


--LOAI_HG
INSERT INTO LOAI_HG (MA_LOAI, TEN_LOAI)
VALUES
('L1', 'Loại 1'),
('L2', 'Loại 2');


-- Chọn STT_DL từ bảng DAILY
-- Chọn MA_HANG từ bảng HANGHOA
-- Đặt ngày bán là ngày hiện tại
INSERT INTO BAN (MA_HANG, STT_DL, NGAY_BAN, SOLG_BAN, TRIGIA_BAN)
VALUES
('HH1', 1, GETDATE(), 5, 100),
('HH2', 2, GETDATE(), 8, 200);



-- Chọn STT_DL từ bảng DAILY
-- Chọn MA_HANG từ bảng HANGHOA
-- Đặt ngày mua là ngày hiện tại
INSERT INTO MUA (MA_HANG, STT_DL, NGAY_MUA, SLG_MUA, TRIGIA_MUA)
VALUES
('HH1', 1, GETDATE(), 10, 300),
('HH2', 2, GETDATE(), 15, 400);


select * from DAILY;
select * from MUA;
select * from BAN;
select * from HANGHOA;
select * from LOAI_HG;






/*Bai 4 Lap trinh T-SQL*/
--Cau1
CREATE TABLE product (
    prod_nr int not null primary key,
    name varchar(30) not null,
    price money not null,
    type varchar(30) not null
);

DROP TABLE product;

-- 2. Thêm dữ liệu
INSERT INTO product VALUES (4, 'ColorTv', 700, 'electronic');
INSERT INTO product VALUES (5, 'Fan', 350, 'electronic');
INSERT INTO product VALUES (6, 'Heater', 200, 'electronic');
INSERT INTO product VALUES (7, 'Webcam', 60, 'Computer');


-- 3. Truy vấn bảng product và quan sát dữ liệu
SELECT * FROM product;


-- 4. Tính trị giá trung bình và hiển thị thông qua biến
declare @averagePriceProduct money;
select @averagePriceProduct = avg(price) from product;
print 'Average Price Product: ' + cast(@averagePriceProduct as varchar);



-- 5. Tính trị giá trung bình và kiểm tra điều kiện
-- Biến để lưu trữ trị giá trung bình
declare @averagePrice money;
WHILE (1 = 1)
BEGIN
    -- Tính trị giá trung bình và kiểm tra
    SET @averagePrice = (SELECT AVG(price) FROM product);

    -- Kiểm tra nếu trị giá trung bình >= 500 thì hiển thị bảng giá chi tiết
    IF (@averagePrice >= 500)
    BEGIN
        SELECT * FROM product;
        BREAK;
    END
    ELSE
    BEGIN
        -- Tăng giá mỗi sản phẩm lên 5%
        UPDATE product
        SET price = price * 1.05;

        -- Hiển thị thông báo và bảng giá chi tiết
        PRINT 'Increasing prices by 5%...';
        SELECT * FROM product;
    END
END

-- Hiển thị trị giá trung bình và bảng giá chi tiết cuối cùng
PRINT 'Final Average Price: ' + CONVERT(varchar, @averagePrice);
SELECT * FROM product;



--Bai5
-- B5 - Cau 1. Viết thủ tục tính số lượng tồn của 1 mặt hàng của 1 đại lý cụ thể.
CREATE PROCEDURE TonKho
    @STT_DL int,
    @Ma_Hang nvarchar(3),
    @TongMua int OUTPUT,
    @TongBan int OUTPUT,
    @Ton int OUTPUT
AS
BEGIN
    -- Tính tổng mua
    SELECT @TongMua = ISNULL(SUM(SLG_MUA), 0)
    FROM MUA
    WHERE STT_DL = @STT_DL AND MA_HANG = @Ma_Hang;

    -- Tính tổng bán
    SELECT @TongBan = ISNULL(SUM(SOLG_BAN), 0)
    FROM BAN
    WHERE STT_DL = @STT_DL AND MA_HANG = @Ma_Hang;

    -- Tính tồn kho
    SET @Ton = @TongMua - @TongBan;
END

-- Gọi thực thi thủ tục
DECLARE @Mua int, @Ban int, @Ton int
EXEC TonKho 2, 'HH2', @Mua OUTPUT, @Ban OUTPUT, @Ton OUTPUT
PRINT 'Tong mua: ' + CAST(@Mua AS VARCHAR(20)) +
'. Tong ban: ' + CAST(@Ban AS VARCHAR(20)) +
'. Ton: ' + CAST(@Ton AS VARCHAR(20));


-- Bai 5 - Cau 2. Viết thủ tục bán 1 mặt hàng của một đại lý cụ thể với số lượng và đơn giá bán cho trước, ngày bán là ngày hiện hành
Create Procedure BanHang
@STT_DL int, @Ma_Hang nvarchar(3), @SoLgBan int, @DonGia int
As
Begin
Declare @TongMua int, @TongBan int
Select @TongMua=Sum(SLG_MUA)
From Mua
Where STT_DL=@STT_DL and Ma_HAng=@Ma_Hang
If @TongMua Is NULL
Begin
print 'Mat hang ' + @Ma_Hang + ' khong co' + ' o dai ly'
Return
End
Select @TongBan=Sum(SoLg_Ban)
From Ban
Where STT_DL=@STT_DL and Ma_Hang=@Ma_Hang

if @TongBan Is Null
Set @TongBan=0


if @TongMua >= @TongBan + @SoLgBan
Insert Into Ban Values(@Ma_Hang, @STT_DL, GetDate(),

@SoLgBan, @DonGia)

else
print 'Khong du hang de ban'
End

--Thực thi thủ tục:
select * from HANGHOA;


-- Thuc thi thu tuc voi mot mat hang khong co san trong dai ly (STT_DL = 2, Ma_Hang = '002')
EXEC BanHang 2, '002', 160, 12;

-- Thực thi thủ tục và lấy thông báo kết quả mat hang khong du ban
EXEC BanHang 1, 'HH1', 3, 50;


--Bai 5 - Cau 3. Viết thủ tục cho phép tính tồn kho của mỗi mặt hàng của một đại lý cụ thể (STT_DL là tham số).
CREATE PROCEDURE CalculateInventoryByAgent
    @STT_DL INT
AS
BEGIN
    SELECT
        H.MA_HANG,
        H.TEN_HG,
        COALESCE(SUM(M.SLG_MUA), 0) - COALESCE(SUM(B.SOLG_BAN), 0) AS TonKho
    FROM
        HANGHOA H
        LEFT JOIN MUA M ON H.MA_HANG = M.MA_HANG AND M.STT_DL = @STT_DL
        LEFT JOIN BAN B ON H.MA_HANG = B.MA_HANG AND B.STT_DL = @STT_DL
    GROUP BY
        H.MA_HANG, H.TEN_HG;
END;


-- Kiểm tra với đại lý có STT_DL = 1
EXEC CalculateInventoryByAgent @STT_DL = 1;

-- Kiểm tra với đại lý có STT_DL = 2
EXEC CalculateInventoryByAgent @STT_DL = 2;

-- Kiểm tra với đại lý có STT_DL = 3
EXEC CalculateInventoryByAgent @STT_DL = 3;


--Bai 5 - Cau 4. Viết thủ tục cho phép tính tồn kho của mỗi mặt hàng của mỗi đại lý.
CREATE PROCEDURE CalculateInventoryForAllAgents
AS
BEGIN
    SELECT
        H.MA_HANG,
        H.TEN_HG,
        COALESCE(SUM(M.SLG_MUA), 0) - COALESCE(SUM(B.SOLG_BAN), 0) AS TonKho
    FROM
        HANGHOA H
        LEFT JOIN MUA M ON H.MA_HANG = M.MA_HANG
        LEFT JOIN BAN B ON H.MA_HANG = B.MA_HANG
    GROUP BY
        H.MA_HANG, H.TEN_HG;
END;

--Kiem tra thu tuc
EXEC CalculateInventoryForAllAgents;



--Bai 5 Cau 5: Giả sử các khóa ngoại của bảng BAN và MUA có thuộc loại On Delete No Action.
--Viết thủ tục cho phép xóa một hàng hóa cùng các thông tin liên quan tới hàng hóa này ở
--bảng BAN và MUA với mã hàng là tham số.

CREATE PROCEDURE DeleteProductWithRelatedInfo
    @MA_HANG nvarchar(3)
AS
BEGIN
    -- Xóa các thông tin từ bảng BAN
    DELETE FROM BAN
    WHERE MA_HANG = @MA_HANG;

    -- Xóa các thông tin từ bảng MUA
    DELETE FROM MUA
    WHERE MA_HANG = @MA_HANG;

    -- Xóa hàng hóa từ bảng HANGHOA
    DELETE FROM HANGHOA
    WHERE MA_HANG = @MA_HANG;
END;


EXEC DeleteProductWithRelatedInfo @MA_HANG = 'HH1';

select * from HANGHOA;
select * from MUA;
select * from BAN;

--Bai 6
CREATE DATABASE NHANVIEN;

USE NHANVIEN;


CREATE TABLE nhanvien (
    manv int not null primary key,
    hoten varchar(30) not null,
    diachi varchar(30) not null
);


CREATE PROCEDURE insert_nhanvien
@manv int, @hoten varchar(30), @diachi varchar(30)
AS
BEGIN
    INSERT INTO nhanvien VALUES (@manv, @hoten, @diachi);
END;


-- Thêm mẩu tin nhân viên
EXEC insert_nhanvien 1, 'Nguyen Van Thanh', '01 Ly Tu Trong, NK– TPCT';

-- Hiển thị bảng nhân viên
SELECT * FROM nhanvien;


CREATE PROCEDURE update_diachi_nhanvien
@manv int, @new_diachi varchar(30)
AS
BEGIN
    UPDATE nhanvien
    SET diachi = @new_diachi
    WHERE manv = @manv;
END;


-- Cập nhật địa chỉ
EXEC update_diachi_nhanvien 1, '10 Ly Tu Trong, Q. NK – TPCT';

-- Hiển thị bảng nhân viên
SELECT * FROM nhanvien;
drop table nhanvien;



--Bai 7
CREATE DATABASE Northwind;

USE Northwind;


-- Create a sample 'Orders' table
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY,
    OrderDate DATE
);

-- Create a sample '[Order Details]' table
CREATE TABLE [Order Details] (
    OrderDetailId INT PRIMARY KEY,
    OrderId INT,
    UnitPrice MONEY,
    Quantity INT,
    Discount FLOAT,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);

-- Insert some sample data
INSERT INTO Orders (OrderId, OrderDate) VALUES
(10249, '2024-01-27');

INSERT INTO [Order Details] (OrderDetailId, OrderId, UnitPrice, Quantity, Discount) VALUES
(1, 10249, 10.0, 5, 0.1),
(2, 10249, 15.0, 10, 0.2);




CREATE PROCEDURE CalculateMoney_Order
@Order_ID char(5)
AS
BEGIN
    SELECT SUM(UnitPrice * Quantity - UnitPrice * Quantity * Discount) as Total_Price
    FROM [Order Details]
    WHERE OrderId = @Order_ID;
END;

--Example
EXEC CalculateMoney_Order '10249';

--Function Cach 2
create function dbo.CalulateMoney(@Order_ID char(5))
returns table
as
return (select sum(UnitPrice*Quantity-
UnitPrice*Quantity*Discount) as Total_Price
from [Order Details] where OrderId=@Order_ID)


--Example Cach 2
select * from dbo.CalulateMoney('10249')


--Function Cach 3
create function dbo.Calulate(@Order_ID char(5))
returns money
as
Begin
Declare @a money
select @a= sum(UnitPrice*Quantity - UnitPrice*Quantity*Discount)
from [Order Details]
where OrderId=@Order_ID
return @a
End

--Example Cach 3
select dbo.Calulate('10249')


--Bai8
USE QL_HANGHOA;

CREATE FUNCTION dbo.CheckChiaDu11(@SoTaiKhoan nvarchar(9))
RETURNS bit
AS
BEGIN
    DECLARE @Sum int = 0;
    DECLARE @Multiplier int = 1;

    DECLARE @Length int = LEN(@SoTaiKhoan);

    WHILE @Length > 0
    BEGIN
        SET @Sum = @Sum + (CAST(SUBSTRING(@SoTaiKhoan, @Length, 1) AS int) * @Multiplier);
        SET @Multiplier = CASE WHEN @Multiplier = 2 THEN 1 ELSE 2 END;
        SET @Length = @Length - 1;
    END

    RETURN CASE WHEN @Sum % 11 = 0 THEN 1 ELSE 0 END;
END;


CREATE TABLE Account (
    AccountID int PRIMARY KEY,
    AccountName varchar(30),
    AccountNumber nvarchar(9) CONSTRAINT CHK_AccountNumber CHECK (dbo.CheckChiaDu11(AccountNumber) = 1)
);



-- Thêm dữ liệu mẫu
INSERT INTO Account (AccountID, AccountName, AccountNumber) VALUES (1, 'Thanh Cong', '972428577');
INSERT INTO Account (AccountID, AccountName, AccountNumber) VALUES (2, 'Khong Thanh Cong', '190620024');


select * from Account;
delete from account where AccountName = 'Thanh Cong';





