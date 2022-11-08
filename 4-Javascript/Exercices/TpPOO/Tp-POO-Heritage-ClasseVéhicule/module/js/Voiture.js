import Vehicule from "./Vehicule.js";

export default class Voiture extends Vehicule{
    constructor(marque, modele, kilometrage, annee, clim){
        super(marque, modele, kilometrage, annee);
        this.clim = clim;
    }



    // Override de la méthode display de la classe parent ( spécification )
    display(){
        return(`<b>Voiture : </b> ${super.display()} -  ${this.clim?"Climatisée":"Non Climatisée"}`)
    }
}

