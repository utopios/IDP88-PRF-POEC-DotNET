/**
 * Les Structures Conditionnelles
 */

console.log("Les Structures Conditionnelles");

/**
 * L'instruction If ( Si... Alors..) Else (Sinon...)
 * 
 * if (Condition)
 * {
 *  // Si la condition est vrai => Code à Executer 
 * } 
 * else
 * {
 * // Si la condition est fausse => Code à Executer
 * }
 */

// Exemple 1 => Avec plusieurs vérifications
var compte = -300;
if (compte > 0)
    console.log("Votre compte est créditeur");

if (compte < 0)
    console.log("Votre compte est débiteur");


// Avec plusieurs instructions
if (compte > 0) {
    console.log("Votre compte est créditeur");
    console.log(`Vous avez ${compte} Euros.`);
}
else {
    console.log("Votre compte est débiteur ou null");
    console.log(`Vous avez ${compte} Euros.`);
}

// Avec Un Booléen
var estCrediteur = (compte > 0);
if (estCrediteur)
    console.log("Votre compte est créditeur( Avec un bool)");
else
    console.log("Votre compte est débiteur ( Avec un bool)");

// Avec Un Booléen
var estVrai = false;
if (estVrai)
    console.log("C'est vrai!");
else
    console.log("C'est faux!");

// Avec une récupération de saisie utilisateur
var age = 0;
//var age = Number(prompt("Veuillez saisir votre age : "));
console.log(typeof (age));

if (age >= 18)
    console.log("Vous êtes majeur");
else
    console.log("Vous êtes mineur");

/**
 * Avec Sinon si
*/
// Structure conditionnelle avec vérifications multiples
if (compte > 0) {
    console.log("Votre compte est créditeur");
    console.log(`Vous avez ${compte} Euros.`);
}
else if (compte === 0) {
    console.log("Votre compte est null");
    console.log(`Vous avez ${compte} Euros.`);
}
else {
    console.log("Votre compte est débiteur");
    console.log(`Vous avez ${compte} Euros.`);
}

/**
 * Les Differents opérateur de comparaison
 * 
 * == signifie est égal à // Permet de vérifier si deux valeurs sont identiques
 * 
 * === signifie est strictement égal à // Permet de vérifier si deux valeurs et types sont identiques
 * 
 * != signifie est différent de // Permet de vérifier si deux valeurs sont differentes
 * 
 * !== signifie est strictement différent de // Permet de vérifier si deux valeurs sont differentes
 */

console.log(1 == 1); // vrai
console.log("1" == 1); // vrai
console.log(1 === 1); // vrai
console.log("1" === 1); // faux
console.log("1" != 1); // faux
console.log(3 !== 3); // faux
console.log(4 !== 3); // vrai

/**
 * SWITCH CASE
 * 
 * switch(condition){
 *      case valeur1 :
 *          // Instruction à executer si ce cas est vrai;
 *          break;
 *      case valeur2 :
 *          // Instruction à executer si ce cas est vrai;
 *          break;
 *      case valeurN :
 *          // Instruction à executer si ce cas est vrai;
 *          break;
 *      default:
 *          // Instruction à executer si ce cas est vrai;
 *          break;  
 * };
 */

const civilite = "Mr.";
switch (civilite) {
    case 'Mr.':
        console.log("Bonjour Monsieur");
        break;
    case 'Mme':
        console.log("Bonjour Madame");
        break;
    default:
        console.log("Bonjour Mademoiselle");
        break;
}

const cond = "Oranges";
switch (cond) {
    case 'Oranges':
        console.log("Les oranges sont à 2.99€/kg");
        break;
    case 'Mangues':
    case 'Papayes':
        console.log("Les Mangues et les Papayes sont à 9.99€/kg");
        break;
    default:
        console.log(`Désole, nous sommes à cour de ${cond}`);
        break;
}

/**
 * Switch avec Range de valeurs
 */
var age = 3;
var resultat="";
 switch (true) {
    case age <= 6:
        resultat = `Votre enfant est dans la catégorie "BABY"`;
        break;
    case age <= 8:
        resultat = `Votre enfant est dans la catégorie "Poussin"`;
        break;
    case age <= 10:
        resultat = `Votre enfant est dans la catégorie "Pupille"`;
        break;
    case age <= 12:
        resultat = `Votre enfant est dans la catégorie "Minime"`;
        break;
    default:
        resultat = `Votre enfant est dans la catégorie "Cadet"`;
        break;
}

console.log(resultat);