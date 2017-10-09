SELECT Name, 
CASE
	WHEN DATEPART(hour, Start) >= 18  THEN 'Evening'
	WHEN DATEPART(hour, Start) >= 12  THEN 'Afternoon'        
	ELSE 'Morning'			 
END
AS 'Part of the Day',
CASE
	WHEN Duration <= 3  THEN 'Extra Short'
	WHEN Duration <= 6   THEN 'Short' 
	WHEN Duration > 6   THEN 'Long'        
	ELSE 'Extra Long'			 
END
AS 'Duration'  FROM Games		
ORDER BY Name, 'Duration', 'Part of the Day'