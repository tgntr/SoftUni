SELECT TOP (5) e.EmployeeID, e.JobTitle, a.AddressId, a.AddressText
FROM Employees as e
INNER JOIN Addresses as a
ON e.AddressiD = a.AddressID
ORDER BY a.AddressId