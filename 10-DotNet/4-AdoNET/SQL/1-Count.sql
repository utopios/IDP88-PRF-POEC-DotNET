-- La Fonction Count() permet de retourner le nombre de lignes correspondant à nos critères
SELECT * FROM Employee
-- Compter le nombre d'instance correspondant à nos critères
SELECT Count(Emp.EMP_ID) AS Nb_Employés 
FROM EMPLOYEE Emp

-- Affichage de la table ACCOUNT
SELECT * FROM ACCOUNT
-- Compter le nombre de CLient (unique) qui détiennet au moins un compte dans la banque
SELECT Count(DISTINCT Acc.Cust_Id) AS Nb_CLient
FROM ACCOUNT Acc

-- Requête pour lister les clients et leur comptes
SELECT Acc.CUST_ID,
		Count(Acc.ACCOUNT_ID) AS Nb_Comptes
FROM ACCOUNT Acc
GROUP BY Acc.CUST_ID