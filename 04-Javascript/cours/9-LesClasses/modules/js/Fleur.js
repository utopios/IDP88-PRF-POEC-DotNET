import Vegetaux from "./Vegetaux.js";

export default class Fleur extends Vegetaux{
    constructor(nom,type){
        super(nom,type);
        this.Naissance();
    }

    Naissance (){
        console.log("Je viens d'une graine ou d'un bulbe...");
        this.photosyntese = true;
    }

    
    Mort (){
        console.log("Je fane");
        this.photosyntese = false;
    }
}