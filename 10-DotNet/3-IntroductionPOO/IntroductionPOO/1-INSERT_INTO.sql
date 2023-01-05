-- Affichage de la table Transaction
SELECT * FROM ACC_TRANSACTION

-- Requete pour inserrer une trasaction dans la BDD
-- PimaryKey sur le Champs TXN_ID génération automatique de l'id
-- Utilsation de Curent_Timestamp pour rtourner la date et l'heure au moment de l'opération (SQL SERVER)
INSERT INTO ACC_TRANSACTION 
	(Amount, 
	FUNDS_AVAIL_DATE, 
	TXN_DATE,
	TXN_TYPE_CD,
	ACCOUNT_ID,
	EXECUTION_BRANCH_ID,
	TELLER_EMP_ID)
VALUES (180, --Amount
		CURRENT_TIMESTAMP, --FUNDS_AVAIL_DATE
		CURRENT_TIMESTAMP, --TXN_DATE
		'CDT', --TXN_TYPE_CD
		4, --ACCOUNT_ID
		Null, --EXECUTION_BRANCH_ID
		Null --TELLER_EMP_ID
		)

-- Affichage de la table Transaction
SELECT * FROM ACC_TRANSACTION