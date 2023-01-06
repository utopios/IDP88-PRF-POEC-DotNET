-- La Fonction Min() permet de retourner la plus petite valeur d'une colonne
SELECT * FROM ACCOUNT

-- Selection de la plus petite valeur de la table account (available_balance)
SELECT MIN(Acc.AVAIL_BALANCE) AS SoldeMin 
FROM ACCOUNT  ACC

-- Selection de la plus petite valeur de la table account (available_balance) pour les compte épargne
SELECT MIN(Acc.AVAIL_BALANCE) AS SoldeMin 
FROM ACCOUNT  ACC
WHERE Acc.PRODUCT_CD = 'Sav'

-- En Utilisant le Group By
-- Les Comptes peuvent être dans differentes agence
-- Rechercher la valeur minimale pour chacune des agence...


SELECT Acc.OPEN_BRANCH_ID,
		Min(Acc.AVAIL_BALANCE) AS SoldeMin
FROM ACCOUNT ACC
GROUP BY Acc.OPEN_BRANCH_ID