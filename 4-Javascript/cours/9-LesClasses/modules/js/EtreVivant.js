
export default class EtreVivant {
    constructor(nom, type) {
        this.nom = nom;
        this.type = type;
    }

    Naissance(){
        console.log("Tous les etres vivant naissent");
    }
    Mort(){
        console.log("Tous les etres vivant meurent...");
    }
    Respiration(){
        console.log("Tous les etres vivant respirent...à leur maniere");
    }
    Alimentation(){
        console.log("Tous les etres vivant s'alimentent.. à leur maniere");
    }
}