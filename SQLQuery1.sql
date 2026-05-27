-- 1. Tạo bảng Lớp Học
CREATE TABLE Classrooms (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ClassCode NVARCHAR(50) UNIQUE NOT NULL, -- Mã lớp
    ClassName NVARCHAR(255) NOT NULL,       -- Tên lớp
    Notes NVARCHAR(MAX)                     -- Ghi chú (Vẫn giữ trong DB dù ẩn trên UI)
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
    FOREIGN KEY (ClassId) REFERENCES Classrooms(Id)
);

-- 3. Thêm thử một dữ liệu mẫu (Dummy data) để lát test
INSERT INTO Classrooms (ClassCode, ClassName, Notes) 
VALUES ('68PM1', N'Phần mềm 1 - K68', N'Lớp trưởng: Nguyễn Văn A');