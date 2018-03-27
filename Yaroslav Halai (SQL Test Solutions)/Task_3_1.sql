USE ShopDB
GO

--����� ������������ �����, ��� ����� �� ����� �� ���� ������, �� ������ ���� ��������, � �� � �� ������ ������
--��� �� ���� �������� ������� �� ��������� �������� ��������� ������� �� ������� ���� ������
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