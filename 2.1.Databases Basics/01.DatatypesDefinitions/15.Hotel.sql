CREATE DATABASE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees(FirstName, LastName) VALUES
('Petyr', 'Petrov'),
('Asen', 'Petrov'),
('Vasil', 'Petrov')

CREATE TABLE Customers (
	AccountNumber INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber CHAR(10),
	EmergencyName NVARCHAR(50),
	EmergencyNumber CHAR(10),
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers(FirstName, LastName) VALUES
('Asen', 'Petrov'),
('Vlado', 'Petrov'),
('Misho', 'Petrov')



CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(10) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus (RoomStatus) VALUES
('Free'),
('Busy'),
('Reserved')

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(10) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomTypes (RoomType) VALUES
('Compact'),
('Luxury'),
('Apartment')

CREATE TABLE BedTypes (
	BedType NVARCHAR(10) PRIMARY KEY NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO BedTypes (BedType) VALUES
('Single'),
('Double'),
('Bedroom')

CREATE TABLE Rooms (
	RoomNumber INT PRIMARY KEY IDENTITY, 
	RoomType NVARCHAR(10) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(10) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL (15, 2) NOT NULL,
	RoomStatus NVARCHAR(10) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes NVARCHAR(MAX)
)

INSERT INTO Rooms (RoomType, BedType, Rate, RoomStatus) VALUES
('Compact', 'Single', 40,'Free'),
('Luxury', 'Double', 50, 'Reserved'),
('Apartment', 'Bedroom', 60, 'Busy')

CREATE TABLE Payments (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATE DEFAULT GETDATE(),
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays as DATEDIFF ( day , FirstDateOccupied , LastDateOccupied ) ,
	AmountCharged AS TotalDays * (SELECT Rate FROM Rooms WHERE AccountNumber =  AccountNumber  Rooms )
	TaxRate DECIMAL(2, 1) DEFAULT 0.2,
	TaxAmount AS TaxRate * AmountCharged,
	PaymentTotal AS TaxAmount + AmountCharged,
	Notes NVARCHAR(MAX)
)

INSERT INTO Payments (EmployeeId, AccountNumber) VALUES
(1, 1),
(2, 2),
(3, 3) 

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY, 
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATE DEFAULT GETDATE(),
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL(15, 2),
	PhoneCharge DECIMAL(15, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Occupancies(EmployeeId, AccountNumber, RoomNumber) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3)



