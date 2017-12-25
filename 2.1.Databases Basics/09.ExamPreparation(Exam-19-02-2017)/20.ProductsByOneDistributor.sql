WITH a AS (
	SELECT p.Name AS ProductName, 
	p.Id,
	(SELECT AVG(Rate) FROM Feedbacks WHERE ProductId = p.Id) AS ProductAverageRate,
	d.Name AS DistributorName,
	co.Name AS DistributorCountry 
	FROM Products AS p
	JOIN ProductsIngredients AS pp ON pp.ProductId = p.Id
	JOIN Ingredients AS i ON pp.IngredientId = i.id
	JOIN Distributors AS d ON i.DistributorId = d.Id
	JOIN Countries AS co ON d.CountryId = co.Id
	GROUP BY p.Name, p.Id, d.Name, co.Name
)
SELECT ProductName, ProductAverageRate, DistributorName, DistributorCountry
FROM a 
WHERE (SELECT COUNT(*) FROM a  AS aa WHERE a.ProductName = aa.ProductName) = 1
ORDER BY a.Id