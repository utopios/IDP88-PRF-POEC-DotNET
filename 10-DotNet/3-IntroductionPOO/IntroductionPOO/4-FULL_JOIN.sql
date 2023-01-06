﻿-- Le mote Clé FULL OUTER JOIN est une Combinaison est LEFT et RIGTH JOIN

--Syntaxe
--SELECT Column
--FROM TABLE 1
--FULL (OUTER) JOIN Table 2
--ON TABLE1.Column = Table2.Column




-- Affichage de la table Customer
SELECT * FROM CUSTOMER


-- AFFICHAGE DE LA TABLE OFFICER
SELECT * FROM OFFICER

-- CUSTOMER RIGTH OUTER JOIN OFFICER
-- LEFT OUTTER JOIN = LEFT JOIN
SELECT Cus.CUST_ID,
		Cus.ADDRESS,
		Cus.POSTAL_CODE,
		Cus.City,
		Cus.STATE,
		Ofc.OFFICER_ID,
		Ofc.FIRST_NAME,
		Ofc.LAST_NAME,
		Ofc.TITLE,
		Convert(VARCHAR, Ofc.START_DATE,105) AS Start_Date_Convert
FROM CUSTOMER Cus --Table 1
FULL OUTER JOIN  OFFICER Ofc-- Table 2
ON Cus.CUST_ID = Ofc.CUST_ID