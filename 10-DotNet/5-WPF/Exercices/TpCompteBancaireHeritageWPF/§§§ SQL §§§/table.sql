--DROP TABLE client
--DROP TABLE operation
--DROP TABLE compte

CREATE TABLE client(
id int PRIMARY KEY IDENTITY(1,1),
nom varchar(100) not null,
prenom varchar(100) not null,
telephone varchar(17) not null
);

CREATE TABLE operation(
id int PRIMARY KEY IDENTITY(1,1),
date_operation datetime not null,
montant decimal not null,
compte_id int not null
);

CREATE TABLE compte (
id int PRIMARY KEY IDENTITY(1,1),
solde decimal not null,
taux decimal not null,
coutOperation decimal not null,
client_id int not null,
);


-- Insertion Clients
INSERT INTO [dbo].[client] ([nom], [prenom], [telephone]) 
VALUES ( N'Di Persio', N'Anthony', N'+33 6 85 74 12 36'),
       ( N'Abadi', N'Ihab', N'+33 6 74 12 58 96'),
       ( N'Abadi', N'Marine', N'+33 6 45 78 62 32')



-- Insertion Comptes
INSERT INTO [dbo].[compte] ([client_id],[solde],[taux],[coutOperation])
VALUES (1,CAST(1550.00 AS Decimal(10, 2)), 0, 0),
	   (2,CAST(2000.00 AS Decimal(10, 2)), 4.0, 0),
	   (3,CAST(3000.00 AS Decimal(10, 2)), 0, 2.5)



-- Insertion d'opérations

INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(150.00 AS Decimal(10, 2)), N'2022-02-15 16:22:42', N'1')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-100.00 AS Decimal(10, 2)), N'2022-02-15 16:22:52', N'1')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(200.00 AS Decimal(10, 2)), N'2022-02-15 23:01:14', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(200.00 AS Decimal(10, 2)), N'2022-02-15 23:07:27', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:07:27', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(450.00 AS Decimal(10, 2)), N'2022-02-15 23:13:55', N'2')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-300.00 AS Decimal(10, 2)), N'2022-02-15 23:14:03', N'2')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-200.00 AS Decimal(10, 2)), N'2022-02-15 23:14:24', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:14:24', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(500.00 AS Decimal(10, 2)), N'2022-02-15 23:14:34', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-2.50 AS Decimal(10, 2)), N'2022-02-15 23:14:34', N'3')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(250.00 AS Decimal(10, 2)), N'2022-02-15 23:18:51', N'1')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(300.00 AS Decimal(10, 2)), N'2022-02-15 23:18:58', N'1')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(-400.00 AS Decimal(10, 2)), N'2022-02-15 23:19:04', N'1')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(86.00 AS Decimal(10, 2)), N'2022-02-15 23:54:56', N'2')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(89.44 AS Decimal(10, 2)), N'2022-02-15 23:55:01', N'2')
INSERT INTO [dbo].[operation] ( [montant], [date_Operation], [compte_id]) VALUES ( CAST(93.02 AS Decimal(10, 2)), N'2022-02-15 23:55:05', N'2')
