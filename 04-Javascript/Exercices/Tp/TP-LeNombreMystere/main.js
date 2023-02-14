/**
 * TP - Le Nombre Mystère
 */

// Déclaration variables
let nbMystere = 0,
    nbCoups = 0,
    gagne = false;

// Récupération des éléments du DOM
const ligne1 = document.querySelector('#ligne1');
const ligne2 = document.querySelector('#ligne2');
const nbCoupsHTML = document.querySelector('#nbCoups');
const nbUser = document.querySelector('#nbUser');
const validerBtn = document.querySelector('#valider');



function StartGame() {
    // Génération d'un nombre Aléatoire
    nbMystere = Math.floor(Math.random() * (50 - 1)) + 1;
    nbCoups = 0;

    // Initialisation des champs HTML et boutons
    nbCoupsHTML.textContent = " " + nbCoups;
    ligne1.textContent = `J'ai généré un nombre entre 1 et 50 inclus`;
    ligne2.textContent = `Essayez de le deviner en proposant ci-dessous`;
    nbUser.value = "";
    validerBtn.disabled = false;
    gagne = false;
}

// Fonction pour actualiser le nb de coup ( Jeu + html)
function UpdateNbCoups() {
    nbCoups++;
    nbCoupsHTML.textContent = nbCoups;
}

// Fonction valider déclenchée par le bouton
function Valider() {

    // Récupération de la valeur saisie dans l'input
    let nbTmp = parseInt(nbUser.value);

    // Test logique
    if (nbTmp === nbMystere) {
        UpdateNbCoups();        
        EndGame();
    }
    else if (nbTmp < nbMystere) {
        UpdateNbCoups();
        ligne1.textContent = `Le nombre mystère est plus grand que ${nbTmp}`;
    }
    else {
        UpdateNbCoups();
        ligne1.textContent = `Le nombre mystère est plus petit que ${nbTmp}`;
    }
    nbUser.value = "";
}

document.addEventListener("keyup", function (event) {
    if (event.key === "Enter" && !gagne) {
        Valider();
    }
});

// Fonction EndGame
function EndGame() {
    ligne1.textContent = `Bravo...! ! ! Vous avez trouvé en ${nbCoups} coups!`;
    ligne2.textContent = `Le nombre mystère était ${nbMystere}!`;
    validerBtn.disabled = true;
    gagne = true;
}

// Recharge la page pour redemarrer une partie
function Rejouer() {
    StartGame();
}

window.onload = StartGame();
