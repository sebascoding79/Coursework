IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Coursework')
BEGIN
CREATE DATABASE Coursework;
END

USE Coursework;

-- We need tables for Courses
-- convention is lowercase for table and column names
-- id is the primary key, don't change that

CREATE TABLE courses 
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    cid VARCHAR(15),
    cname VARCHAR(100),
    year INT,
    semester VARCHAR(10),
    grade VARCHAR(3)
);