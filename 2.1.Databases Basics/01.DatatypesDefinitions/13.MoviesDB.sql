CREATE DATABASE Movies

CREATE Table Directors (
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (DirectorName) VALUES
('Fellini'),
('JJ Abrams'),
('Tarantino'),
('Richie'),
('Hitchcock')

CREATE Table Genres (
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Genres (GenreName) VALUES
('Horror'),
('Drama'),
('Comedy'),
('Crime'),
('SciFi')

CREATE Table Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories (CategoryName) VALUES
('Blockbuster'),
('Low Budget'),
('Classic'),
('New'),
('Top 100')

CREATE Table Movies (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear INT NOT NULL,
	[Length] TIME(0) NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating INT,
	Notes NVARCHAR(MAX)
)

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId) VALUES
('Asdf', 1, 1994, '02:21', 1, 1),
('Asdf', 2, 1994, '01:21', 2, 2),
('Asdf', 3, 1994, '02:21', 3, 3),
('Asdf', 4, 1994, '02:21', 4, 4),
('Asdf', 5, 1994, '02:21', 5, 5)

