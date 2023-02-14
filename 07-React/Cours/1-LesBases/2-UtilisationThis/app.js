// Création de constantes à partir des éléments HTML
const result = document.querySelector('#app');
const link = document.querySelector('#link');

// Propagation d'un événement Avec fonction flechée
link.addEventListener('click', (event) => {
    alert(`ArrowFunction this = ${this} and event source is : ${event}`);// this === window
});

// Propagation d'un événement Avec fonction classique
link.addEventListener('click', function () {
    console.log("ClassicFunction, this = " + this);// this === Button (#Link Element)
});

// Appel de fonction depuis l'event click du Bouton
function clickFunction() {
    result.innerHTML += "<h2>Clické!</h2>";
}
// Appel de fonction depuis l'event click du Bouton
function clickConfirm() {
    let response = confirm("Etes-vous sur?");

    result.innerHTML += response === true ? "<h2>C'est confirmé</h2>" : "<h2>Ce n'est pas confirmé</h2>";
}

