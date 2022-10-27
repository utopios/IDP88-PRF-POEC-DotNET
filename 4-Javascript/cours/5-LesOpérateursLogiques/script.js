/**
 * Les Opérateurs Logiques
 */

console.log("Les Opérateurs Logiques");

/**
 * OPERATEUR LOGIQUE &&  => ET
 */

var userNum = Number(prompt("Veuillez saisir un chiffre entre 1 et 3 inclus"));
if (userNum >= 1 && userNum <= 3) {
    console.log("Le nombre saisie est bien situé entre 1 et 3 inclus");
} else {
    console.log("Le nombre saisie n'est pas situé entre 1 et 3 inclus");
}

/**
 * OPERATEUR LOGIQUE ||  => OU
 */
var userNum2 = Number(prompt("Veuillez saisir un chiffre strictement inferieur à 1 ou strictement supérieur à 3"));
// if(1<userNum<5){
//     console.log("ancienne syntaxe");
// }
if (userNum2 < 1 || userNum2 > 3) {
    console.log("Le nombre saisie est bien strictement inferieur à 1 ou strictement supérieur à 3");
} else {
    console.log("Le nombre saisie n'est pas strictement inferieur à 1 ou strictement supérieur à 3");
}

/**
 * OPERATEUR LOGIQUE !  => Non (Contraire de...)
 */
 var pause = false;
 
 if (!pause) {
     console.log("Ce n'est pas la pause");
 } else {
     console.log("Bonne pause");
 }

