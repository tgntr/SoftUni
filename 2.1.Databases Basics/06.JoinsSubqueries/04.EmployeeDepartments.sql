SELECT TOP (5) e.EmployeeID,
e.FirstName,
e.Salary,
d.Name
FROM Employees as e
INNER JOIN Departments as d
ON d.DepartmentID = e.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.DepartmentID