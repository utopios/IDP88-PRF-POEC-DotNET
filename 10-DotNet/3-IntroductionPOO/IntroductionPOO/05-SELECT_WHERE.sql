-- Requêtes pour afficher toute la table
SELECT Pro.* FROM Product Pro

-- Requête sur la table Product pour trouver un certain type de produit ('LOAN')
SELECT Pro.* 
FROM Product Pro
WHERE Pro.PRODUCT_TYPE_CD = 'LOAN'

-- Requête sur la table Product pour trouver un certain type de produit ('ACCOUNT')
SELECT Pro.* 
FROM Product Pro
WHERE Pro.PRODUCT_TYPE_CD = 'ACCOUNT'

-- Requête sur la table Product pour trouver un certain type de produit Name = 'auto Loan'
SELECT Pro.* 
FROM Product Pro
WHERE Pro.Name = 'auto Loan'

-- Requête sur la table Product pour trouver un certain type de produit PRODUCT_CD = 'MRT'
SELECT Pro.* 
FROM Product Pro
WHERE Pro.PRODUCT_CD = 'MRT'