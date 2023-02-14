import React from 'react';
import {NavLink} from 'react-router-dom';
import "./NavBar.css";

const NavBar = () => {
    return (
        <div className='navBar'>
            <ul>
                <NavLink to="/" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
                    <li>Home</li>
                </NavLink>
                <NavLink to="/about" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
                    <li>About</li>
                </NavLink>
                <NavLink to="/autre" className={(nav)=>nav.isActive?'lien Active' : 'lien'}>
                    <li>Autre</li>
                </NavLink>
            </ul>
            
        </div>
    );
}

export default NavBar;
