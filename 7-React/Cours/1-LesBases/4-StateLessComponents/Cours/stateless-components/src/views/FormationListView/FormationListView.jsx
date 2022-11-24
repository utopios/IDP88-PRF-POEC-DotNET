import React, { useState } from 'react';
import CategoryComponent from '../../components/CategoryComponent/CategoryComponent';
import './FormationListView.css';
import { coursList } from '../../datas/CoursList';
import FormationCardComponent from '../../components/FormationCardComponent/FormationCardComponent';
import CartComponent from '../../components/CartComponent/CartComponent';

const FormationListView = ({ cart, updateCart }) => {

    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category), []
    )
    //console.log(categoryList);

    function AddToCart(name, price) {

        const formationAdded = cart.find((cours) => cours.name === name);

        if (formationAdded) {
            const filteredCart = cart.filter(
                (cours) => cours.name !== name
            )
            updateCart([
                ...filteredCart,
                { name, price, amount: formationAdded.amount + 1 }
            ])
        }else{
            updateCart([
                ...cart,
                { name, price, amount: 1 }
            ])
        }
        alert(`La formation ${name} a été ajoutée !`);
    }

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
                    <CartComponent cart={cart} updateCart={updateCart} />
                </div>
            </div>
            <div className="card-container">
                {coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?

                        <div key={index} onClick={() => AddToCart(cours.name, cours.price)}>
                            <FormationCardComponent
                                key={index}
                                cours={cours}
                            />
                        </div>

                        :
                        null
                )
                }
            </div>
        </div>
    )
}

export default FormationListView;
