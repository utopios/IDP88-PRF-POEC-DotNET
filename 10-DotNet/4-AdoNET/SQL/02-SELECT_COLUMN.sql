-- Requête pour voir l'ensmble des champs cités de la table OFFICER
SELECT OFFICER_ID, FIRST_NAME, LAST_NAME FROM OFFICER

-- Requête pour voir l'ensmble des champs cités de la table EMPLOYEE
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME, 
		Emp.LAST_NAME,
		Emp.DEPT_ID  
FROM EMPLOYEE Emp


-- Sans Alias
SELECT EMP_ID,
		FIRST_NAME, 
		LAST_NAME,
		DEPT_ID  
FROM EMPLOYEE