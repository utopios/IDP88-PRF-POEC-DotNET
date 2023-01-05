-- LE mot cle LEFT OUTER JOIN est une jointure externe pour récupérer toutes les infos de la table de gauche
-- et seulement les lignes ayant une correspondance depuis la deuxieme table vers la premiere.

-- Affichage de la table Customer
SELECT * FROM CUSTOMER

-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- CUSTOMER LEFT OUTER JOIN OFFICER
-- LEFT OUTTER JOIN = LEFT JOIN
SELECT Cus.CUST_ID,
		Cus.STATE,
		Cus.POSTAL_CODE,
		Cus.City,
		Cus.ADDRESS,
		Ofc.OFFICER_ID,
		Ofc.FIRST_NAME,Ofc.LAST_NAME,Ofc.TITLE
FROM CUSTOMER Cus --Table 1
LEFT OUTER JOIN OFFICER Ofc -- Table 2
ON Cus.CUST_ID = Ofc.CUST_ID