import Mammifere from "./Mammifere.js";

export default class Person extends Mammifere{
    
    constructor(nom, prenom){
        super( nom,'Humain');
        this.Prenom = prenom;
        this.Nom = nom;
    }

    Display(){
        console.log(this);
    }
}