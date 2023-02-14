/**
 * EXERCICE05 - Les Variables et Opérateurs Arithmétiques - Traitement d'une chaine
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var chaine,
    chaineMEF,   
    affichage;

// Insertion du titre dans la chaine affichage
affichage = "<h3>Traitement d'une chaine de caractères</h3><br>";

// Récupération mot utilisateur
chaine = prompt("Veuillez saisir la chaîne à traiter :");

// affichage du mot de l'utilisateur
affichage += `Vous avez saisi : <b>${chaine}</b> <br>`

// Mise en minuscule et en tableau de la chaine 
affichage += `<br>La chaîne en minuscule : <b>${chaine.toLowerCase()}</b> <br>`

// Mise en tableau de la chaine
chaineMEF = chaine.toLowerCase().split('');
affichage += `<br>Mise en tableau : <b>${chaineMEF}</b> <br>`;
x=>{

}

// Mise en majuscule des premiere lettres de chaques mots
chaineMEF = chaine.toLowerCase().split(' ').map(x=>x[0].toUpperCase()+x.slice(1)).join(' ');
affichage += `<br>La chaîne après traitement : <b>${chaineMEF}</b> <br>`

// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;