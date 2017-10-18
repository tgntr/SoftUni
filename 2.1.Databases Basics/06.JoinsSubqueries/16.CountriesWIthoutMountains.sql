SELECT COUNT(*) AS CountryCode
FROM Countries as c
LEFT JOIN MountainsCountries as m
ON m.CountryCode = c.CountryCode
WHERE M.MountainId IS NULL