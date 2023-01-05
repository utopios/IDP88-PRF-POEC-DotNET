-- Affichage de la table Transaction
SELECT * FROM ACC_TRANSACTION

-- Affichage de la table Account
SELECT * FROM ACCOUNT

-- Insertion Multiple dans la table ACC_TRANSACTION
-- Utilisation d'un SELECT pour fournir les données
-- TXN_ID est auto-generé (primaryKey)
INSERT INTO ACC_TRANSACTION 
	(Amount, 
	FUNDS_AVAIL_DATE, 
	TXN_DATE,
	TXN_TYPE_CD,
	ACCOUNT_ID,
	EXECUTION_BRANCH_ID,
	TELLER_EMP_ID)
SELECT Acc.AVAIL_BALANCE ,--Amount
		Acc.LAST_ACTIVITY_DATE, --FUNDS_AVAIL_DATE
		Acc.OPEN_DATE, --TXN_DATE
		'CDT',--TXN_TYPE_CD
		Acc.ACCOUNT_ID,--ACCOUNT_ID
		NULL,
		NULL
FROM ACCOUNT Acc
WHERE Acc.PRODUCT_CD = 'CD'
