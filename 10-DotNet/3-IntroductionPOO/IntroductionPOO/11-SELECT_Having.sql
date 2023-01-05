-- La condition Having nous permet d'indiquer les conditions de séléction pour filtrer des groupes de résultats
-- La Commande WHERE met en oeuvre des conditions sur des colonnes séléctionnées, 
-- Là ou Having va mettre en oeuvre des conditions sur les groupes qui sont crées par l'opérateur GROUP BY

-- requêtes pour regrouper les catégories de service et n'avoir que les membres ayant plus de 3 entrèes
-- Sans Having
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS ComptageCompte,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(ACC.AVAIL_BALANCE) AS MoyenneMontant
FROM ACCOUNT ACC
GROUP BY Acc.PRODUCT_CD

-- AVEC LA CONDITION HAVING
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS ComptageCompte,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(ACC.AVAIL_BALANCE) AS MoyenneMontant
FROM ACCOUNT ACC
GROUP BY Acc.PRODUCT_CD
HAVING Count(acc.PRODUCT_CD) > 3

-- LA distinction entre WHERE ET HAVING
--      => WHERE est utilisé pour filtrer la BDD avant le Group BY
--      => Having est utilisé pour filtrer la BDD après le Group BY

-- Requête pour afficher des elements d'une sucursale en particulier
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE
FROM ACCOUNT Acc
-- Utilisation du WHERE pour filtrer AVANT le GROUP BY
WHERE Acc.OPEN_BRANCH_ID=1



-- Requête pour afficher des elements d'une sucursale en particulier
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS ComptageCompte,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) AS MoyenneMontant
FROM ACCOUNT Acc
-- Utilisation du WHERE pour filtrer AVANT le GROUP BY
WHERE Acc.OPEN_BRANCH_ID = 1
GROUP BY Acc.PRODUCT_CD
-- Utilisation du Having pour filtrer apres le GROUP BY
Having Count(Acc.PRODUCT_CD) > 1
