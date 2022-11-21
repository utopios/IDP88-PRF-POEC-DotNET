import React from 'react';
import './FormationCardComponent.css';

const FormationCardComponent = ({ cours, index }) => {
    //console.log(cours)
    return (
        <div className='card' key={index}>
            <div className="card-title">
                {cours.name}
            </div>
            <div>
                <img className='img' src={cours.logo} alt="Formation-logo" />
            </div>
            <div className="category">
                <span><b>{cours.category}</b></span>
            </div>
            <div className="difficulty">
                <span className='diff-label'>Difficulté : </span>
                {cours.difficulte}
            </div>
            <div className="price">
                <span>Prix : <b>{cours.price}</b>€</span>
            </div>
        </div>
    );
}

export default FormationCardComponent;
