CREATE TRIGGER tr_OrderDeliver ON Orders AFTER UPDATE
AS
BEGIN

	DECLARE @NewStatus INT = (SELECT Delivered FROM inserted)
	DECLARE @OldStatus INT = (SELECT Delivered FROM deleted)
	
	IF (@NewStatus = 1 AND @OldStatus = 0)
	BEGIN
		DECLARE @UpdatedOrderId INT = (SELECT OrderId FROM inserted)
		UPDATE Parts
		SET StockQty += op.Quantity
		FROM Parts AS p 
		JOIN OrderParts AS op ON p.PartId = op.PartId
		WHERE op.OrderId = @UpdatedOrderId
	END
END

UPDATE Orders
SET Delivered = 1
WHERE OrderId = 9

SELECT * FROM Parts
JOIN OrderParts ON Parts.PartId = OrderParts.PartId
