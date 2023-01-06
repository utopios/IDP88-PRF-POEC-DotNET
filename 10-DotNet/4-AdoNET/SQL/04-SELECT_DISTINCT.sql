-- Requêtes pour afficher toute la table
SELECT Pro.* FROM Product Pro

-- Requêtes pour afficher toute la table (avec selection colonne)
SELECT Pro.PRODUCT_CD,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD
FROM Product Pro

-- Requêtes pour afficher toute la table (avec selection colonne)
SELECT Pro.PRODUCT_TYPE_CD
FROM Product Pro

-- SELECT DISTINCT pour éliminer les doublons d'un champ
SELECT DISTINCT Pro.PRODUCT_TYPE_CD
FROM PRODUCT Pro