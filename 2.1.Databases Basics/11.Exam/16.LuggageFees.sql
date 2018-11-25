SELECT
	t.Id,
	SUM(att.Luggage) AS 'Luggage',
	CONCAT('$', CAST((CASE WHEN SUM(att.Luggage) > 5 THEN SUM(att.Luggage) * 5 ELSE 0 END) AS VARCHAR(10))) AS Fee
FROM AccountsTrips AS att
JOIN Trips AS t ON t.Id = att.TripId
WHERE Luggage > 0
GROUP BY t.Id
ORDER BY 'Luggage' DESC