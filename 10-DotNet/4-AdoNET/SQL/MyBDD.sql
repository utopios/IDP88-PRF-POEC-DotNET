-- Suppression de la table dans la BDD
DROP TABLE PERSON

-- Création de la nouvelle TABLE
CREATE TABLE [dbo].[PERSON] (
    [ID]       INT  IDENTITY(1,1) NOT NULL,
    [NOM]      VARCHAR (50) NOT NULL,
    [PRENOM]   VARCHAR (50) NOT NULL,
    [EMAIL]    VARCHAR (50) NOT NULL,
    [TELEPHONE] VARCHAR (17) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

-- Insertion des données
INSERT INTO [dbo].[PERSON] ( [NOM],[PRENOM], [EMAIL], [TELEPHONE]) 
VALUES ( N'Titi',N'Tata', N'titi@yahoo.fr', N'+33 6 12 34 56 78'),
        ( N'Toto',N'Tata', N'toto@yahoo.fr', N'+33 6 98 76 54 32'),
        ( N'Legrand',N'Zorro', N'zorro@yahoo.fr', N'+33 6 41 52 63 87'),
        ( N'Dark',N'Jeanne', N'jeanne@yahoo.fr', N'+33 6 74 12 58 96'),
        ( N'Delarotule',N'Jean-Eude', N'delarotule@yahoo.fr', N'+33 6 14 85 96 32')
