import {millier} from '../../../../../Ressources/helpers.js'

export default class Vehicule{
    constructor(marque, modele, kilometrage, annee){
        this.marque = marque;
        this.modele = modele;
        this.kilometrage = kilometrage;
        this.annee = annee;
    }

    // // Méthode permettant de séparer le millier
    // millier(nbr , symbol ) {
    //     let nombre = '' + nbr;
    //     let retour = '';
    //     let count = 0;
    //     for (let i = nombre.length - 1; i >= 0; i--) {
    //         if (count != 0 && count % 3 == 0)
    //             retour = nombre[i] + symbol + retour;
    //         else
    //             retour = nombre[i] + retour;
    //         count++;
    //     }       
    //     return retour;
    // }

    display(){
        return(`${this.marque} - ${this.modele} - ${millier(this.kilometrage , ".")}km - ${this.annee}`)
    }
}