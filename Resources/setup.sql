USE master;

-- Drop previous data
IF EXISTS (SELECT name FROM sys.sql_logins WHERE name = 'LocaLibrary')
BEGIN
    DROP LOGIN LocaLibrary;
END;
DROP DATABASE IF EXISTS LocaLibrary;
DROP USER IF EXISTS LocaLibrary;
PRINT 'Dropped previous data';

-- Create login & database (need GO)
CREATE LOGIN LocaLibrary WITH PASSWORD = '123456', CHECK_EXPIRATION = OFF;
CREATE DATABASE LocaLibrary;
GO
PRINT 'Created login & database';

-- Create user (in database)
USE LocaLibrary;
CREATE USER LocaLibrary FOR LOGIN LocaLibrary;
PRINT 'Created user';

-- Set user as database owner
EXEC sp_addrolemember 'db_owner', 'LocaLibrary';
PRINT 'Set user as database owner';

USE master;
