CREATE TABLE People (
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL(5, 2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)


INSERT INTO People (FullName, Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('Asen Asenov', NULL, 1.902, 77.11, 'm', '1993-2-12', NULL),
('Boris Borisov', NULL, 1.902, 77.11, 'm', '1993-2-12', NULL),
('Vasil Vasilev', NULL, 1.902, 77.11, 'm', '1993-2-12', NULL),
('Georgi Georgiev', NULL, 1.902, 77.11, 'm', '1993-2-12', NULL),
('Dimityr Dimitrov', NULL, 1.902, 77.11, 'm', '1993-2-12', NULL)
