import Mammifere from "./Mammifere.js";

export default class Chien extends Mammifere{
    // constructor(nom,type){
    //     super(nom,type);
    // }

    Alimentation(){
        console.log("Je me nourris je croquette.. et d'os à moelle");
    }

    Respiration(){
        console.log("Inspiration... Expiration... J'ai des poumons");
    }

    Aboyer(){
        if(this.heartRate)
            console.log("Wouaf!");
        else
            console.log("Je ne peux pas... je ne suis plus!");
    }
}