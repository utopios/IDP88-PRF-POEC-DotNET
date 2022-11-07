export default class Person {
    
    constructor(nom, prenom){
        this.Prenom = prenom;
        this.Nom = nom;
    }

    Display(){
        console.log(this);
    }
}