CREATE DATABASE QLSV;
USE QLSV;

DROP TABLE Grades;
DROP TABLE Teaching;
DROP TABLE Instructors;
DROP TABLE Courses;
DROP TABLE Students;

sp_changedbowner admin;

CREATE TABLE Students (
    MSSV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    MaLop VARCHAR(10),
    TenLop NVARCHAR(50)
);

CREATE TABLE Courses (
    MaMon VARCHAR(10) PRIMARY KEY,
    TenMon NVARCHAR(100)
);

CREATE TABLE Instructors (
    MaCB VARCHAR(10) PRIMARY KEY,
    TenCB NVARCHAR(100),
    MatKhau VARCHAR(50)
);

CREATE TABLE Teaching (
    MaCB VARCHAR(10),
    MaMon VARCHAR(10),
    MaLop VARCHAR(10),
    PRIMARY KEY (MaCB, MaMon, MaLop),
    FOREIGN KEY (MaCB) REFERENCES Instructors(MaCB),
    FOREIGN KEY (MaMon) REFERENCES Courses(MaMon),
);

CREATE TABLE Grades (
    MaCB VARCHAR(10),
    MaMon VARCHAR(10),
    DiemThi FLOAT,
	PRIMARY KEY (MaCB, MaMon),
    FOREIGN KEY (MaMon) REFERENCES Courses(MaMon),
	FOREIGN KEY (MaCB) REFERENCES Instructors(MaCB),
);

INSERT INTO Students (MSSV, HoTen, MaLop, TenLop) VALUES
('B18001', N'Phạm Thị Bảo Nhiên', 'K44-01', 'CNPM 01'),
('B18002', N'Nguyễn Văn An', 'K44-01', 'CNPM 01'),
('B18003', N'Lê Hoài Anh', 'K44-01', 'CNPM 01'),
('B18004', N'Nguyễn Lâm Hoàng Anh', 'K44-01', 'CNPM 01'),
('B18005', N'Lê Minh Bằng', 'K44-01', 'CNPM 01'),
('B18006', N'Vương Thừa Chấn', 'K44-02', 'CNPM 02'),
('B18007', N'Cao Công Danh', 'K44-02', 'CNPM 02'),
('B18008', N'Trịnh Lê Long Đức', 'K44-02', 'CNPM 02'),
('B18009', N'Dương Lê Minh Hậu', 'K44-02', 'CNPM 02'),
('B18010', N'Nguyễn Vũ Hoàng', 'K44-02', 'CNPM 02'),
('B18011', N'Nguyễn Hoàng Thái Học', 'K44-03', 'CNPM 03'),
('B18012', N'Nguyễn Quốc Huy', 'K44-03', 'CNPM 03'),
('B18013', N'Võ Đoàn Gia Huy', 'K44-03', 'CNPM 03'),
('B18014', N'Vũ Thị Bích Huyền', 'K44-03', 'CNPM 03'),
('B18015', N'Hồ Việt Hưng', 'K44-03', 'CNPM 03');

INSERT INTO Courses (MaMon, TenMon) VALUES
('CT101', N'Lập trình căn bản'),
('CT103', N'Cấu trúc dữ liệu'),
('CT251', N'Phát triển ứng dụng trên Windows');

INSERT INTO Instructors (MaCB, TenCB, MatKhau) VALUES
('001', N'Nguyễn Văn Cường', '123'),
('002', N'Huỳnh Minh Phương', '123'),
('003', N'Thái Cẩm Nhung', '123');

INSERT INTO Teaching (MaCB, MaMon, MaLop) VALUES
('001', 'CT101', 'K44-01'),
('001', 'CT101', 'K44-02'),
('001', 'CT103', 'K44-01'),
('001', 'CT103', 'K44-03'),
('002', 'CT101', 'K44-03'),
('002', 'CT103', 'K44-02'),
('003', 'CT251', 'K44-01'),
('003', 'CT251', 'K44-02'),
('003', 'CT251', 'K44-03');

INSERT INTO Grades (MaCB, MaMon, DiemThi) VALUES
('001', 'CT101', 8.5),
('001', 'CT103', 8.3),
('001', 'CT251', 9.0),
('002', 'CT101', 8.5),
('002', 'CT103', 8.3),
('002', 'CT251', 9.0),
('003', 'CT101', 8.5),
('003', 'CT103', 8.3),
('003', 'CT251', 9.0);




SELECT * FROM Grades;

DELETE FROM Grades;
DELETE FROM Teaching;
DELETE FROM Instructors;
DELETE FROM Courses;
DELETE FROM Students;

SELECT c.MaMon, c.TenMon FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB = '003' GROUP BY c.MaMon, c.TenMon;

SELECT g.DiemThi FROM Instructors i JOIN Grades g ON g.MaCB = i.MaCB JOIN Courses c ON c.MaMon = g.MaMon WHERE i.MaCB = '003' AND c.MaMon = 'CT101';

SELECT c.MaMon, t.MaLop, s.TenLop, s.MSSV, s.HoTen FROM Instructors i JOIN Teaching t ON i.MaCB = t.MaCB JOIN Students s ON s.MaLop = t.MaLop JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB = '001' AND c.MaMon = 'CT101'; 
