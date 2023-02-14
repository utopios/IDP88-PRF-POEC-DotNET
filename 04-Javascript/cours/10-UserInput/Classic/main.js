const result = document.querySelector('#result');

let message="",
    Nom,
    Prenom;

Valider = () => {   
    Nom = document.querySelector('#nom').value;
    Prenom = document.querySelector('#prenom').value;   
    Afficher();
}

Afficher = () => {
    result.innerHTML = `<h3>Vous avez saisi : ${Nom}  ${Prenom}</h3>`;
    result.textContent += "\n et du texte en plus";
}






