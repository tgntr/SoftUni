CREATE DATABASE CarRental

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate INT,
	WeeklyRate INT,
	MonthlyRate INT,
	WeekendRate INT
)

INSERT INTO Categories (CategoryName) VALUES
('Low'),
('Mid'),
('High')

CREATE TABLE Cars (
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber CHAR(8) NOT NULL,
	Manufacturer NVARCHAR(50) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	CarYear DATE NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors INT,
	PICTURE VARBINARY(MAX),
	Condition NVARCHAR(50),
	Available BIT DEFAULT 1
)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId) VALUES
('RR1234RR', 'Skoda', 'Xantia', '1998', 1),
('RR1235RR', 'Toyota', 'Yaris', '2003', 2),
('RR1236RR', 'Mercedes', 'S Class', '2012-01-01', 3)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName) VALUES
('Asen', 'Asenov'),
('Asen', 'Petrov'),
('Asen', 'Miroslavov')

CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenseNumber CHAR(10),
	FullName NVARCHAR(50) NOT NULL,
	Address NVARCHAR(200),
	City NVARCHAR(50),
	ZIP CHAR(4),
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers (DriverLicenseNumber, FullName) VALUES
('1234567890', 'Simeon Simeonov'),
('1234567891', 'Simeon Petrov'),
('1234567892', 'Simeon Asenov')


CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel INT,
	KmStart INT,
	KMEnd INT,
	KMTotal as KMEnd - KMStart,
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied INT,
	TaxRate INT,
	OrderStatus VARCHAR(20),
	Notes NVARCHAR(MAX)
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3)

