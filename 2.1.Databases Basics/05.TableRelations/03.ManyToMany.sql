CREATE TABLE Students (
	Id INT IDENTITY,
	Name VARCHAR(100)
)

CREATE TABLE Exams (
	Id INT IDENTITY(101, 1),
	Name VARCHAR(100)
)

CREATE TABLE StudentsExams (
	StudentID INT NOT NULL,
	ExamID INT NOT NULL
)

INSERT INTO Students 
VALUES ('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams
VALUES ('SpringMVC'),
('Neo4j'),
('Oracle 11g')

INSERT INTO StudentsExams
VALUES (1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)


ALTER TABLE Students
ADD CONSTRAINT PK_Students
PRIMARY KEY (Id)

ALTER TABLE Exams
ADD CONSTRAINT PK_Exams
PRIMARY KEY (Id)

ALTER TABLE StudentsExams
ADD CONSTRAINT PK_StudentsExams
PRIMARY KEY (StudentId, ExamId)

ALTER TABLE StudentsExams
ADD CONSTRAINT FK_StudentsExams_Students
FOREIGN KEY (StudentId)
REFERENCES Students(Id)

ALTER TABLE StudentsExams
ADD CONSTRAINT FK_StudentsExams_Exams
FOREIGN KEY (ExamId)
REFERENCES Exams(Id)

