SELECT 
c.CountryCode,
p.MountainRange,
p.PeakName,
p.Elevation
FROM (
	SELECT p.PeakName,
	m.MountainRange,
	m.Id,
	p.Elevation
	FROM Peaks as p
	INNER JOIN Mountains as m
	ON m.Id = p.MountainId
	WHERE p.Elevation > 2835
) as p
INNER JOIN MountainsCountries as c
ON p.Id = c.MountainId
WHERE c.CountryCode = 'BG'
ORDER BY p.Elevation DESC

