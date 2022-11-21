import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import './NavBarComponent.css';
import HomeView from '../../views/HomeView/HomeView';
import AboutView from '../../views/AboutView/AboutView';
import FormationListView from '../../views/FormationListView/FormationListView';

const NavBarComponent = ({cart, updateCart}) => {
    return (
        <div>
            <BrowserRouter>
                <div id="NavBar">
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/formation">FormationList</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/about">About</Link>
                    </button>
                </div>
                <Routes>
                    <Route path="/" element={<HomeView />} />
                    <Route path="/formation" element={<FormationListView cart={cart} updateCart={updateCart}/>} />
                    <Route path="/about" element={<AboutView />} />
                    <Route path="/*" element={<HomeView />} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
    );
}

export default NavBarComponent;
