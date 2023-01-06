-- La Fonction AVG() permet de calculer une valeur moyenne sur l'ensemble des données
SELECT * FROM ACCOUNT

-- Calculer le montant moyen pour le comptes épargnes (SAV)
SELECT AVG(Acc.AVAIL_BALANCE) AS MoyenneDesComptes
FROM ACCOUNT Acc
WHERE Acc.PRODUCT_CD = 'sav'

-- Calculer le montant moyen pour le comptes épargnes (SAV)
-- Group BY => Un Client possede un ou plusieur comptes
-- Calcul de la moyenne des comptes pour chaque client de la sucussale (Branch_Id = 1)
SELECT AVG(Acc.AVAIL_BALANCE) AS MoyenneDesComptes
FROM ACCOUNT Acc
WHERE Acc.OPEN_BRANCH_ID = 1
GROUP BY Acc.CUST_ID