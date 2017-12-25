SELECT TOP 1 WITH TIES
co.Name, 
AVG(Rate) AS FeedbackRate 
FROM Feedbacks AS f
JOIN Customers AS c ON c.Id = f.CustomerId
JOIN Countries AS co ON co.Id = c.CountryId
GROUP BY co.Name
ORDER BY AVG(Rate) DESC
