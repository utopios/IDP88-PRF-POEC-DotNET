import React, { Component } from 'react';
import {ListPerson} from '../../datas/ListPerson';
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



class NavBarComponent extends Component {

    constructor(props){
        super(props);
        this.state = {
            personList: ListPerson
        }
    }

    updatePersonList = (list) =>{
        // console.log("Navbar : ")
        // console.table(list);
        this.setState({
            personList :list
        })
    }

    render() {
        return (
            <div>
            <BrowserRouter>
                <div id="navbar">
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
                    <Route path="/list" element={<ListPersonView personList={this.state.personList} updatePersonList={this.updatePersonList} />} />
                    <Route path="/form" element={<AddEditView personList={this.state.personList} updatePersonList={this.updatePersonList} />} />
                    <Route path="/form/:index" element={<AddEditView personList={this.state.personList} updatePersonList={this.updatePersonList} />} />
                    <Route path="/*" element={<HomeView />} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
        );
    }
}

export default NavBarComponent;