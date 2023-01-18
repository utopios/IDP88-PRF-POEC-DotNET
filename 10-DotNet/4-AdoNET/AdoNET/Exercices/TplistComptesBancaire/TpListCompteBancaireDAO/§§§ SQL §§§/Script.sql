﻿--DROP TABLE CLIENT, OPERATION, COMPTE

CREATE TABLE CLIENT
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NOM VARCHAR(50) NOT NULL,
	PRENOM VARCHAR(50) NOT NULL,
	TELEPHONE VARCHAR(17) NOT NULL,
)


-- Insertion Clients
INSERT INTO [dbo].[client] ([nom], [prenom], [telephone]) 
VALUES ( N'Di Persio', N'Anthony', N'+33 6 85 74 12 36'),
       ( N'Abadi', N'Ihab', N'+33 6 74 12 58 96'),
       ( N'Abadi', N'Marine', N'+33 6 45 78 62 32')

CREATE TABLE OPERATION
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MONTANT DECIMAL(10,2) NOT NULL,
	DATEOPERATION DATETIME NOT NULL,
	COMPTE_ID INT NOT NULL,
)



-- Insertion d'opérations

INSERT INTO OPERATION ( MONTANT, DATEOPERATION, COMPTE_ID)
VALUES ( CAST(150.00 AS Decimal(10, 2)), N'2022-02-15 16:22:42', N'1'),
		( CAST(-100.00 AS Decimal(10, 2)), N'2022-02-15 16:22:52', N'1'),
		( CAST(200.00 AS Decimal(10, 2)), N'2022-02-15 23:01:14', N'3'),
		( CAST(200.00 AS Decimal(10, 2)), N'2022-02-15 23:07:27', N'3'),
		( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:07:27', N'3'),
		( CAST(450.00 AS Decimal(10, 2)), N'2022-02-15 23:13:55', N'2'),
		( CAST(-300.00 AS Decimal(10, 2)), N'2022-02-15 23:14:03', N'2'),
		( CAST(-200.00 AS Decimal(10, 2)), N'2022-02-15 23:14:24', N'3'),
		( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:14:24', N'3'),
		( CAST(500.00 AS Decimal(10, 2)), N'2022-02-15 23:14:34', N'3'),
		( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:14:34', N'3'),
		( CAST(250.00 AS Decimal(10, 2)), N'2022-02-15 23:18:51', N'1'),
		( CAST(300.00 AS Decimal(10, 2)), N'2022-02-15 23:18:58', N'1'),
		( CAST(-400.00 AS Decimal(10, 2)), N'2022-02-15 23:19:04', N'1'),
		( CAST(86.00 AS Decimal(10, 2)), N'2022-02-15 23:54:56', N'2'),
		( CAST(89.44 AS Decimal(10, 2)), N'2022-02-15 23:55:01', N'2'),
		( CAST(93.02 AS Decimal(10, 2)), N'2022-02-15 23:55:05', N'2')

CREATE TABLE COMPTE
(
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	CLIENT_ID INT NOT NULL,
	SOLDE DECIMAL(10,2) NOT NULL,
	TAUX DECIMAL(10,2) NOT NULL,
	COUT DECIMAL(10,2) NOT NULL,
)

-- Insertion Comptes
INSERT INTO [dbo].[compte] ([client_id],[solde],[taux],[cout])
VALUES (1,CAST(1550.00 AS Decimal(10, 2)), 0, 0),
	   (2,CAST(2000.00 AS Decimal(10, 2)), 4.0, 0),
	   (3,CAST(3000.00 AS Decimal(10, 2)), 0, 2.5)




