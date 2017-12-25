SELECT CONCAT(e.FirstName, ' ', e.LastName) AS Name,
COUNT(DISTINCT r.UserId) AS UsersNumber
FROM Employees AS e
LEFT JOIN Reports AS r ON r.EmployeeId = e.Id
GROUP BY e.FirstName, e.LastName
ORDER BY UsersNumber DESC, Name