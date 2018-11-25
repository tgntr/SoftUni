INSERT INTO Accounts (FirstName, MiddleName, LastName, CityId, BirthDate, Email)
VALUES
('John',	'Smith',	'Smith',	34,	CONVERT(Date, '1975-07-21'),	'j_smith@gmail.com'),
('Gosho',	NULL,	'Petrov',	11,	CONVERT(DATE, '1978-05-16'),	'g_petrov@gmail.com'),
('Ivan',	'Petrovich',	'Pavlov',	59,	CONVERT(DATE, '1849-09-26'),	'i_pavlov@softuni.bg'),
('Friedrich',	'Wilhelm',	'Nietzsche',	2,	CONVERT(DATE, '1844-10-15'),	'f_nietzsche@softuni.bg')


INSERT INTO Trips (RoomId, BookDate, ArrivalDate, ReturnDate, CancelDate)
VALUES
(101,	CONVERT(DATE, '2015-04-12'),	CONVERT(DATE, '2015-04-14'),	CONVERT(DATE, '2015-04-20'),	CONVERT(DATE, '2015-02-02')),
(102,	CONVERT(DATE, '2015-07-07'),	CONVERT(DATE, '2015-07-15'),	CONVERT(DATE, '2015-07-22'),	CONVERT(DATE, '2015-04-29')),
(103,	CONVERT(DATE, '2013-07-17'),	CONVERT(DATE, '2013-07-23'),	CONVERT(DATE, '2013-07-24'),	NULL),
(104,	CONVERT(DATE, '2012-03-17'),	CONVERT(DATE, '2012-03-31'),	CONVERT(DATE, '2012-04-01'),	CONVERT(DATE, '2012-01-10')),
(109,	CONVERT(DATE, '2017-08-07'),	CONVERT(DATE, '2017-08-28'),	CONVERT(DATE, '2017-08-29'),	NULL)
