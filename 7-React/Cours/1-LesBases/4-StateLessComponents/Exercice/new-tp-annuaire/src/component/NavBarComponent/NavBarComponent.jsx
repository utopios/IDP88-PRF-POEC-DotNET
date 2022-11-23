import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import HomeView from '../../view/HomeView/HomeView';
import ListPersonView from '../../view/ListPersonView/ListPersonView';
import AddEditView from '../../view/AddEditView/AddEditView';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHome, faAddressCard, faFolderPlus } from "@fortawesome/free-solid-svg-icons";
import './NavBarComponent.css';

const NavBarComponent = ({ personList, updatePersonList }) => {
    return (
        <div>
            <BrowserRouter>
                <div id="navbar">
                    {/* <Link to="/">
                        <button className='bouton'>
                            Home
                        </button>
                    </Link>
                    <Link to="/list">
                        <button className='bouton'>
                            List
                        </button>
                    </Link>
                    <Link to="/form">
                        <button className='bouton'>
                            Formulaire
                        </button>
                    </Link> */}
                    <Link to="/">
                        <FontAwesomeIcon className='iconMenu' icon={faHome} />
                    </Link>
                    <Link to="/list">
                        <FontAwesomeIcon className='iconMenu' icon={faAddressCard} />
                    </Link>
                    <Link to="/form">
                        <FontAwesomeIcon className='iconMenu' icon={faFolderPlus} />
                    </Link>
                    <hr />
                </div>
                <Routes>
                    <Route path="/" element={<HomeView />} />
                    <Route path="/list" element={<ListPersonView personList={personList} updatePersonList={updatePersonList} />} />
                    <Route path="/form" element={<AddEditView personList={personList} updatePersonList={updatePersonList} />} />
                    <Route path="/form/:index" element={<AddEditView personList={personList} updatePersonList={updatePersonList} />} />
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
