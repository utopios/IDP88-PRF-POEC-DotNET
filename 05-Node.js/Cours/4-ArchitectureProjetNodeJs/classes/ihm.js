import {askQuestion} from '../tools/helper.js';

export default class Ihm {
    constructor() {
        this.personnes = [];
    }

    async menu() {
        let choix;
        do {
            console.log("***** Annuaire - Tp List Contact *****");
            console.log("1- Ajouter une personne");
            console.log("2- Afficher la liste des personnes");
            console.log("0-- Quitter");
            choix = await askQuestion("Veuillez faire votre choix :")
            switch (choix) {
                case "1":
                    const nom = await askQuestion("Veuillez saisir un nom : ");
                    const prenom = await askQuestion("Veuillez saisir un prenom : ");
                    this.personnes.push({nom:nom,prenom:prenom});
                    break;
                case "2":
              
                    this.personnes.forEach(person => {
                        console.log(`Nom : ${person.nom} - Prénom : ${person.prenom}`)
                    })
                    break;
                default:
                    console.log("Veuillez faire le choix 0 ou 1 ou 2");
                    break;
            }

        } while (choix != '0')
        console.log(" A bientôt... !")
    }
}