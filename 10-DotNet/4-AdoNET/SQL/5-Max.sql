-- La Fonction Max() permet de retourner la plus grande valeur d'une colonne
SELECT * FROM ACCOUNT

-- Selection de la plus grande valeur de la table account (available_balance)
SELECT Max(Acc.AVAIL_BALANCE) AS SoldeMax 
FROM ACCOUNT  ACC

-- Selection de la plus grande valeur de la table account (available_balance) pour les compte épargne
SELECT Max(Acc.AVAIL_BALANCE) AS SoldeMax 
FROM ACCOUNT  ACC
WHERE Acc.PRODUCT_CD = 'Sav'

-- En Utilisant le Group By
-- Les Comptes peuvent être dans differentes agence
-- Rechercher la valeur maximale pour chacune des agence...


SELECT Acc.OPEN_BRANCH_ID,
		Max(Acc.AVAIL_BALANCE) AS SoldeMax
FROM ACCOUNT ACC
GROUP BY Acc.OPEN_BRANCH_ID