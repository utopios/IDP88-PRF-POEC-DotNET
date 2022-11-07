import EtreVivant from "./EtreVivant";


export default class Mammifere extends EtreVivant{
    constructor(nom,type){
        super(nom,type);
        this.heartRate = false;
        this.Naissance();
    }

    Naissance(){
        super.Naissance();
        console.log("Naissance après une période de gestation");
        this.heartRate = true;
    }
    Mort(){
        console.log("Mon coeur s'arrete de battre...")
        this.heartRate = false;
    }
}