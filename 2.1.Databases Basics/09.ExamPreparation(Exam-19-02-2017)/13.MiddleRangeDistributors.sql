SELECT d.Name, i.Name, p.Name, (SELECT AVG(Rate) FROM Feedbacks WHERE ProductId = p.Id) AS AverageRate
FROM Products AS p
JOIN ProductsIngredients AS pp ON pp.ProductId = p.id
JOIN Ingredients AS i ON i.Id = pp.IngredientId
JOIN Distributors AS d ON i.DistributorId = d.Id
WHERE (SELECT AVG(Rate) FROM Feedbacks WHERE ProductId = p.Id) BETWEEN 5 AND 8
ORDER BY d.Name, i.Name, p.Name
