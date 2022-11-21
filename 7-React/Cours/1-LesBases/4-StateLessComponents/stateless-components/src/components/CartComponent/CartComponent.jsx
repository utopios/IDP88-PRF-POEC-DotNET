import React, { useState, useEffect } from 'react';
import './CartComponent.css';

const CartComponent = ({ cart, updateCart }) => {

    // State isOpen pour savoir si le panier est developpé ou non
    const [isOpen, setIsOpen] = useState(false);

    // Const Total pour le calcul du montant du panier
    const Total = cart.reduce((acc, cours) => acc + cours.price * cours.amount, 0);

    // Propage le montant du panier dans l'onglet du navigateur
    useEffect(() => {
        document.title = `Panier : ${Total}€`;
    }, [Total])

    return isOpen ? (
        <div className='relative'>
            <div className="cart-list over">
                {cart.length > 0 ?
                    <div>
                        <div>
                            <h2>Panier</h2>
                            <div className="inner-card">
                                {
                                    cart.map(({ name, price, amount }, index) => (
                                        <div key={index}>
                                            {name} : {price}€ x {amount}
                                            <hr />
                                        </div>
                                    ))
                                }
                            </div>
                            <h3>Total : {Total}€</h3>
                        </div>
                        <button className='btn btn-secondary space-Top' onClick={() => updateCart([])}>Vider le panier</button>
                    </div>
                    :
                    <div>
                        <span className='vide'>Votre panier est vide</span>
                    </div>

                }
                <button className='btn btn-secondary spaced' onClick={() => setIsOpen(false)}>fermer le panier</button>
            </div>
        </div>
    )
        :
        (
            <button className='btn btn-secondary' onClick={() => setIsOpen(true)}>Ouvrir le panier</button>
        )
}

export default CartComponent;
