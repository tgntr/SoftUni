SELECT c.FirstName, c.Age, c.PhoneNumber
FROM Customers AS c
JOIN Countries AS co ON co.Id = c.CountryId
WHERE (Age >= 21 AND CHARINDEX('an', FirstName) > 0)
OR (co.Name <> 'Greece' AND RIGHT(c.PhoneNumber, 2) = '38')
ORDER BY c.FirstName, c.Age DESC

