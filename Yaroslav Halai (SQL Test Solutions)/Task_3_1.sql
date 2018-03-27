USE ShopDB
GO

--Трохи модифікована версія, яка групує не тільки по назві товару, як вимагає того завдання, а ще й за сортом товару
--Так ми маємо загальну кількість та загальний прибуток проданого світлого та темного пива окремо
SELECT TOV.NTOV + ' ' + TOV.SORT AS ProductName, SUM(DMS.KOL) AS TotalQuantity, SUM(DMS.KOL * DMS.CENA) AS TotalPrice FROM DMS
JOIN DMZ
ON DMS.NDM = DMZ.NDM
JOIN TOV
ON DMS.KTOV = TOV.KTOV
WHERE DMZ.DDM = '05/01/2014'
GROUP BY TOV.NTOV, TOV.SORT
ORDER BY TotalPrice DESC
GO

SELECT * FROM DMS
SELECT * FROM DMZ
SELECT * FROM TOV