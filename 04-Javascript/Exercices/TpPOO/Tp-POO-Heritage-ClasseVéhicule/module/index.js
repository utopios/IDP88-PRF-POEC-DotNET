import Voiture from './js/Voiture.js';
import Moto from './js/Moto.js';

const result = document.querySelector('.result');


let voiture1 = new Voiture( "Ranault", "kangoo",140000, 2003, true)
let moto1 = new Moto( "BMW", "R1150R Rockster",68000, 2005 )

result.innerHTML += `<div>${voiture1.display()}</div>`;
result.innerHTML +=  `<div>${moto1.display()}</div>`;