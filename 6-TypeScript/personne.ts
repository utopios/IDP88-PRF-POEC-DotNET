export class Personne {
    //Attributs
    nom:String
    prenom:String

    constructor(n:String, p:String) {
        this.nom = n
        this.prenom = p
    }

    afficher():void {
        console.log(this.nom + " "+this.prenom)
    }

    nomComplet():String {
        return this.nom + " "+ this.prenom
    }
    
}