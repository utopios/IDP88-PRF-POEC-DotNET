import EtreVivant from "./EtreVivant.js";

export default class Vegetaux extends EtreVivant {
    constructor(nom, type) {
        super(nom, type);
        this.photosyntese = false;
    }

    Alimentation() {
        console.log("Je me nouris par les racines... Et le soleil.");
    }

    Respiration() {
        console.log("Le jour je rejette de l'O2, la nuit je rejette du CO2");
    }

}