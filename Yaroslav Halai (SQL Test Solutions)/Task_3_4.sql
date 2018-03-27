USE ShopDB
GO

CREATE FUNCTION dbo.SetPR()
	RETURNS INT
 AS
 BEGIN
	DECLARE @incomeCount INT, @consumptionCount INT, @newPR INT;
	SET @incomeCount = (SELECT COUNT(*) FROM DMZ WHERE PR = 1);
	SET @consumptionCount = (SELECT COUNT(*) FROM DMZ WHERE PR = 2);
	IF @incomeCount > @consumptionCount --Це не помилка. В заваднні вказано, якщо більше документів типу "прихід", то тип = "розхід".
		BEGIN
			SET @newPR = 2;
		END
		ELSE
			SET @newPR = 1;
	RETURN(@newPR);
END
GO

INSERT DMZ
VALUES
((SELECT TOP 1 DMZ.NDM FROM DMZ ORDER BY DMZ.NDM DESC) + 1, GETDATE(), dbo.SetPR())

SELECT * FROM DMZ
GO