CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	Picture VARBINARY(MAX),
	LastLoginTime DATETIME, 
	IsDeleted BIT DEFAULT 0
)

INSERT INTO Users (Username, [Password], Picture) VALUES
('Asenn', 'asdfg', NULL),
('Boriss', 'asdfg', NULL),
('Vasill', 'asdfg', NULL),
('Georgii', 'asdfg', NULL),
('Dimityrr', 'asdfg', NULL)