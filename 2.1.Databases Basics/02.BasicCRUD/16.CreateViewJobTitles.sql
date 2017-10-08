CREATE VIEW v_EmployeeNameJobTitle 
AS
SELECT FirstName + ' ' + ISNULL (MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle as [Job Title]
FROM Employees
