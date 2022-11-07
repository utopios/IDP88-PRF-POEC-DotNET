import Person from './js/Person.js'

let persons = new Array();
// Dans un autre fichier

let p1 = new Person();
p1.Nom="Di Persio";
p1.Prenom="Anthony";
// console.log(p1);
persons.push(p1);
p1.Display();

let p2 = new Person("Dark", "Jeanne");
persons.push(p2);
p2.Display();

for(let person of persons){
    person.Display();
}