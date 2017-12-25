SELECT 
	m.FirstName + ' ' + m.LastName AS Mechanic,
	COUNT(j.JobId) AS 'Jobs'
FROM Jobs AS j
JOIN Mechanics AS m ON m.MechanicId = j.MechanicId
WHERE j.Status <> 'Finished'
GROUP BY m.FirstName, m.LastName
HAVING Count(j.JobId) > 1
ORDER BY 'Jobs' DESC

