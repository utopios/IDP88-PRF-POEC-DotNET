import React, { useState } from 'react';
import CategoryComponent from '../../components/CategoryComponent/CategoryComponent';
import './FormationListView.css';
import { coursList } from '../../datas/CoursList';
import FormationCardComponent from '../../components/FormationCardComponent/FormationCardComponent';

const FormationListView = () => {

    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category), []
    )
    //console.log(categoryList);

    return (
        <div className='formation-list'>
            <h2>Nos Formations</h2>
            <div className="row">
                <div className="col-8">
                    <CategoryComponent
                        categoryList={categoryList}
                        activeCategory={activeCategory}
                        setActiveCategory={setActiveCategory}
                    />
                </div>
                <div className="col-4">
                    {/* Panier */}
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?

                        <FormationCardComponent
                            key={index}
                            cours={cours}
                        />

                        :
                        null
                )
                }
            </div>
        </div>
    )
}

export default FormationListView;
