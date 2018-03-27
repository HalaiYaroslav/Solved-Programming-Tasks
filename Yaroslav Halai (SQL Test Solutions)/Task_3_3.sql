USE ShopDB
GO

--Повертає таблицю з підрахованими загальними "приходом" кількості товару та "приходом" грошей
CREATE FUNCTION dbo.GetIncome()
	RETURNS TABLE
AS
RETURN
	SELECT TOV.NTOV AS ProductName, TOV.SORT AS ProductSort, SUM(KOL) AS QuantityIncome, SUM(CENA * KOL) AS CashIncome FROM DMS
	JOIN TOV
	ON DMS.KTOV = TOV.KTOV
	JOIN DMZ
	ON DMZ.NDM = DMS.NDM
	WHERE DMZ.PR = 1
	GROUP BY TOV.NTOV, TOV.SORT	
GO

--Повертає таблицю з підрахованими загальними "розходом" кількості товару та "розходом" грошей
CREATE FUNCTION dbo.GetConsumption()
	RETURNS TABLE
AS
RETURN
	SELECT TOV.NTOV AS ProductName, TOV.SORT AS ProductSort, SUM(KOL) AS QuantityConsumption, SUM(CENA * KOL) AS CashConsumption FROM DMS
	JOIN TOV
	ON DMS.KTOV = TOV.KTOV
	JOIN DMZ
	ON DMZ.NDM = DMS.NDM
	WHERE DMZ.PR = 2
	GROUP BY TOV.NTOV, TOV.SORT	
GO

SELECT IT.ProductName, IT.ProductSort,	(IT.QuantityIncome - CT.QuantityConsumption) AS TotalProductBalance,
				    (IT.CashIncome - CT.CashConsumption) AS TotalMoneyBalance 
FROM dbo.GetIncome() AS IT
LEFT JOIN dbo.GetConsumption() AS CT
ON IT.ProductName = CT.ProductName AND IT.ProductSort = CT.ProductSort
ORDER BY ProductName

SELECT * FROM dbo.GetConsumption()
SELECT * FROM dbo.GetIncome()
GO

