-- D'abord, nous devons comprendre ce que sont les fonctions d'agrégation :
--    Sum: la fonction calcule la somme sur un ensemble d'enregistrements
--    Avg: la fonction calcule la moyenne sur un ensemble d'enregistrements
--    Count: la fonction compte le nombre d'enregistrement 
--    Min: la fonction récupère la valeur minumum
--    Max: la fonction récupère la valeur maximum
-- Ce sont les fonctions d'agrégation courantes. Tous ces fonctions prennent tout leur sens lorsqu'elles sont utilisées avec la commande Group by.

-- Requete table Account
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE
From Account Acc

-- La requete permet de voir la somme d'argent, la moyenne  et le nombre par rapport à la catégorie de compte
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS ComptageCompte,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(ACC.AVAIL_BALANCE) AS MoyenneMontant
FROM ACCOUNT Acc
GROUP BY Acc.PRODUCT_CD