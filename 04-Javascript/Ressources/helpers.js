 // Méthode permettant de séparer le millier
 export function millier  (nbr , symbol )   {
    let nombre = '' + nbr;
    let retour = '';
    let count = 0;
    for (let i = nombre.length - 1; i >= 0; i--) {
        if (count != 0 && count % 3 == 0)
            retour = nombre[i] + symbol + retour;
        else
            retour = nombre[i] + retour;
        count++;
    }
   
    return retour;
}