CREATE DATABASE ThanhToan;
USE ThanhToan;

sp_changedbowner mylogin;

-- Create Phong table
CREATE TABLE Phong (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(255) NOT NULL
);

-- Create KhachHang table
CREATE TABLE KhachHang (
    SoHD INT PRIMARY KEY,
    TenKH NVARCHAR(255) NOT NULL,
    SoCMND NVARCHAR(20) NOT NULL,
    SoTien Money NOT NULL,
    NgayTT DATE NOT NULL,
    Phong INT,
    CONSTRAINT fk_khachhang_phong FOREIGN KEY (Phong) REFERENCES Phong(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE
);
DROP TABLE KhachHang;

INSERT INTO Phong (MaPhong, TenPhong) VALUES (1, 'A101');
INSERT INTO Phong (MaPhong, TenPhong) VALUES (2, 'A102');
INSERT INTO Phong (MaPhong, TenPhong) VALUES (3, 'B201');

SELECT * FROM Phong;
SELECT * FROM KhachHang;