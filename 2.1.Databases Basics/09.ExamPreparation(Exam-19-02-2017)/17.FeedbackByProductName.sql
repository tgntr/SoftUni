CREATE FUNCTION udf_GetRating (@Name NVARCHAR(30))
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @ProductId INT = (SELECT Id FROM Products WHERE Name = @Name);
	DECLARE @AverageRating DECIMAL(4,2) = (SELECT AVG(Rate) FROM Feedbacks WHERE ProductId = @ProductId)
	DECLARE @RatingInWords NVARCHAR(10)
	IF (@AverageRating IS NULL)
	BEGIN
		SET @RatingInWords = 'No rating'
	END
	IF (@AverageRating < 5)
	BEGIN
		SET @RatingInWords = 'Bad'
	END
	IF (@AverageRating BETWEEN 5 AND 8)
	BEGIN
		SET @RatingInWords = 'Average'
	END
	IF (@AverageRating > 8)
	BEGIN
		SET @RatingInWords = 'Good'
	END
	RETURN @RatingInWords
END



