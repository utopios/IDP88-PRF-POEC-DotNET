/**
 * Exercice19 - Switch - Quelle est la nature du triangle ABC...?
 */
//sALut cOMmeNT çA vA?

// Création de la constante result permettant de recupérer l'élément HTML class="result"
const result = document.querySelector('.result');

// Déclaration d'une variable pour l'affichage
var resultat, affichage;

// Affichage du titre
affichage="<h2>Quelle taille de vêtement vais-je prendre?</h2><br>";

// Récupération et stockage des saisie utilisateur
var taille = Number(prompt("Veuillez saisir votre taille (en cm) :"));
var poids = Number(prompt("Veuillez saisir votre poids (en kg) :"));
affichage+=`Pour <b>${taille}cm</b> et <b>${poids}kg</b> : <br>`;

// Etablissement Structure SWITCH pour vérifier la taille
switch (true) {
    case (taille >= 145 && taille < 172 && poids >= 43 && poids <= 47 ||
        taille >= 145 && taille < 169 && poids >= 48 && poids <= 53 ||
        taille >= 145 && taille < 166 && poids >= 54 && poids <= 59 ||
        taille >= 145 && taille < 163 && poids >= 60 && poids <= 65):
        affichage +=`<ul>
                        <li>Prennez la <b>taille 1</b>.</li>
                    </ul>
                    `;
        break;
    case (taille >= 169 && taille < 183 && poids >= 48 && poids <= 53 ||
        taille >= 166 && taille < 178 && poids >= 54 && poids <= 59 ||
        taille >= 163 && taille < 175 && poids >= 60 && poids <= 65 ||
        taille >= 160 && taille < 172 && poids >= 66 && poids <= 71):
        affichage +=`<ul>
                        <li>Prennez la <b>taille 2</b>.</li>
                    </ul>
                    `;
        break;
    case (taille >= 178 && taille <= 183 && poids >= 54 && poids <= 59 ||
        taille >= 175 && taille <= 183 && poids >= 60 && poids <= 65 ||
        taille >= 172 && taille <= 183 && poids >= 66 && poids <= 71 ||
        taille >= 163 && taille <= 183 && poids >= 72 && poids <= 77):
        affichage +=`<ul>
                        <li>Prennez la <b>taille 3</b>.</li>
                    </ul>
                    `;
        break;
    default: affichage +=`<ul>
                            <li><b>Aucune taille ne vous correspond.</b></li>
                        </ul>`;

}


// Affichage du résultat dans une popup alert()
//alert(resultat);

// Injection du résultat dans l'element HTML .result
result.innerHTML = affichage;