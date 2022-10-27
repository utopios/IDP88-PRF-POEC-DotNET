/**
 * EXERCICE03 - Les Variables et Opérateurs Arithmétiques - L'objet Math en Javascript
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des variables
var diametre,
    perimetre,
    aire,
    resultat,
    affichage;

// Déclaration de constante
const pi=Math.PI;// Affectation a pi de Math.PI

affichage = "<h3>Utilisation des fonctions() de l'objet Math</h3><br>";

// Affichage de PI
affichage+="<h5>Utilisation de la constante &#960; (pi)</h4>"
affichage+=`La valeur de <b>&#960</b> est : <b>${pi}</b><br>`

// Calcul du diamètre d'un cercle
affichage+="<br><h5>Calcul du périmètre <i>(d x &#960;)</i> et de l'aire <i>(&#960; * r²)</i> d'un cercle </h4>"
diametre=Number(prompt("Veuillez saisir le diamètre du cercle"));
perimetre=diametre*pi;
aire=pi*Math.pow((diametre/2),2);
affichage+=`Diamètre = <b>${diametre}cm</b><br>
            Périmètre = <b>${perimetre}cm</b><br>
            Aire = <b>${aire}cm²</b><br>
            Périmètre<i>(arrondi)</i> = <b>${Math.round(perimetre)}cm</b><br>
            Aire<i>(arrondi)</i> = <b>${Math.round(aire)}cm²</b><br>`


// Injection du résultat dans l'element HTML .result
result.innerHTML = `${affichage}`;