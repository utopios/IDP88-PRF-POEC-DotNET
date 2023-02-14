/**
 * Les Boucles Itératives
 */

/**
 * La Boucle Tant que... (While)
 */
var i = 1;
while (i <= 10) {
    console.log(`La boucle while s'est executée ${i} fois.`);
    i++;
}

console.log("Sortie de la boucle while, i vaut " + i);



/**
 * La Boucle Faire Tant que... (Do...While...)
 */

do {
    console.log(`La boucle Do while s'est executée.`);
    i++;
} while (i <= 10)

console.log("Sortie de la boucle Do while, i vaut " + i);

/**
 * Boucle Pour... (For...)
 * 
 * for(initialisation variable itération ; condition de rebouclage ; Pas incrémentation)
 * {
 *     // Instructions executée à chaque itération
 * }
 */

// i = 1;
for (i = 1; i <= 10; i++) {
    console.log(`La boucle for s'est executée ${i} fois.`);
}

console.log("Sortie de la boucle for, i vaut " + i);

/**
 * Instructions Break... Continue...
 */

console.log("Instructions Break... Continue");

var jourSem = ["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"];

// Itération du tableau numerique par la boucle for

for (var j = 0; j < jourSem.length; j++) {
    //if (j === 0) {
    if (j >= 1 && j < 4) {
        console.log("Début de la semaine");
        continue;
    }
    console.log(jourSem[j]);
    if (j === 4)
        break;
}

/**
     * EXERCICE
     * A partir du tableau numérique suivant :
     * 
     * var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];
     * 
     * 1/ Gràce à une boucle for, afficher la liste des prenoms du tableau
     * 2/ Gràce à une boucle while, afficher la liste des prenoms du tableau
 */

 var names = ["Adam", "Etienne", "Sebastien", "Clement", "Virginie"];

 console.log("Exercice Tableau");
 console.log("Avec boucle for");

// boucle for
for(var k = 0 ; k < names.length ; k++ ){
    console.log(names[k]);
}

console.log("Avec boucle while");

// boucle while

var k = 0;
while(k < names.length){
    console.log(names[k]);
    k++;
}

/**
 * La boucle Pour... dans... (For... in...)
 */

 console.log("Avec For... In");

// Parfait pour les tableaux associatif
var contact = {
    nom :"Richard",
    prenom :"Pierre",
    telephone :"+33 6 41 52 63 98",
    email :"pierre.richard@gmail.com"
}

// Exemple de boucle  For...in
for(var key in contact){
    console.log(key); // Affiche les clé du tableau
    console.log(contact[key]); // Affiche les valeurs
    console.log(key + " : " + contact[key]); // Affiche les pairs de clé +  valeurs
}

/**
 * La boucle For Of
 */

// Iteration du tableau names avec une boucle for of
for(const name of names){
    console.log(`La boucle for...Of, names contient ${name}`);
}

/**
 * Boucles Imbriquées
 */

for(var i = 1 ; i < 5; i++){
    console.log("i = "+i);
    for(var j = 1 ; j < 5 ; j ++){
        console.log("j = "+j);
    }
    // plus d'instructions
}


