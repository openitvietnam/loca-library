USE LocaLibrary;

-- Empty tables with foreign keys (reverse order)
DELETE FROM BookBorrow;
DELETE FROM BookCategory;
PRINT 'Empty tables with foreign keys';

-- Empty tables without foreign keys (reverse order)
DELETE FROM Employee;
DELETE FROM Member;
DELETE FROM Book;
DELETE FROM Category;
PRINT 'Empty tables without foreign keys';

-- Reset id for tables with foreign keys (reverse order)
DBCC CHECKIDENT ('BookBorrow', RESEED, 0);
-- DBCC CHECKIDENT ('BookCategory', RESEED, 1); -- don't have id
PRINT 'Reset id for tables with foreign keys';

-- Reset id for tables without foreign keys (reverse order)
DBCC CHECKIDENT ('Employee', RESEED, 0);
DBCC CHECKIDENT ('Member', RESEED, 0);
DBCC CHECKIDENT ('Book', RESEED, 0);
DBCC CHECKIDENT ('Category', RESEED, 0);
PRINT 'Reset id for tables without foreign keys';

-- Insert Admin employee
INSERT INTO Employee(Email, PasswordHash, FullName)
    VALUES ('admin@gmail.com', PWDENCRYPT(N'123456'), N'Admin');
PRINT 'Inserted employees';

USE master;
