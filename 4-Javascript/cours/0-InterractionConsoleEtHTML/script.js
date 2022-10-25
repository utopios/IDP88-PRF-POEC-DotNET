/**
 * Interragir avec la console
 */

// Récupérer l'element du DOM qui nous interesse
const result = document.querySelector('#result');

var prenom = "Anthony", 
    age,
    resultat="";

// Affichage d'une valeur dans la console
console.log(prenom);

// console.log("Veuillez saisir votre prenom : ");
prenom = prompt("Veuillez saisir votre prenom : ");
age = Number(prompt("Veuillez saisir votre age : "));
console.log(typeof(age));
age +=1;

resultat ="Votre prénom est : " + prenom + " est dans un an votre age sera " + age + " ans.";

// Affichage dans notre eleme nt du DOM pas le biais de la propièté innerHTML
result.innerHTML += resultat;