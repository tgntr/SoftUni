SELECT
	r.OpenDate,
	r.Description,
	u.Email AS 'Reporter Email'
FROM Reports AS r
JOIN Categories AS c ON r.CategoryId = c.Id
JOIN Departments AS d ON c.DepartmentId = d.Id
JOIN Users AS u ON r.UserId = u.id
WHERE
	r.CloseDate IS NULL AND
	LEN(r.Description) > 20 AND
	CHARINDEX('str', r.Description) > 0 AND
	d.Name IN ('Infrastructure', 'Emergency', 'Roads Maintenance')
ORDER BY r.OpenDate, u.Email, u.Id
