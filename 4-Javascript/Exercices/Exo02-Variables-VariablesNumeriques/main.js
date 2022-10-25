/**
 * EXERCICE02 - Les Variables et Opérateurs Arithmetiques - Les variables numériques
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var nb1 = 0,
    nb2 = 0,
    resultat,
    affichage;

affichage = "<h3>Addition de deux variables numériques</h3>";

// Récupération et stockage des saisies utilisateur
nb1 = Number(prompt("Saisir le premier nombre :"));
affichage += `Vous avez saisi <b>${nb1}</b> <br>`
nb2 = Number(prompt("Saisir le deuxième nombre :"));
affichage += `Vous avez saisi <b>${nb2}</b> <br>`

// Addition des deux nombres
resultat = nb1 + nb2;

// Redaction de l'affichage
affichage += `La somme de <b>${nb1}</b> + <b>${nb2}</b> = <b>${resultat}</b><hr>`;



// Affichage du résultat en alert()
//alert(affichage);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;