/**
 * Exercice16 - IfElse - Prime de licenciement
 */

// Déclaration variable
let indemnite = 0;
let salaire = 0;
let anciennete = 0;
let age = 0;

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');
const btnValider = document.querySelector('#btnValider');



Valider=()=>{

    // Récupération et stockage des saisies utilisateur
    salaire = parseInt(document.querySelector('#Salaire').value);
    anciennete = parseInt(document.querySelector('#Anciennete').value);
    age = parseInt(document.querySelector('#Age').value);

    

    // Etablissement Structure If() pour calculer le montant de la prime
    if (anciennete >= 1 && anciennete <= 10) {
        indemnite += anciennete * salaire / 2;
        console.log(indemnite);
    }
    else if (anciennete > 10) {
        indemnite += 10 * salaire / 2;
        indemnite += (anciennete - 10) * salaire;
        console.log(indemnite);

    }
    
    if (age > 45 && anciennete >= 1) {
        indemnite += (age < 50) ? 2 * salaire : 5 * salaire;
        console.log(indemnite);
    }
    result.innerHTML = `Le montant de l'indemnité pour un salaire de <b>${salaire}€</b> pour un salarié de 
    <b>${age} ans</b> avec une ancienneté de <b>${anciennete} années</b> s'élève à <b>${indemnite}€</b>`;

}
