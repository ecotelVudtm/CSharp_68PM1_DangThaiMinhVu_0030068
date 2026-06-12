-- 1. Tạo bảng Lớp Học
CREATE TABLE Classrooms (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClassCode NVARCHAR(50) UNIQUE NOT NULL, -- Mã lớp
    ClassName NVARCHAR(255) NOT NULL,       -- Tên lớp
    Notes NVARCHAR(MAX),                    -- Ghi chú (Vẫn giữ trong DB dù ẩn trên UI)
    IsDelete BIT DEFAULT 0 NOT NULL         -- Xóa mềm
);

-- 2. Tạo bảng Sinh Viên
CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentCode NVARCHAR(50) UNIQUE NOT NULL, -- Mã sinh viên
    FullName NVARCHAR(255) NOT NULL,          -- Họ và tên
    BirthDate DATE,                           -- Ngày sinh
    Gender NVARCHAR(10),                      -- Giới tính (Nam/Nữ)
    ClassId INT NOT NULL,                     -- Khóa ngoại liên kết với lớp học
    Notes NVARCHAR(MAX),                      -- Ghi chú
    IsDelete BIT DEFAULT 0 NOT NULL,          -- Xóa mềm
    FOREIGN KEY (ClassId) REFERENCES Classrooms(Id)
);

-- Cập nhật bảng hiện tại (Dành cho việc migrate)
ALTER TABLE Classrooms ADD IsDelete BIT DEFAULT 0 NOT NULL;
ALTER TABLE Students ADD IsDelete BIT DEFAULT 0 NOT NULL;

-- 3. Thêm dữ liệu các lớp học mẫu
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68PM1')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68PM1', N'Công nghệ Phần mềm 1', N'Khóa 68');
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68PM2')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68PM2', N'Công nghệ Phần mềm 2', N'Khóa 68');
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68PM3')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68PM3', N'Công nghệ Phần mềm 3', N'Khóa 68');
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68PM4')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68PM4', N'Công nghệ Phần mềm 4', N'Khóa 68');
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68MHT1')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68MHT1', N'Mạng máy tính 1', N'Khóa 68');
IF NOT EXISTS (SELECT 1 FROM Classrooms WHERE ClassCode = '68MHT2')
    INSERT INTO Classrooms (ClassCode, ClassName, Notes) VALUES ('68MHT2', N'Mạng máy tính 2', N'Khóa 68');

-- 4. Thêm 50 sinh viên mẫu
DECLARE @C1 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68PM1');
DECLARE @C2 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68PM2');
DECLARE @C3 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68PM3');
DECLARE @C4 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68PM4');
DECLARE @C5 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68MHT1');
DECLARE @C6 INT = (SELECT Id FROM Classrooms WHERE ClassCode = '68MHT2');

-- Lớp 68PM1
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV001') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV001', N'Nguyễn Văn An', '2005-02-12', N'Nam', @C1, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV002') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV002', N'Trần Thị Bình', '2005-05-15', N'Nữ', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV003') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV003', N'Lê Hoàng Cường', '2005-09-20', N'Nam', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV004') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV004', N'Phạm Minh Đức', '2005-12-01', N'Nam', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV005') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV005', N'Hoàng Thanh Hải', '2005-03-14', N'Nam', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV006') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV006', N'Vũ Ngọc Khanh', '2005-07-08', N'Nữ', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV007') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV007', N'Bùi Tiến Lâm', '2005-11-22', N'Nam', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV008') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV008', N'Đỗ Phương Nam', '2005-08-30', N'Nam', @C1, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV009') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV009', N'Ngô Quốc Oai', '2005-01-25', N'Nam', @C1, N'');

