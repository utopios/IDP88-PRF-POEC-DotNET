/**
 * Exercice17Bis - IfElse - Calcul Impôts HTML
 */
// Déclaration variables
let revenus = 0,
    nbAdulte = 0,
    nbEnfants = 0,
    nbParts = 0,
    revenuIMpossable = 0,
    montantImpot = 0;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const btnValider = document.querySelector('#btnValider');

function calculNbParts() {
    return nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
}

function Afficher() {
    // Injection du résultat dans l'element HTML .result
    result.innerHTML = `Le montant de l'impôt sur le revenu pour un foyer composé de <b>${nbAdulte} adulte(s)</b> et
                de <b>${nbEnfants} enfant(s)</b>, avec un revenu fiscal de <b>${revenus}€</b> 
                s'élève à <b>${Math.round(montantImpot)}€</b>`;
}

function resetInput() {
    document.querySelector('#revenu').value = "";
    document.querySelector('#nbAdulte').value = "";
    document.querySelector('#nbEnfant').value = "";
}

// Fonction Valider()
Valider = () => {
    montantImpot = 0;
    // Récupération et stockage des saisies utilisateur
    revenus = parseInt(document.querySelector('#revenu').value);
    nbAdulte = parseInt(document.querySelector('#nbAdulte').value);
    nbEnfants = parseInt(document.querySelector('#nbEnfant').value);

    // Sugar Syntaxe(ternaire) pour le Calcul du nombre de parts
    nbParts = calculNbParts();

    // Etablissement Structure If() pour calculer le montant de l'impôt
    revenuImposable = revenus / nbParts;

    // Sugar Syntaxe ternaire conditionnel calcul montant impôts
    if (revenuImposable > 10225) {
        montantImpot += (revenuImposable > 26070) ? (revenuImposable > 74545) ? (revenuImposable > 160336) ?
            ((revenuImposable - 160336) * 0.45) + ((160336 - 74546) * 0.41) + ((74545 - 26070) * 0.3) + ((26070 - 10225) * 0.11) :
            ((revenuImposable - 74546) * 0.41) + ((74545 - 26070) * 0.3) + ((26070 - 10225) * 0.11) :
            ((revenuImposable - 26070) * 0.3) + ((26070 - 10225) * 0.11) :
            (revenuImposable - 10225) * 0.11;
    }

    // Calcul du montant réel de l'impôt
    montantImpot *= nbParts;


    resetInput();
    Afficher();


}