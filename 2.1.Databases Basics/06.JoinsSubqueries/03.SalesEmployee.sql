SELECT e.EmployeeID, 
e.FirstName,
e.LastName, 
d.Name
FROM Employees as e
INNER JOIN Departments as d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY EmployeeID