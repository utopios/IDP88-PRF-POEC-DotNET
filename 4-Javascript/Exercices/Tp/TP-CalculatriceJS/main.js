// Récupération des elements du DOM
const touches = [...document.querySelectorAll('.bouton')];
const listeKeycode = touches.map(touche => touche.dataset.key);
const ecranHaut = document.querySelector('.ecranHaut');
const ecranBas = document.querySelector('.ecranBas');

// Ecouteur évenement Keydown
document.addEventListener('keydown', (e) => {
    let valeur = e.keyCode.toString(); // Deprecated
    console.log("Keycode : " + valeur);
    valeur = e.key.toString();
    console.log("Key : " + valeur);
    calculer(valeur)
})

// Ecouteur évenement click
document.addEventListener('click', (e) => {
    const valeur = e.target.dataset.key;
    calculer(valeur)
})

// Fonction permettant d'effectuer les actions des touches
const calculer = (valeur) => {
    if (listeKeycode.includes(valeur)) {
        switch (valeur) {
            case '8':// touche 'c'
                ecranHaut.textContent = ""; // clear écranHaut
                ecranBas.textContent = ""; // clear écranBas
                break;
            case '13':// touche 'Enter'
                const calcul = eval(ecranHaut.textContent);// Stockage dans calcul du retour de la fonction eval
                ecranBas.textContent = "= " + calcul;// Affichage dans la <div class="ecran"></div>
                //ecranBas.textContent = ""; // clear écranBas
                break;
            default:
                const indexKeycode = listeKeycode.indexOf(valeur);
                const touche = touches[indexKeycode];
                ecranHaut.textContent += touche.innerHTML;
                ecranBas.textContent = touche.innerHTML;
        }
    }
}

window.addEventListener('error', (e) => {
    alert('Une erreur est apparue : ' + e.message)
})