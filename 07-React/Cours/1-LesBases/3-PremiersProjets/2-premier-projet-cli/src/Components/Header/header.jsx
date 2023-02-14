import React from 'react';
import './header.css';

const Header = () => {
    const text = "Votre Formation Sur Mesure";

    return (
        <div className="header">
            <img src="./img/M2ILOGO2.png" alt="Logo- M2I" />
            <h2>M2IFormation</h2>
            <span><i>{text.toLocaleLowerCase()}</i></span>
        </div>
    );
}

export default Header;
