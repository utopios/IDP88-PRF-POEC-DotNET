/**
 * Les Events en Javascript
 */

// Déclaration d'un fonction qu'on peut ratacher a un event
function myButtonClick() {
  alert("Vous avez cliqué sur le bouton");
}

function myMouseOver() {
  alert("Vous avez survolé le bouton");
}
function myDblClick() {
  alert("Vous avez double clické sur le bouton");
}

function myFunctionAlert(arg) {

  switch (arg) {
    case 1: alert("Vous avez cliqué sur le bouton 1"); break;
    case 2: alert("Vous avez survolé le bouton 2");
      break;
    case 3: alert("Vous avez double clické sur le bouton");
      break;
    case 4: alert("Vous n'avez plus le focus sur le bouton");
      break;
  }
}

document.addEventListener("keyup", function (event) {
  if (event.key === 'Enter') {
    alert("Vous avez appuyé sur Enter\nMessage : " + document.querySelector('#keyup').value)
  }
})

const touches = [...document.querySelectorAll('.bouton')];
const listKeyCode = touches.map(touche => touche.dataset.key);

document.addEventListener("keydown", (event) => {
  const valeur = event.key.toString()
  alert(valeur);
})

document.addEventListener("click", (event) => {
  const valeur = event.target.dataset.key;
  alert(valeur);
})