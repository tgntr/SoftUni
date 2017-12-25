SELECT FirstName + ' ' + LastName AS Available 
FROM Mechanics
WHERE MechanicId NOT IN (
	SELECT MechanicId 
	FROM Jobs
	WHERE MechanicId IS NOT NULL AND Status <> 'Finished'
)



SELECT m.FirstName + ' ' + m.LastName AS Available 
FROM Mechanics AS m
FULL JOIN (SELECT * FROM Jobs WHERE Status <> 'Finished') AS j ON j.MechanicId = m.MechanicId
GROUP BY m.MechanicId, m.FirstName, m.LastName
HAVING Count(j.JobId) = 0
ORDER BY m.MechanicId
