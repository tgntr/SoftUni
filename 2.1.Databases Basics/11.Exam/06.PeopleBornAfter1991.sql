SELECT
	(CASE
		WHEN MiddleName IS NULL THEN CONCAT(FirstName, ' ', LastName)
		ELSE CONCAT(FirstName, ' ', MiddleName, ' ', LastName)
	END) AS FullName,
	YEAR(BirthDate) AS BirthYear
FROM Accounts
WHERE YEAR(BirthDate) > 1991
ORDER BY BirthYear DESC, FirstName
