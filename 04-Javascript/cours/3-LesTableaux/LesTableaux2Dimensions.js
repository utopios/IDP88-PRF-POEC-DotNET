/**
 * Les Tableaux à 2 Dimensions
 */

// Déclaration de deux tableaux numériques
var legumes = ["Carottes", "Choux", "Haricots"];
var fruits = ["Raisin", "Bananes", "Abricots"];

// Affichage des deux tableaux
console.table(legumes);
console.table(fruits);

// Création d'un tableau à 2 dimensions depuis nos deux tableaux numériques
var primeur = [legumes,fruits];
// var primeur = new Array(legumes,fruits); // Equivalent

// Affichage d'un tableau à deux dimensions dans la console
console.table(primeur); 

// Affichage d'un element à un index preci
console.log(primeur[0][0]); // Carrottes
console.log(primeur[1][2]); // Abricots

// Avec une matrice de tableaux associatifs

var zoo = [
    {
        pseudo:"Simba",
        espece:"Lion",
        continent:"Afrique",
    },
    {
        pseudo:"Tony",
        espece:"Kangouroo",
        continent:"Océanie",
    },
];

// Affichage dans la console des pseudos
console.table(zoo); 
console.log("Les pseudos sont "+zoo[0].pseudo+" et "+zoo[1]["pseudo"]);