-- Affichage de la table Employee triée par ordre croissant
SELECT Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
Convert(VARCHAR,Emp.START_DATE,106) AS Start_Date_Convert
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DateTime,'01 May 2002',106)
AND CONVERT(DateTime,'30 Sep 2002',106)
ORDER BY Emp.START_DATE ASC

-- ASC est le comportement par defaut du ORDER BY
SELECT Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
Convert(VARCHAR,Emp.START_DATE,106) AS Start_Date_Convert
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DateTime,'01 May 2002',106)
AND CONVERT(DateTime,'30 Sep 2002',106)
ORDER BY Emp.START_DATE

-- Requete permttant de retourner les employés dans un range de valeur et par ordre decroissant
SELECT Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
Convert(VARCHAR,Emp.START_DATE,106) AS Start_Date_Convert
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DateTime,'01 Jan 2002',106)
AND CONVERT(DateTime,'31 Dec 2002',106)
ORDER BY Emp.START_DATE DESC

-- Requete por trier par Prouct Type en ordre croissant
-- Puis par nom en ordre decroissant

SELECT Pro.PRODUCT_CD,
		PRODUCT_TYPE_CD,
		Pro.NAME
FROM PRODUCT Pro
ORDER BY Pro.PRODUCT_Type_CD ASC,
		Pro.NAME DESC