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
    if (j >= 1 && j <4) {
        console.log("Début de la semaine");
        continue;
    }
    console.log(jourSem[j]);
    if (j === 4)
        break;
}








