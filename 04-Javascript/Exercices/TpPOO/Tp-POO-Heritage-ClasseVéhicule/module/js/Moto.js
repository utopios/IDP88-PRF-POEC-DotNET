import Vehicule from "./Vehicule.js";

export default class Moto extends Vehicule{

    // Override de la méthode display de la classe parent ( spécification )
    display(){
        return(`<b>Moto : </b> ${super.display()}`)
    }
}