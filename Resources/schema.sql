USE LocaLibrary;

-- Drop tables with foreign keys (reverse order)
DROP TABLE IF EXISTS BookBorrow;
DROP TABLE IF EXISTS BookCategory;
PRINT 'Dropped tables with foreign keys';

-- Drop tables without foreign keys (reverse order)
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Member;
DROP TABLE IF EXISTS Book;
DROP TABLE IF EXISTS Category;
PRINT 'Dropped tables without foreign keys';

-- Create tables without foreign keys
CREATE TABLE Category (
    Id INT IDENTITY(1, 1)
        CONSTRAINT Category_Id_Pk PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
)
CREATE TABLE Book (
    Id INT IDENTITY(1, 1)
        CONSTRAINT Book_Id_Pk PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255) NOT NULL,
    Publisher NVARCHAR(255) NOT NULL,
    PublishYear SMALLINT NOT NULL
        CONSTRAINT Book_PublishYear_Min CHECK (PublishYear >= 0),
    Language NVARCHAR(255) NOT NULL,
    Price MONEY NOT NULL
        CONSTRAINT Book_Price_Min CHECK (Price >= 0),
)
CREATE TABLE Member (
    Id INT IDENTITY(1, 1)
        CONSTRAINT Member_Id_Pk PRIMARY KEY,
    Code VARCHAR(255) NOT NULL
        CONSTRAINT Member_Code_Unique UNIQUE,
    FullName NVARCHAR(255) NOT NULL,
    ClassName VARCHAR(255) NOT NULL,
    StartYear SMALLINT NOT NULL
        CONSTRAINT Member_StartYear_Min CHECK (StartYear >= 0),
)
CREATE TABLE Employee (
    Id INT IDENTITY(1, 1)
        CONSTRAINT Employee_Id_Pk PRIMARY KEY,
    Email VARCHAR(255) NOT NULL
        CONSTRAINT Employee_Email_Unique UNIQUE,
    PasswordHash VARBINARY(MAX) NOT NULL,
    FullName NVARCHAR(255) NOT NULL,
    IsAdmin BIT NOT NULL
        CONSTRAINT Employee_IsAdmin_Default DEFAULT 0,
    IsLocked BIT NOT NULL
        CONSTRAINT Employee_IsLocked_Default DEFAULT 0,
)
PRINT 'Created tables without foreign keys';

-- Create tables with foreign keys
CREATE TABLE BookCategory (
    CategoryId INT NOT NULL
        CONSTRAINT BookCategory_CategoryId_Fk
        FOREIGN KEY (CategoryId) REFERENCES Category(Id),
    BookId INT NOT NULL
        CONSTRAINT BookCategory_BookId_Fk
        FOREIGN KEY (BookId) REFERENCES Book(Id),
)
CREATE TABLE BookBorrow (
    Id INT IDENTITY(1, 1)
        CONSTRAINT BookBorrow_Id_Pk PRIMARY KEY (Id),
    BookId INT NOT NULL
        CONSTRAINT BookBorrow_BookId_Fk
        FOREIGN KEY (BookId) REFERENCES Book(Id),
    MemberId INT NOT NULL,
        CONSTRAINT BookBorrow_MemberId_Fk
        FOREIGN KEY (MemberId) REFERENCES Member(Id),
    EmployeeId INT NOT NULL,
        CONSTRAINT BookBorrow_EmployeeId_Fk
        FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
    BorrowDate DATE NOT NULL
        CONSTRAINT BookBorrow_BorrowDate_Default DEFAULT GETDATE(),
    ExpectedReturnDate DATE NOT NULL,
    ReturnDate DATE,
    IsDone BIT NOT NULL
        CONSTRAINT BookBorrow_IsDone_Default DEFAULT 0,
)
PRINT 'Created tables with foreign keys';

USE master;
