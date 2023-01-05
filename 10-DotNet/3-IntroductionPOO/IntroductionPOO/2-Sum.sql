-- La Fonction Sum() permet de calculer la somme totale d'une colonne contenant des valeurs numériques
SELECT * FROM ACCOUNT

-- Calculer la somme des comptes d'un client
SELECT Sum(Acc.AVAIL_BALANCE) AS SommeDesComptes
FROM ACCOUNT Acc
WHERE Acc.CUST_ID = 2


-- En utilisant le Group By
-- Calculer la somme des comptes des Client
SELECT Acc.CUST_ID,
		Sum(Acc.AVAIL_BALANCE) AS SommeDesComptes
FROM ACCOUNT Acc
GROUP BY Acc.CUST_ID 