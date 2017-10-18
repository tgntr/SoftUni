SELECT 
c.ContinentCode,
c.CurrencyCode,
c.CurrencyUsage
FROM (
	SELECT 
	cs.ContinentCode,
	cs.CurrencyCode,
	COUNT(cs.CurrencyCode) as CurrencyUsage,
	RANK() OVER (PARTITION BY cs.ContinentCode ORDER BY COUNT(cs.CurrencyCode) DESC) AS Rank
	FROM Countries AS cs
	GROUP BY cs.ContinentCode, cs.CurrencyCode
	HAVING COUNT(cs.CurrencyCode) > 1
) AS c
WHERE c.Rank = 1
ORDER BY c.ContinentCode


