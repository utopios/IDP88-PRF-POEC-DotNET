/**
 * Les Tableaux Numériques (On accède aux éléments par sa position (index))
 */

// Déclaration d'un tableau numérique
var monTableau = [];
// var monTableau = new Array(); // Equivaut à


// Affectation de valeur à un tableau numérique
monTableau[0] = "Pomme"; // Affectation d'une valeur à l'index 0 du tableau
monTableau[1] = "Poire"; // Affectation d'une valeur à l'index 1 du tableau

// Affichage d'un tableau dans la console
console.table(monTableau);
// Affichage de la valeur à un index donné
console.log(monTableau[1]);

// Déclaration et affectation de valeur en même temps
var legumes = ["Carottes", "Choux", "Haricots"];
// var legumes = new Array("Carottes","Choux","Haricots"); // Equivaut à

// Réaffectation de valeur
console.log(legumes[2]);
legumes[2] = "Epinards";
console.log(legumes[2]);

// Affichage du nombre d'entrée de notre tableau
var nbLegumes = legumes.length;
console.log("Mon tableau contient " + nbLegumes + " légumes.");
console.table(legumes);

// Insertion d'un élément sans connaitre de lastIndex
legumes.push("Courgettes");
console.table(legumes);
legumes.push("Potirons","Aubergines");
console.table(legumes);

// Affichage du nombre d'entrée de notre tableau
nbLegumes = legumes.length;
console.log("Mon tableau contient " + nbLegumes + " légumes.");

// Insertion avec récupération automatique du dernier index (Length)
legumes[legumes.length]="Cerises";
legumes[legumes.length]="Cerises";
legumes[legumes.length]="Cerises";
legumes[legumes.length]="Cerises";
console.table(legumes);

// Retirer le dernier élément d'un tableau (POP())
legumes.pop();
legumes.pop();
legumes.pop();
console.table(legumes);

// Retirer le premier élément d'un tableau => shift()
legumes.shift();
console.table(legumes);

// Insertion avec récupération automatique du dernier index (Length)
legumes[legumes.length]="Test";
legumes[legumes.length]="Test";
legumes[legumes.length]="Test";
legumes[legumes.length]="Test";

console.table(legumes);

// Retirer un ou plusieurs éléments à un index donné => splice(indexDepart,nbElementRetirer)
legumes.splice(6,4);
console.table(legumes);

// Ajouter un element à un index donné => splice(indexDepart,nbElementRetirer,valueAjouter)
legumes.splice(6,0,"Concombre","test");
console.table(legumes);