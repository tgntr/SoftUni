SELECT TOP 10 
p.Name, 
p.Description, 
AVG(f.Rate) AS AverageRate, 
Count(f.Id) AS FeedbacksAmount
FROM Feedbacks AS f
JOIN Products AS p ON p.Id = f.ProductId
GROUP BY p.Name, p.Description
ORDER BY AVG(f.Rate) DESC, COUNT(f.Id) DESC