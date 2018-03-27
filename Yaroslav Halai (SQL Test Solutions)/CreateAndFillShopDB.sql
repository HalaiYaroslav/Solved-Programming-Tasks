--Створення бази даних, таблиць та наповнення таблиць даними
CREATE DATABASE ShopDB
ON
(
	NAME = 'ShopDB',
	FILENAME = 'C:\ShopDB.mdf',
	SIZE = 25MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 25MB
)
LOG ON 
(
	NAME = 'LogShopDB',
	FILENAME = 'D:\LogShopDB.ldf',
	SIZE = 10MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 10MB
)
GO

USE ShopDB;
GO

--Таблиця "Довідник товарів"
CREATE TABLE TOV
(
	KTOV INT PRIMARY KEY IDENTITY(101, 1), --seed = start from 101, increment = 1
	NTOV CHAR(60) NOT NULL,
	SORT CHAR(12) NOT NULL
)

INSERT TOV
VALUES
('Beer','Light'),
('Beer','Dark'),
('Chips','With paprika')
GO

--Тблиця "Документи руху товару. Заголовок"
CREATE TABLE DMZ
(
	NDM INT PRIMARY KEY,
	DDM DATE NOT NULL,
	PR INT NOT NULL
	CHECK(PR IN (1, 2))
)

INSERT DMZ
VALUES
(2, '05/01/2014', 1),
(3, '05/01/2014', 2),
(5, '05/02/2014', 2)
GO

--Тблиця "Документи руху товару. Рядки"
CREATE TABLE DMS
(
	KTOV INT FOREIGN KEY REFERENCES TOV(KTOV) NOT NULL,
	NDM INT FOREIGN KEY REFERENCES DMZ(NDM) NOT NULL,
	KOL DECIMAL(13,2) NOT NULL,
	CENA DECIMAL(13,2) NOT NULL,
	SORT CHAR(12) NOT NULL,
	PRIMARY KEY(KTOV, NDM)	
)

INSERT DMS
VALUES
(101, 2, 100, 8.00, 'Light'),
(102, 2, 80, 9.50, 'Dark'),
(103, 2, 50, 6.50, 'With paprika'),
(101, 3, 1, 10.00, 'Light'),
(102, 3, 1, 8.50, 'Dark'),
(103, 3, 2, 10.00, 'With paprika'),
(101, 5, 1, 11.50, 'Light'),
(102, 5, 2, 10.50, 'Dark'),
(103, 5, 1, 8.60, 'With paprika')
GO