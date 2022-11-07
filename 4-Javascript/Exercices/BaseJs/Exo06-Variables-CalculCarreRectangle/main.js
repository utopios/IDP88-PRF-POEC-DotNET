/**
 * EXERCICE06 - Les Variables et Opérateurs Arithmetiques - Calcul du périmètre et de l'aire d'un Carré / Rectangle
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var cote = 0,
    longueur = 0,
    largeur = 0,
    perimetreCarre = 0,
    aireCarre = 0,
    perimetreRectangle = 0,
    aireRectangle = 0,
    affichage = "";

/*
    Carré
*/

affichage = "<h3>Calcul de l'aire et du périmètre d'un carré</h3>";

// Récupération et stockage des saisies utilisateur
cote = Number(prompt("Saisir la longueur du coté (en cm) :"));

// Celcul du périmètre
perimetreCarre = cote * 4;

// Calcul de l'aire
aireCarre = cote * cote;

// Redaction de l'affichage
affichage += `Les longueurs des cotés du carré étant de <b>${cote}cm</b>,
<ul>
            <li>Le périmètre de ce carré est de <b>${perimetreCarre}cm</b></li>
            <li>L'aire de ce carré est de <b>${aireCarre}cm²</b></li>
</ul>
<hr><br>
`;

/*
    Rectangle
*/

affichage += "<h3>Calcul de l'aire et du périmètre d'un rectangle</h3>";

// Récupération et stockage des saisies utilisateur
longueur = Number(prompt("Saisir la longueur du rectangle (en cm) :"));
largeur = Number(prompt("Saisir la largeur du rectangle (en cm) :"));

// Celcul du périmètre
perimetreRectangle = (longueur + largeur) * 2;

// Calcul de l'aire
aireRectangle = longueur * largeur;

// Redaction de l'affichage
affichage += `Les longueurs des cotés du rectangle étant de <b>${longueur}cm</b> pour la longueur,
              et de <b>${largeur}cm</b> pour la largeur
<ul>
            <li>Le périmètre de ce rectangle est de <b>${perimetreRectangle}cm</b></li>
            <li>L'aire de ce rectangle est de <b>${aireRectangle}cm²</b></li>
</ul>
<hr>
`;

// Affichage du résultat en alert()
//alert(affichage);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;