/**
 * EXERCICE07 - Les Variables et Opérateurs Arithmetiques - Calcul de la Longueur de l'hypoténuse
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des constantes elail et mdp
var cote1 = 0,
    cote2 = 0,
    sommeCarre=0,
    hypotenuse = 0;

// Récupération et stockage des saisie utilisateur
cote1 = Number(prompt("Saisir la longueur du 1er coté (en cm) :"));
cote2 = Number(prompt("Saisir la longueur du 2nd coté (en cm) :"));

// Math Pow() permet d'elever une valeur à la puissance demandée
sommeCarre = Math.pow(cote1, 2) + Math.pow(cote2, 2);

// Math Round() permet d'arrondir une valeur 
hypotenuse = Math.round(Math.sqrt(sommeCarre+Number.EPSILON)*100)/100;

// Redaction de l'affichage
resultat = `Les longueurs des cotés adjacents à l'angle droit étant de <b>${cote1}cm</b> et de <b>${cote2}cm</b>,
<ul>
            <li>La longueur de l'hypoténuse est de <b>${hypotenuse}cm</b></li>
</ul>`;

// Affichage du résultat en alert()
//alert(resultat);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${resultat}`;