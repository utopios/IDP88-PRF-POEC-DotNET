const btnValider = document.querySelector('#btnValider');
const result = document.querySelector('#result');
const magic = document.querySelector('#magic');

function radioButton(){
    // 1ere solution avec document.querySelector('input[name=choix]:checked').value
    let affichage ="<ul><li> 1ere solution : " + document.querySelector('input[name=choix]:checked').value + "</li>";
    console.log(document.querySelector('input[name=choix]:checked').value);
    
    // 2eme solution avec getElementsByName
    const boutons = document.getElementsByName('choix');
    let valeur;
    for (let i = 0; i < boutons.length; i++) {
        if (boutons[i].checked) {
            affichage +="<li> 2eme solution (boucle for) : " + boutons[i].value + "</li>";
            valeur = boutons[i].value;
        }
    }
    console.log(valeur);
    for (const button of boutons){
        if (button.checked) {
            affichage +="<li> 2eme solution (for... of) : " + button.value + "</li>";
            valeur = button.value;
        }
    }
    console.log(valeur);
    
    // 3eme Solution avec l'id    
    valeur = "";
    if (document.getElementById('choix1').checked) {
        affichage +="<li> 3eme solution : " + document.getElementById('choix1').value; + "</li></ul>";
        valeur = document.getElementById('choix1').value;
    }
    else if (document.getElementById('choix2').checked) {
        affichage +="<li> 3eme solution : " + document.getElementById('choix2').value + "</li></ul>";
        valeur = document.getElementById('choix2').value;
    }
    else if (document.getElementById('choix3').checked) {
        affichage +="<li> 3eme solution : " + document.getElementById('choix3').value + "</li></ul>";
        valeur = document.getElementById('choix3').value;
    }
    console.log(valeur);
    result.innerHTML = affichage;
}

magic.addEventListener('click',()=>{
    radioButton();
})


btnValider.onclick = () => {
    radioButton();

}