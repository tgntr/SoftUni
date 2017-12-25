SELECT f.ProductId,
CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
ISNULL(f.Description, '')
FROM Feedbacks AS f
JOIN Customers AS c ON c.Id = f.CustomerId
WHERE 3<=(SELECT COUNT(*) FROM Feedbacks WHERE CustomerId = c.Id)
ORDER BY f.ProductId, CustomerName, f.Id