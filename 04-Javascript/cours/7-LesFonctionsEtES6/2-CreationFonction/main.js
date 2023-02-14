/**
 * Création de fonctions
 */

/** FONCTIONS NATIVES
 * // Afficher une alert à l'utilisateur (alert())
        alert("Coucou toi!");

   // Demander une saisie à l'utilisateur (prompt())
        var firstname = prompt("Quel est votre prénom ?");

        console.log(`Votre prénom est ${firstname}.`); // Affichage du prénom saisie
 */

/**
 * Les Fonction non-natives (user)
 */

// Fonction Sans parametres et sans retour
function hello() {
  // Corps de la fonction => Instruction ci-dessous setont executees
  console.log("Hello World");
}

// Appel à la fonction
hello();

// Fonction Avec parametres et sans retour
function helloParams(firstanme = "Anthony") {
  // Corps de la fonction => Instruction ci-dessous setont executees
  console.log(`Hello ${firstanme}`);
}

// Appel à la fonction
helloParams("Julie");

// Fonction Avec parametres et avec retour
function helloReturn(firstanme = "Anthony") {
  // Création d'une variable chaine contenant la concaténation des params
  let chaine = `Hello ${firstanme}`
  // Retourn la variable
  return chaine;
}
// Récupération de notre element du DOM result
const result = document.querySelector('.result');
// Déclaration de la fonction Display
function Display(chaine) {
  result.innerHTML = chaine;
}

// Appel à la fonction
let maChaine = helloReturn("Sarah");
console.log(maChaine);

// Avec des valeur issues de saisie utilisateur
let firstname = prompt("Veuillez saisir votre prénom : ");
let display = helloReturn(firstname);
// console.log(display)
Display(display);

//Display(helloReturn(prompt("Veuillez saisir votre prénom : ")))

