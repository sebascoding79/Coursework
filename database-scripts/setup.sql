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
    cname VARCHAR(15),
    cdescription VARCHAR(100),
    year INT,
    semesterid INT,
    gradeid INT
);

CREATE TABLE semester
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    semester VARCHAR(10)
);

CREATE TABLE grade
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    grade VARCHAR(2)
);

CREATE TABLE practice1
(
    id INT PRIMARY KEY,
    description VARCHAR(15)
);

CREATE TABLE practice2
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    description VARCHAR(10)
);