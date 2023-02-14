import Person from './js/Person.js'
import Fleur from './js/Fleur.js'
import Chien from './js/Chien.js'

const BtnValider = document.querySelector('#ValiderBtn');


BtnValider.onclick = () => {
    alert("Ca marche!");
}

/**
 * PERSON
 */
// Création d'un tableau de personne
let persons = new Array();
// Dans un autre fichier

let p1 = new Person();
p1.Nom = "Di Persio";
p1.Prenom = "Anthony";
// console.log(p1);
persons.push(p1);
p1.Display();

let p2 = new Person("Dark", "Jeanne");
persons.push(p2);
p2.Display();

for (let person of persons) {
    person.Display();
}

/**
 * Manipulation depuis la classe EtreVivant
 */

let medor = new Chien("Médor", "Berger Allemand");
let cosmos = new Fleur("Cosmos", "Cosmos Sulphuréus");



let etreVivants = [medor, cosmos, p1, p2];

for (let etre of etreVivants) {
    console.log(`------- ${etre.nom} -------`);
    etre.Naissance();
    etre.Respiration();
    etre.Alimentation();
    etre.Mort();
    console.log("---------------------------")

}

console.log("Battement de coeur de Médor : " + medor.heartRate);
console.log("Battement de coeur de Cosmos : " + cosmos.photosyntese);
// medor.Mort();
medor.Aboyer();


