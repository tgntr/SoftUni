CREATE PROC usp_EmployeesBySalaryLevel  (@Level VARCHAR(50))
AS
	SELECT e.FirstName, 
	e.LastName
	FROM Employees AS e
	INNER JOIN (
		SELECT es.EmployeeID,(
			CASE
			WHEN es.Salary > 50000 THEN 'High'
			WHEN es.Salary >= 30000 THEN 'Average'
			ELSE 'Low'
			END
		) AS Level
		FROM Employees AS es
	) AS es
	ON es.EmployeeID = e.EmployeeID
	WHERE es.Level = @Level