-- Lớp 68PM2
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV010') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV010', N'Lý Khánh Phong', '2005-06-19', N'Nam', @C2, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV011') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV011', N'Dương Minh Quân', '2005-04-11', N'Nam', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV012') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV012', N'Phan Thanh Sơn', '2005-10-05', N'Nam', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV013') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV013', N'Đặng Quốc Thịnh', '2005-02-28', N'Nam', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV014') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV014', N'Lâm Minh Uy', '2005-07-17', N'Nam', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV015') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV015', N'Mai Hồng Vân', '2005-12-25', N'Nữ', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV016') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV016', N'Trịnh Xuân Việt', '2005-03-09', N'Nam', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV017') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV017', N'Đoàn Bảo Vy', '2005-09-14', N'Nữ', @C2, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV018') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV018', N'Phung Gia Huy', '2005-11-03', N'Nam', @C2, N'');

-- Lớp 68PM3
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV019') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV019', N'Tạ Quang Khải', '2005-05-30', N'Nam', @C3, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV020') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV020', N'Đinh Tuấn Kiệt', '2005-08-12', N'Nam', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV021') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV021', N'Lương Tuấn Tú', '2005-01-07', N'Nam', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV022') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV022', N'Hồ Hữu Phước', '2005-04-24', N'Nam', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV023') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV023', N'Cao Thùy Linh', '2005-07-19', N'Nữ', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV024') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV024', N'Giang Tuấn Anh', '2005-10-31', N'Nam', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV025') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV025', N'Trương Mỹ Dung', '2005-03-18', N'Nữ', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV026') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV026', N'Diệp Gia Bảo', '2005-06-22', N'Nam', @C3, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV027') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV027', N'Quách Thế Anh', '2005-12-14', N'Nam', @C3, N'');

-- Lớp 68PM4
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV028') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV028', N'Thái Duy Hưng', '2005-02-18', N'Nam', @C4, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV029') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV029', N'Vương Bảo Trâm', '2005-09-09', N'Nữ', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV030') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV030', N'Tống Quang Vinh', '2005-11-15', N'Nam', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV031') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV031', N'Phùng Tuấn Nghĩa', '2005-05-05', N'Nam', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV032') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV032', N'Hà Thị Mai', '2005-07-28', N'Nữ', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV033') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV033', N'Đào Thế Vũ', '2005-10-12', N'Nam', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV034') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV034', N'Nghiêm Xuân Trường', '2005-01-20', N'Nam', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV035') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV035', N'Thạch Minh Khoa', '2005-04-03', N'Nam', @C4, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV036') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV036', N'Triệu Lệ Thu', '2005-08-25', N'Nữ', @C4, N'');

-- Lớp 68MHT1
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV037') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV037', N'Nguyễn Hoàng Long', '2005-06-30', N'Nam', @C5, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV038') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV038', N'Vũ Thành Nam', '2005-03-24', N'Nam', @C5, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV039') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV039', N'Đặng Tuấn Đạt', '2005-11-12', N'Nam', @C5, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV040') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV040', N'Lê Minh Triết', '2005-05-18', N'Nam', @C5, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV041') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV041', N'Hoàng Bảo Yến', '2005-09-22', N'Nữ', @C5, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV042') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV042', N'Phạm Tiến Dũng', '2005-02-14', N'Nam', @C5, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV043') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV043', N'Đoàn Khánh Linh', '2005-07-07', N'Nữ', @C5, N'');

-- Lớp 68MHT2
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV044') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV044', N'Nguyễn Hữu Phước', '2005-01-28', N'Nam', @C6, N'Lớp trưởng');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV045') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV045', N'Bùi Quang Đạo', '2005-04-16', N'Nam', @C6, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV046') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV046', N'Trần Ngọc Hân', '2005-08-05', N'Nữ', @C6, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV047') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV047', N'Ngô Hữu Hùng', '2005-12-30', N'Nam', @C6, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV048') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV048', N'Lê Minh Thư', '2005-03-02', N'Nữ', @C6, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV049') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV049', N'Phạm Đức Thắng', '2005-06-11', N'Nam', @C6, N'');
IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentCode = 'SV050') INSERT INTO Students (StudentCode, FullName, BirthDate, Gender, ClassId, Notes) VALUES ('SV050', N'Vũ Khánh Hà', '2005-10-21', N'Nữ', @C6, N'');