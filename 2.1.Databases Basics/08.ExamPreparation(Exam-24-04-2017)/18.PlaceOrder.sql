CREATE PROC usp_PlaceOrder @JobId INT, @SerialNumber VARCHAR(50), @Quantity INT
AS
BEGIN
	DECLARE @JobExists INT = (SELECT CASE WHEN Status = 'Finished' THEN 1 ELSE 0 END FROM Jobs WHERE JobId = @JobId)
	IF (@JobExists = 1)
	BEGIN
		RAISERROR('This job is not active!', 16, 1)
		RETURN;
	END
	IF (@Quantity <= 0)
	BEGIN
		RAISERROR ('Part quantity must be more than zero!', 16, 1)
		RETURN;
	END
	IF (@JobExists IS NULL)
	BEGIN
		RAISERROR ('Job not found!', 16, 1);
		RETURN;
	END
	DECLARE @PartId INT = (SELECT PartId FROM Parts WHERE SerialNumber = @SerialNumber)
	IF (@PartId IS NULL)
	BEGIN
		RAISERROR ('Part not found!', 16, 1)
		RETURN;
	END

	DECLARE @OrderId INT = (SELECT OrderId FROM Orders WHERE JobId = @JobId AND IssueDate IS NULL)
	IF (@OrderId IS NULL)
	BEGIN
		INSERT INTO Orders (JobId, IssueDate) VALUES
		(@JobId, NULL)
		SET  @OrderId = (SELECT OrderId FROM Orders WHERE JobId = @JobId AND IssueDate IS NULL)
	END	
	DECLARE @PartIsInOrder INT = (SELECT OrderId FROM OrderParts WHERE OrderId = @OrderId AND PartId = @PartId)
	IF (@PartIsInOrder IS NOT NULL)
	BEGIN
		UPDATE OrderParts
		SET Quantity += @Quantity
		WHERE OrderId = @OrderId AND PartId = @PartId
		RETURN
	END
	INSERT INTO OrderParts (OrderId, PartId, Quantity) VALUES
	(@OrderId, @PartId, @Quantity)
END
