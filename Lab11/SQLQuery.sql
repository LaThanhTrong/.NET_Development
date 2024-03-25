CREATE DATABASE QLSV;
USE QLSV;

DROP TABLE Grades;
DROP TABLE Teaching;
DROP TABLE Instructors;
DROP TABLE Courses;
DROP TABLE Students;

sp_changedbowner admin;

CREATE TABLE CLASS(
	MaLop VARCHAR(10) primary key,
    TenLop NVARCHAR(50)
	);

CREATE TABLE Students (
    MSSV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    MaLop VARCHAR(10)  REFERENCES CLASS(MaLop) ,
    
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
	FOREIGN KEY (Malop) REFERENCES CLASS(MaLop),
);

CREATE TABLE Grades (
    MSSV VARCHAR(10),
    MaMon VARCHAR(10),
    DiemThi FLOAT,
	PRIMARY KEY (MSSV, MaMon, DiemThi),
    FOREIGN KEY (MaMon) REFERENCES Courses(MaMon),
	FOREIGN KEY (MSSV) REFERENCES Students(MSSV),
);

INSERT INTO CLASS VALUES
(N'K44-01', N'CNPM 01'),
(N'K44-02', N'CNPM 02'),
(N'K44-03', N'CNPM 03');


INSERT INTO Students (MSSV, HoTen, MaLop) VALUES
('B18001', N'Phạm Thị Bảo Nhiên', 'K44-01'),
('B18002', N'Nguyễn Văn An', 'K44-01'),
('B18003', N'Lê Hoài Anh', 'K44-01'),
('B18004', N'Nguyễn Lâm Hoàng Anh', 'K44-01'),
('B18005', N'Lê Minh Bằng', 'K44-01'),
('B18006', N'Vương Thừa Chấn', 'K44-02'),
('B18007', N'Cao Công Danh', 'K44-02'),
('B18008', N'Trịnh Lê Long Đức', 'K44-02'),
('B18009', N'Dương Lê Minh Hậu', 'K44-02'),
('B18010', N'Nguyễn Vũ Hoàng', 'K44-02'),
('B18011', N'Nguyễn Hoàng Thái Học', 'K44-03'),
('B18012', N'Nguyễn Quốc Huy', 'K44-03'),
('B18013', N'Võ Đoàn Gia Huy', 'K44-03'),
('B18014', N'Vũ Thị Bích Huyền', 'K44-03'),
('B18015', N'Hồ Việt Hưng', 'K44-03');


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

-- Insert random grades for each student in each course they are enrolled in with 9 mark
INSERT INTO Grades (MSSV, MaMon, DiemThi)
SELECT
    s.MSSV,
    t.MaMon,
    9 
FROM
    Students s
    JOIN Teaching t ON s.MaLop = t.MaLop
    JOIN Courses c ON t.MaMon = c.MaMon;



SELECT * FROM Grades;
SELECT * FROM Courses;
SELECT * FROM CLASS;
SELECT * FROM Teaching;
SELECT * FROM Instructors;

SELECT c.MaMon, c.TenMon FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB='001' GROUP BY c.MaMon, c.TenMon;
SELECT cls.MaLop, cls.TenLop FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon JOIN CLASS cls ON cls.MaLop = t.MaLop WHERE i.MaCB='001' GROUP BY cls.MaLop, cls.TenLop;
SELECT st.MSSV as MSSV, st.HoTen as Name, g.DiemThi as Grade FROM Students st JOIN Grades g ON g.MSSV = st.MSSV WHERE st.MaLop = 'K44-01' AND g.MaMon = 'CT103';


DELETE FROM Grades;
DELETE FROM Teaching;
DELETE FROM Instructors;
DELETE FROM Courses;
DELETE FROM Students;
