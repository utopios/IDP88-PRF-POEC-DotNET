-- Requête pour séléctionner les employés avec des critères multiples sur le même champ
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME IN ( 'Susan' , 'Paula', 'Helen')