/**
 * EXERCICE08 - Les Variables et Opérateurs Arithmetiques - Calcul montant de la T.V.A
 */

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Declaration des constantes email et mdp
var prixObjetHt = 0,
    tauxTva = 0,
    mtTva = 0,
    prixObjetTtc = 0;

// Récupération et stockage des saisie utilisateur
prixObjetHt = Number(prompt("Saisir Les prix de l'objet H.T :"));
tauxTva = Number(prompt("Saisir le taux de T.V.A applicable :"));

// Calcul de la T.V.A et du montant T.T.C
mtTva = Math.round(prixObjetHt * tauxTva / 100);
prixObjetTtc = prixObjetHt + mtTva;

// Redaction de l'affichage
resultat = `Le prix H.T de l'objet étant de <b>${prixObjetHt}€</b>, avec un taux de T.V.A applicable de <b>${tauxTva}%</b>,
<ul>
            <li>Le montant de la T.V.A s'élévera à <b>${mtTva}€</b></li>
            <li>Le prix T.T.C de l'objet sera de <b>${prixObjetTtc}€</b></li>
</ul>`;

// Affichage du résultat en alert()
//alert(resultat);
// Injection du résultat dans l'element HTML .result
result.innerHTML = `${resultat}`;