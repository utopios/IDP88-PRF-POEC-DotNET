import { Avion } from "./avion";
import { Maison } from "./maison";
import { Voiture } from "./voiture";

const maisonVoitures = new Maison<Voiture>()
let v1 =new Voiture();
maisonVoitures.elements.push(v1);
let a1 = new Avion()
maisonVoitures.elements.push(a1);

const maisonAvions = new Maison<Avion>()