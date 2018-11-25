SELECT
	c.Name,
	ISNULL(COUNT(h.Id), 0) AS Hotels
FROM Cities AS c
LEFT JOIN Hotels AS h ON h.CityId = c.Id
GROUP BY c.Name
ORDER BY Hotels DESC, Name