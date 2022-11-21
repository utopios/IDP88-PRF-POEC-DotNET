import React from 'react';
import CareScaleComponent from '../CareScaleComponent/CareScaleComponent';
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
                <CareScaleComponent ScaleValue={cours.difficulte} className="stars"/>
            </div>
            <div className="price">
                <span>Prix : <b>{cours.price}</b>€</span>
            </div>
        </div>
    );
}

export default FormationCardComponent;
