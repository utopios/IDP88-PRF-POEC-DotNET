/**
 * Les Tableaux Associatifs (On accède aux éléments par sa clé => key)
 */

// déclaration d'un tableau associatif
var personne = {
    nom:"Dupont",
    prenom:"Jeau-Eude",
    Age:25
};

// affichage d'un tableau associatif
console.table(personne);

// Affichage de la valeur à une clé
console.log(personne.prenom);
console.log(personne["nom"]);

