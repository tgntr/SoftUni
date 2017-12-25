SELECT DISTINCT u.Username FROM Users AS u
JOIN Reports AS r ON r.UserId = u.Id
JOIN Categories AS c ON r.CategoryId = c.Id
WHERE
	LEFT(u.Username, 1) = CAST(c.Id AS VARCHAR(2)) OR
	RIGHT(u.Username, 1) = CAST(c.Id AS VARCHAR(2))