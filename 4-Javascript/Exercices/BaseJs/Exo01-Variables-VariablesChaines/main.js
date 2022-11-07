/**
 * EXERCICE01 - Les Variables et Opérateurs Arithmétiques - Les variables type chaîne de caractères
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var prenom = "",
    nom = "",
    resultat="",
    affichage="";

affichage = "<h3>Addition de deux variables type chaîne (Concaténation)</h3>";

// Récupération et stockage des saisies utilisateur
prenom = prompt("Saisir votre prénom :");
affichage += `Vous avez saisi : <b>${prenom}</b> <br />`
nom = prompt("Saisir votre nom :");
affichage += `Vous avez saisi : <b>${nom}</b> <br />`

// Addition des deux chaine
resultat = prenom + " " + nom;

// Redaction de l'affichage
affichage += `Bonjour <b>${resultat}</b><hr />`;



// Affichage du résultat en alert()
//alert(affichage);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;