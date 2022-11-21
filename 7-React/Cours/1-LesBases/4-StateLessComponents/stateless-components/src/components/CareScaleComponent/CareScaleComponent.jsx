import React from 'react';
import './CareScaleComponent.css';

const CareScaleComponent = ({ ScaleValue }) => {

    const quantityLabel = {
        1: "Débutant",
        2: "Averti",
        3: "Confirmé",
        4: "Chevroné",
        5: "Expert"
    }

    const range = [1, 2, 3, 4, 5];

    const scaleType = <img src='./img/Star.png' alt='star-icon' height="20px" />

    return (
        <div onClick={()=>
            alert(`Cette formation requiert un niveau ${quantityLabel[ScaleValue]}`)
        }>
            {
                range.map((rangeElement) =>
                    ScaleValue >= rangeElement ?
                        <span key={rangeElement}>{scaleType}</span>
                        :
                        null
                )
            }
        </div>
    );
}

export default CareScaleComponent;
