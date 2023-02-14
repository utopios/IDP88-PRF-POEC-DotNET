/**
 * EXERCICE09BIS - Les Variables et Opérateurs Arithmetiques - Calcul taux intérêts
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const inputCI = document.querySelector('#capitalInitial');
const inputTaux = document.querySelector('#taux');
const inputDuree = document.querySelector('#duree');
const result = document.querySelector('.result');

// Declaration des variables
let capitalInitial = 0,
    tauxInterets = 0,
    duree = 0,
    capitalFinal = 0,
    interets = 0;

function Valider() {
    // Récupération et stockage des saisie utilisateur
    capitalInitial = Number(inputCI.value);
    tauxInterets = parseInt(inputTaux.value);
    duree = Number(inputDuree.value);
    // Calcul des intérêts
    capitalFinal = Math.round(capitalInitial * Math.pow(1 + (tauxInterets / 100), duree));
    interets = Math.round(capitalFinal - capitalInitial);
    DisplayResult()
}


function DisplayResult() {
    // Redaction de l'affichage
    result.innerHTML = `Avec un capital initial de <b>${capitalInitial}€</b>, placé à <b>${tauxInterets}%</b> pendant <b>${duree} année(s)</b>,
    <ul>
                <li>Le montant total des intérêts s'élévera à <b>${interets}€</b></li>
                <li>Le capital final à l'issue sera de <b>${capitalFinal}€</b></li>
    </ul>`;

}
