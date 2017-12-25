WITH distros AS (
	SELECT d.Name, 
	ISNULL(COUNT(*), 0) AS Ingredients, 
	co.name AS Country, 
	RANK() OVER (PARTITION BY co.Name ORDER BY COUNT(i.Id) DESC) AS [Rank] 
	FROM Distributors AS d
	LEFT JOIN  Ingredients AS i ON d.Id = i.DistributorId
	JOIN Countries AS co ON d.CountryId = co.Id
	GROUP BY d.Name, co.Name
)
SELECT Country AS CountryName, Name AS DistributorName
FROM distros
WHERE [Rank] = 1
ORDER BY CountryName