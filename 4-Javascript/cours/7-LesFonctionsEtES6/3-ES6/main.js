/**
 * Les Nouveautées EcmaScript 6
 */

/**
 * LET
 * 
 * Jusqu'a présent les variable etaient déclarée par le moit clé var
 * Maintenant nous utiliseron let... voyons pourquoi
 */

console.log("--------------Nouveautée ES6--------------");
console.log("Mot-clé let => remplace var");

// On demande d'afficher les variables avant leu déclaration
console.log(prenomVar);// Hoisting (remontée de la déclaration de la variable => Pour le navigateur la variable existe mais n'a pas de valeur)
// console.log(nomLet);// Provoque une erreur

// Déclaration des variables
var prenomVar = "Richard";
let nomLet = "Gear";

/**
 * const
 * 
 * Pour déclarer une constante
 */

const nbMax = 128;
console.log("nbMax vaut : " + nbMax / 2);
//nbMax=129; // Provoque une erreur => Assignement constant variable

const fruits = ["pomme"];
//fruits = ["Abricots","Poire"];// Provoque une erreur => Assignement constant variable

fruits.push("Abricots", "Poire"); // Ici const garantit la structure de l'objet (tableau numérique ici)
console.table(fruits);

/**
* Les nouvelles méthodes apportées par l'ES6 :
* 
* .forEach
* .map()
* .find()
* .filter()
* 
*/
console.log("---------- Les nouvelles Méthodes ES6 ----------");

// Déclaration d'un tableau de légumes (2 dimensions)

const vegetable = [
  {
    code: 1,
    name: "Carotte",
    price: 1.99
  },
  {
    code: 2,
    name: "Poivron Vert",
    price: 4.99
  },
  {
    code: 3,
    name: "Poivron Rouge",
    price: 4.99
  },
  {
    code: 4,
    name: "Haricot Vert",
    price: 3.89
  },
  {
    code: 5,
    name: "Courgette",
    price: 2.5
  }
];

console.table(vegetable);

// .Foreach
console.log("\n---------- Parcours du tableau Vegetables avec .foreach(vegetable) ----------");
// Proche du for...of
vegetable.forEach(function (vegetable) {
  console.log(vegetable.name);
});
console.log("\n---------- Parcours du tableau Vegetables avec .foreach(vegetable,index) ----------");

vegetable.forEach(function (vegetable, index) {
  console.log((index + 1) + " : " + vegetable.name);
});


// .map()
console.log("\n---------- Parcours du tableau Vegetables avec .map(function(){}) ----------");

const listVegetables = vegetable.map(function (vegetable) {
  return vegetable.name;
});
console.table(listVegetables); // Map retourne un nouveau tableau (indexé...)

// .find() => Retourne le premier élément
console.log("\n---------- Parcours du tableau Vegetables avec .find('Poivron') ----------");

const poivron = vegetable.find(function (vegetable) {
  return vegetable.name.includes("Poivron");
})

console.log(poivron);

// .filter() => retourne un tableaux contenant les n occurences
const poivrons = vegetable.filter(function (vegetable) {
  return vegetable.name.includes("Poivron");
})

console.table(poivrons);

/**
 * Les litéraux de gabarit
 * 
 * Nouvelle possibilité de concaténer les variables dans les
 * chaines de caractère à l'aide du nouveau caractère de templating " ` " => backtic (accent grave)
 */
console.log("\n---------- Les litéraux de gabarit ----------");

let prenom = "jean";
let nom = "valjean";

console.log("Bonjour " + prenom + " " + nom);
console.log(`Bonjour ${prenom} ${nom}, tu vas bien?`);


/**
* Destructuring
* 
* Accès simplifié aux élément d'un tableau, d'un objet
*/
console.log("\n---------- Destructuring ----------\n");

// AVEC DES TABLEAUX
const tabNum = [1, 2, 3];
console.table(tabNum);

// // En ES5
// var a = tabNum[0];
// var b = tabNum[1];

// En ES6 avec le destructuring
//const [a, b] = tabNum

// console.log(a);
// console.log(b);

console.table(tabNum);

// Autre exemple avec un tableau associatif
const user = {
  firstname: "Jean",
  lastname: "Dupond",
  age: 35,
  active: false
};

// // En ES5
// var firstname = user.firstname;
// var lastname = user.lastname;

// En ES6 avec le destructuring
const { firstname, lastname } = user;

console.log(firstname);
console.log(lastname);

// // Avec des Fonctions
// function getFullName(user){
//   return `${user.firstname} ${user.lastname}`
// }

// Avec des Fonctions
function getFullName({ firstname, lastname }) {
  return `${firstname} ${lastname}`
}

console.log(getFullName(user))


/**
 * LES FONCTIONS FLECHEES --> Arrow Function
 * 
 * Pour écrire une fonction fléchée nous allons utiliser un opérateur
 * que l'on appelle fat arrow =>
 */
console.log("\n---------- Arrow Function ----------\n");

// Cas 1
// Sans paramètres
let test = function () {
  return "Toto";
}
// Equivalent à
test = () => {
  return "Toto";
}
// Simplification seulement si la fonction ne fait qu'un return
test = () => "Toto";
console.log(test());

// CAS 2
let legume = {
  code: 3,
  name: "Poivron Rouge",
  price: 4.99
}
// Avec paramètres
let test2 = function (vegetable) {
  return vegetable.name;
}
// Equivalent à
test2 = (vegetable) => {
  return vegetable.name;
}
// Simplification seulement si la fonction ne fait qu'un return
test2 = (vegetable) => vegetable.name;
console.log(test2(legume));

// CAS 3
// Avec au moins deux paramètres
let test3 = function (firstname, lastname) {
  return `${firstname} ${lastname}`;
}
// Equivalent à
test3 = (firstname, lastname) => {
  return `${firstname} ${lastname}`;
}
// Simplification seulement si la fonction ne fait qu'un return
test3 = (firstname, lastname) => `${firstname} ${lastname}`;

console.log(test3("Anthony", "Di Persio"));

/**
 * rest operator
 * 
 * ...
 */
console.log("\n---------- rest Operator ----------\n");

//let haricot = vegetable[3]; // crée une réfernece au tableau car la copie n'en est pas vraiment une

let haricot = { ...vegetable[3] }; // une vrai copie car on vient de recréer le tableau associatif (objet) et donc dans ce cas pas de référence

console.log(haricot);
console.log(vegetable[3]);
console.table(vegetable);

haricot.price = 2.99;

console.log(haricot);
console.log(vegetable[3]); // Haricot à modifier le tableau car c'est une référence au tableau
console.table(vegetable);



// Autre exemple avec destructuring
const tabNum2 = [1, 2, 3];
console.table(tabNum);
// //En ES5
// const a = tabNum2[0];
// const b = tabNum2[1];

// En ES6 avec le destructuring nous pouvons l'ecrire :
const [c, ...d] = tabNum2;
console.log(c);
console.log(d);

// console.log(a);
// console.log(b);


/**
 * Valeurs par défaut pour les paramètres d'une fonction
 */
 console.log("\n---------- Valeur par defaut ----------\n");

 function Carre(nb = 10) {
     return nb * nb;
 }
 
 console.log(Carre(5)); // 25
 console.log("Default params : " + Carre()); // 100

 