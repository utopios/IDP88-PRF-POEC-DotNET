---- Affichage de la table ACC_TRANSACTION
--SELECT * FROM ACC_TRANSACTION
--ORDER BY TXN_ID DESC

---- Suppression d'une entrée faites dans la table ACC_Transaction
--DELETE FROM ACC_TRANSACTION
--WHERE TXN_ID = 27

-- Affichage de la table ACC_TRANSACTION
SELECT * FROM ACC_TRANSACTION
ORDER BY TXN_ID DESC

---- Suppression de plusieurs entrées faites dans la table ACC_Transaction
--DELETE FROM ACC_TRANSACTION
--WHERE TXN_ID in (24,26)


-- Suppression de plusieurs entrées faites dans la table ACC_Transaction
DELETE FROM ACC_TRANSACTION
WHERE TXN_ID 
BETWEEN 22
AND 25

-- Affichage de la table ACC_TRANSACTION
SELECT * FROM ACC_TRANSACTION
ORDER BY TXN_ID DESC