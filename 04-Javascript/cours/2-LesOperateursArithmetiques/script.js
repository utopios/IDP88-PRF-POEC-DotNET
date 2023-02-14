/**
 * Les Opérateurs Arithmétiques
 */

console.log("Les Opérateurs Arithmétiques");

// Déclaration de variables à la volée
var nb1 = 10, nb2 = 65, resultat;

// L'addition
resultat = nb1 + nb2;
console.log(nb1 + " + " + nb2 + " = " + resultat);
console.log(`${nb1} + ${nb2} = ${resultat}`);

// La soustraction
resultat = nb2 - nb1;
console.log(nb2 + " - " + nb1 + " = " + resultat);
console.log(`${nb2} - ${nb1} = ${resultat}`);

// La multiplication
resultat = nb2 * nb1;
console.log(nb2 + " * " + nb1 + " = " + resultat);
console.log(`${nb2} * ${nb1} = ${resultat}`);

// La division
resultat = nb2 / nb1;
console.log(nb2 + " / " + nb1 + " = " + resultat);
console.log(`${nb2} / ${nb1} = ${resultat}`);

// Modulo (reste de la division)
resultat = nb2 % nb1;
console.log(nb2 + " % " + nb1 + " = " + resultat);
console.log(`${nb2} % ${nb1} = ${resultat}`);

console.log("Les Opérateurs d'Incrémentation et Combinés");

// Incrementation
nb1 = nb1 + 1; // Incrémentation de 1 classique
console.log("Nb1 vaut : " + nb1);
// Peut se simplifier avec l'opérateur combiné +=
nb1 += 1;
console.log("Nb1 vaut : " + nb1);
// Ou avec l'opérateur d'incrémentation
nb1++;
console.log("Nb1 vaut : " + nb1);

// Décrémentation
nb1 = nb1 - 1; // Décrémentation de 1 classique
console.log("Nb1 vaut : " + nb1);
// Peut se simplifier avec l'opérateur combiné +=
nb1 = 1;
console.log("Nb1 vaut : " + nb1);
// Ou avec l'opérateur d'incrémentation
nb1--;
console.log("Nb1 vaut : " + nb1);

// Précision pour les Opérateurs ++ et --
console.log(nb1);
// Incrémentation puis lecture la valeur
console.log(++nb1);
// Décrémentation puis lecture la valeur
console.log(--nb1);
// lecture la valeur puis => Incrémentation
console.log(nb1++);
// lecture la valeur puis => Décrémentation 
console.log(nb1--);



nb1= 10;
console.log(nb1);

// Multiplication combinée
console.log(nb2 *= nb1 );
// Division combinée
console.log(nb2 /= nb1 );
