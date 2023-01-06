-- Trier les personnes (Mlle)
SELECT nom, prenom, email
FROM PERSONNE
WHERE titre LIKE 'Mlle'

-- Trier les personnes (Mme)
SELECT nom, prenom, email
FROM PERSONNE
WHERE titre LIKE 'Mme'

-- Trier les personnes (Mr)
SELECT nom, prenom, email
FROM PERSONNE
WHERE titre LIKE 'Mr'

-- Trier par titre
SELECT titre,nom, prenom, email
FROM PERSONNE
Order BY titre ASC