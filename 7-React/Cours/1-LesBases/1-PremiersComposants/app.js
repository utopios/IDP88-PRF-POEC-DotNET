/**
 * 0 - Création d'un element React (JSX)
 */

const nom = "Jeanne Dark";
const elementReact = <h2>Bonjour {nom}</h2>

/**
 * 1 - Création d'un composant React sans params
 */
function MyFirstComponent() {
    return (
        <h2>Bonjour {nom}</h2>
    )
}

/**
 * 2 - Création d'un composant React avec params
 */
function MySecondComponent({ nom, prenom }) {
    return (
        <h2>Bonjour {nom} {prenom}</h2>
    )
}

/**
 * 3 - Création d'un composant React avec params et utilsation d'une fonction
 */
// const user = {
//     firstname:"Eleonore",
//     lastname:"Marolex",
// }

function formatName({ user }) {
    return user.firstname + ' ' + user.lastname;
}

function MyThirdComponent(user) {
    return (
        <h2>Bonjour {formatName(user)}</h2>
    )
}

function MyPage() {
    const user = {
        firstname: "Eleonore",
        lastname: "Marolex",
    }
    return (
        <div>
            <MyFirstComponent />
            <MySecondComponent nom="Abadi" prenom="Ihab"/>
            <MyThirdComponent user={user}/>
        </div>
    )
}


/**
 * 0 - Rendu => Avec ElementReact (JSX)
 */

ReactDOM.render(
    elementReact,
    document.getElementById('root')
);

// /**
//  * 1 - Rendu => Avec Un composant (sans params)
//  */

// ReactDOM.render(
//     // <MyFirstComponent></MyFirstComponent>, // pas d'auto closable
//     <MyFirstComponent/>,
//     document.getElementById('app')
// );

/**
 * 2 - Rendu => Avec Un composant (avec params)
 */

// ReactDOM.render(    
//     <MySecondComponent nom="Toto" prenom="Titi"/>,
//     document.getElementById('app')
// );

/**
 * 3 - Rendu => Avec Un composant (avec objet)
 */

// ReactDOM.render(
//     <MyThirdComponent user={user} />,
//     document.getElementById('app')
// );

/**
 * 4 - Rendu => Avec MyPage (sans params)
 */

ReactDOM.render(
    //<MyPage />,
    <React.StrictMode>
        <MyPage />
    </React.StrictMode>,
    document.getElementById('app')
);
















