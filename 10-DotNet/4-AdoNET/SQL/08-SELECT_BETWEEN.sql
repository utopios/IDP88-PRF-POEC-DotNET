-- Affichage de la table employee
SELECT Emp.*
FROM EMPLOYEE Emp

-- Requete pour trouver les employés dont l'id est comprise entre 5 et 10
SELECT Emp.*
FROM EMPLOYEE Emp
WHERE Emp.EMP_ID>=5
AND Emp.EMP_ID<=10

-- Equivalent
SELECT Emp.*
FROM EMPLOYEE Emp
WHERE Emp.EMP_ID BETWEEN 5 and 10

-- Requête permettant de connaitre les employés avec une date d'embauche comprise dans une certain interval
SELECT Emp.EMP_ID,
Emp.FIRST_NAME,
Emp.LAST_NAME,
Emp.START_DATE,
Convert(VARCHAR,Emp.START_DATE,106) AS Start_Date_Convert
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DateTime,'01 May 2002',106)
AND CONVERT(DateTime,'30 Sep 2002',106)


