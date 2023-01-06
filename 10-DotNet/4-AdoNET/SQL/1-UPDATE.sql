-- affichage de la table Account
--SELECT * FROM ACCOUNT

-- Affichage d'un compte de la table Account (N°1)
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE,
		Acc.CUST_ID
FROM Account ACC
WHERE ACC.CUST_ID = 1

-- Update des comptes pour le client 1 avec une augmentation de 5%
UPDATE ACCOUNT
SET AVAIL_BALANCE = AVAIL_BALANCE + AVAIL_BALANCE*5/100,
	PENDING_BALANCE = PENDING_BALANCE + PENDING_BALANCE*5/100
WHERE CUST_ID = 1


-- Affichage d'un compte de la table Account (N°1)
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE,
		Acc.CUST_ID
FROM Account ACC
WHERE ACC.CUST_ID = 1

-- Update des comptes pour le client 1 avec une baisse de 5%
UPDATE ACCOUNT
SET AVAIL_BALANCE = AVAIL_BALANCE * 100 / 105,
	PENDING_BALANCE = PENDING_BALANCE * 100 / 105
WHERE CUST_ID = 1

-- Affichage d'un compte de la table Account (N°1)
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE,
		Acc.CUST_ID
FROM Account ACC
WHERE ACC.CUST_ID = 1


