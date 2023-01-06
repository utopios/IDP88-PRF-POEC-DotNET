-- Utilisation de la méthode CONVERT pour faire de la convertion de TYPE (INT => VARCHAR)
-- Syntaxe de CONVERT(VARCHAR, <INTValue>)
-- Mise en forme du Résultat via la concaténation (+)
-- Si création de colonne, Utiliser 'AS' pour définir le nom de la colone

SELECT Emp.EMP_ID,
	Emp.FIRST_NAME,
	Emp.LAST_NAME,
	Emp.DEPT_ID,
	'EMP' + Convert(VARCHAR,Emp.EMP_ID) AS EMPLOYEE_ID
FROM Employee Emp