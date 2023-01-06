-- INNER JOIN permet de retourner les enregistrment qui ont au moin une ligne dans les DEUX tables

---- Syntaxe
--SELECT *
--FROM TableA
--INNER JOIN TableB
--ON TableA.Id = TableB.NomColonne

--SELECT *
--FROM TableA
--JOIN TableB
--ON TableA.Id = TableB.NomColonne


--Affichage de la table Employee
SELECT * FROM EMPLOYEE

--Affichage de la table DEPARTMENT
SELECT * FROM DEPARTMENT

-- INNER JOIN sur les deux tables afin de rassembler les infos des deux tables en une
SELECT EMP.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE,
		Dep.NAME AS DepartmentName
FROM EMPLOYEE Emp
JOIN DEPARTMENT Dep
ON Emp.DEPT_ID = Dep.DEPT_ID
ORDER BY Emp.DEPT_ID