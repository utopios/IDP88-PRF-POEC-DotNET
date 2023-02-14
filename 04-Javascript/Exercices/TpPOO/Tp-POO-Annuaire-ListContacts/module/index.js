import Contact from './js/Contact.js';

// Récupération des éléments du DOM
const tableau = document.querySelector('#tableau');
const btnValider = document.querySelector('#btnValider');

// Variable globale à l'app
const Contacts = new Array();


// Click Bouton Ajouter
btnValider.onclick = () => {
    // Récupération des saisies utilisateur
    const nom = document.querySelector('#Nom').value;
    const prenom = document.querySelector('#Prenom').value;
    const dateNaissance = new Date(document.querySelector('#dateNaissance').value).toLocaleDateString();
    const telephone = document.querySelector('#Telephone').value;
    const email = document.querySelector('#Email').value;

    // Récupérer la valeur des btn Radios
    const titre = document.getElementById('Mr').checked ? "Mr" : "Mme";

    // let titres;
    // if (document.getElementById('Mr').checked)
    //     titre = "Mr";
    // else
    //     titre = "Mme";

    console.log(dateNaissance);

    if (nom != "" && prenom != "" && dateNaissance != "" && telephone != "" && email != "" && titre != "") {
        // Instanciation de notre objet Contact
        let tmp = new Contact(titre, nom, prenom, dateNaissance, telephone, email);
        // console.log(tmp);
        Contacts.push(tmp);
        //console.table(Contacts);
        updateTab();
        resetForm();
    } else {
        alert("Veuillez renseigner tous les champs...");
    }

}

function createFakeContact() {
    // Création d'un tableau de personne à deux dimensions
    let annuaire = [
        {
            titre: "Mr",
            nom: "Dupont",
            prenom: "Jean",
            dateNaissance: "1973,10,08",
            telephone: "+(33)6 12 36 54 78",
            email: "jdupont@gmail.com"
        },
        {
            titre: "Mme",
            nom: "Doe",
            prenom: "Jeanne",
            dateNaissance: "1985,02,24",
            telephone: "+(33)6 45 23 87 14",
            email: "jdoe@yahoo.fr"
        },
        {
            titre: "Mr",
            nom: "Martin",
            prenom: "Jacques",
            dateNaissance: "1933,06,22",
            telephone: "+(33)6 78 45 24 95",
            email: "jmartin@petitrapporteur.fr"
        }
    ];

    // Ajout des contact à la collection Contacts
    for (let contact of annuaire) {
        let tmp = new Contact(contact.titre, contact.nom, contact.prenom, new Date(contact.dateNaissance).toLocaleDateString(), contact.telephone, contact.email);
        Contacts.push(tmp);
    }
    console.table(Contacts);
}

function updateTab() {
    // On vide le tableau
    tableau.innerHTML = '';
    // On le rempli des nouvelles valeurs
    for (let i = 0; i < Contacts.length; i++) {
        tableau.innerHTML += `<tr onclick="Delete(${i})">
            <td>${i + 1}</td>
            <td>${Contacts[i].titre}</td>
            <td>${Contacts[i].nom}</td>
            <td>${Contacts[i].prenom}</td>
            <td>${Contacts[i].dateNaissance}</td>
            <td>${Contacts[i].telephone}</td>
            <td>${Contacts[i].email}</td>
            <td><i class="fa-solid fa-trash-can" ></i></td>
        </tr>        
        `
    }
}

function resetForm() {
    document.querySelector('#Nom').value = "";
    document.querySelector('#Prenom').value = "";
    document.querySelector('#dateNaissance').value = "";
    document.querySelector('#Telephone').value = "";
    document.querySelector('#Email').value = "";

}

function Delete(id) {
    //console.log(id);
    if (confirm(`Etes-vous sur de vouloir supprimer le contact n°${id+1}?`)) {
        Contacts.splice(id, 1);
        updateTab();
    } else {
        alert("Vous avez annulé la suppression");
    }
}

function init() {
    createFakeContact();
    updateTab();
}

window.Delete = Delete;
window.onload = init();

