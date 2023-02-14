// import de Vehicule
import Vehicule from './js/Vehicule.js';

const btnPayer = document.querySelector('#paymentBtn');
const btnEnter = document.querySelector('#enterBtn');
const licencePlate = document.querySelector('#licencePlate');
const successBox = document.querySelector('#successBox');
const alertBox = document.querySelector('#alertBox');
const messageBox = document.querySelector('#messageBox');
const vehicules = new Array();


btnEnter.onclick = () => {
    // récupération de la du véhicule
    const vehicule = findCar();

    console.log(vehicule);
    // vérification de la présence du véhicule
    if (!vehicule) {
        if (licencePlate.value != '') {
            console.log("LicencePlate : " + licencePlate.value)
            addtoPark();
        }
        else {
            displayBox(alertBox, "Veuillez saisir votre immatriculation ", 3000);
        }
    }
    else {
        if (vehicule.endDate != '') {
            addtoPark();
        }
        else {
            displayBox(alertBox, `Le véhicule ${licencePlate.value} est déjà présent dans le parking`, 3000);
        }
    }
    console.table(vehicules);
    resetInput();
}

btnPayer.onclick = () => {
    // déclaration des variable locale à la fonction
    let duree, prix = 0;
    // récupération de la plaque
    const vehicule = findCar();
    // vérification de la présence du véhicule
    if (vehicule != undefined) {
        if (vehicule.endDate == '') {
            // definir une end date
            vehicule._endDate = new Date();
            vehicule.changeEndDate(new Date());
            //console.log("EndDate : " + vehicule.endDate)

            // calculer la duree
            duree = (vehicule.endDate - vehicule.startDate) / 60000;
            // calculer le prix
            switch (true) {
                case duree <= 15:
                    prix = 0.8;
                    break;
                case duree <= 30:
                    prix = 1.3;
                    break;
                case duree <= 45:
                    prix = 1.7;
                    break;
                default:
                    prix = 6
                    break;
            }
            console.log(prix)
            // affichage du prix
            displayBox(messageBox, `Le prix à payer pour le véhicule ${licencePlate.value} et de ${prix}€`, 3000);

        } else
            displayBox(alertBox, `Le véhicule ${licencePlate.value} a déjà soldé le parking`, 3000);

    } else
        displayBox(alertBox, `Le véhicule ${licencePlate.value} n'est pas présent dans le parking`, 3000);

    resetInput();
}

function resetInput() {
    licencePlate.value = '';
}

function findCar() {
    // trouver un véhicule en fonction de la plaque
    return vehicules.findLast(vehicule => {
        return vehicule.id == licencePlate.value
    });
}

function addtoPark() {
    //console.log("ca marche");
    vehicules.push(new Vehicule(licencePlate.value));
    //console.table(vehicules);
    displayBox(successBox, "Veuillez prendre votre ticket pour le véhicule " + licencePlate.value, 3000);
}

function displayBox(domElement, message, delay) {
    domElement.style.display = "block";
    domElement.textContent = message;
    setTimeout(() => {
        domElement.style.display = "none";
    }, delay);
}


function init() {
    // Ajouter des véhicules à la liste
    vehicules.push(new Vehicule('AA-123-AA', new Date("2022-11-09T11:45:00")));
    vehicules.push(new Vehicule('BB-123-BB', new Date("2022-11-09T11:30:00")));
    vehicules.push(new Vehicule('CC-123-CC', new Date("2022-11-08T10:00:00")));

    console.table(vehicules);
    // initialisation des champ / Objets
    alertBox.style.display = "none";
    successBox.style.display = "none";
    messageBox.style.display = "none";


}

window.onload = init();