-- Requête pour avoir tous les champs de la table EMPLOYEE
SELECT * FROM EMPLOYEE

-- Requête pour séléctionner les employés dont le prénom commence par 'S'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME Like 'S%'


-- Requête pour séléctionner les employés dont le prénom commence par 'S'
-- Et travaillent dans le département Opération(1)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME Like 'S%'
AND Emp.DEPT_ID = 1

-- Requête pour séléctionner les employés dont le prénom commence par 'S'
-- Et travaillent dans le département Opération(1)
-- Et occupent le poste de caissier(ere) => Teller
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME Like 'S%'
AND Emp.DEPT_ID = 1
AND Emp.Title = 'Teller'


-- Requête pour séléctionner les employés dont le prénom commence par 'S' ou 'J'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME Like 'S%'
OR Emp.FIRST_NAME Like 'J%'

-- Requête pour séléctionner les employés dont le prénom termine par 'en' ou 'an'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME Like '%en'
OR Emp.FIRST_NAME Like '%an'


-- Requête pour séléctionner les employés dont le prénom est 'Susan' et le nom 'Barker'
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME = 'Susan'
AND Emp.LAST_NAME = 'Barker'