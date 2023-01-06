-- Le mote Clé RIGHT OUTER JOIN est une jointure externe pour récupérer les informations de la table de gauche (Table 2) 
-- tout en récupérant les données associées avec la table de droite (Table 1)

-- Affichage de la table Customer
SELECT * FROM CUSTOMER


-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- CUSTOMER RIGTH OUTER JOIN OFFICER
-- LEFT OUTTER JOIN = LEFT JOIN
SELECT Cus.CUST_ID,
		Cus.STATE,
		Cus.POSTAL_CODE,
		Cus.City,
		Cus.ADDRESS,
		Ofc.OFFICER_ID,
		Ofc.FIRST_NAME,Ofc.LAST_NAME,Ofc.TITLE
FROM OFFICER Ofc --Table 1
RIGHT OUTER JOIN CUSTOMER Cus -- Table 2
ON Cus.CUST_ID = Ofc.CUST_ID