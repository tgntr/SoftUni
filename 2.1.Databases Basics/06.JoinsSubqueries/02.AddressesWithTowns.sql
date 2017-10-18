SELECT TOP (50) e.FirstName, 
e.LastName, 
a.Town, 
a.AddressText
FROM Employees AS e
JOIN (
	SELECT a.AddressID, 
	a.AddressText, 
	t.Name as Town 
	FROM Addresses as a
	JOIN Towns as t
	ON a.TownID = t.TownID
) AS a
ON e.AddressID = a.AddressID
ORDER BY e.FirstName, e.LastName