SELECT e.FirstName,
e.LastName, 
e.HireDate, 
d.Name as DeptName
FROM Employees as e
INNER JOIN Departments as d
ON e.DepartmentID = d.DepartmentID
WHERE DATEPART(year, e.HireDate) >= 1999
AND d.Name IN ('Finance', 'Sales')
ORDER BY e.HireDate